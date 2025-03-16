using System.Collections;
using System.Text;

namespace Laba2
{
    public partial class MainForm : Form
    {

        public bool[] register;
        public bool[] key;
        public bool[] plaintext;
        public bool[] ciphertext;

        public MainForm()
        {
            InitializeComponent();
        }

        private void RegTextBox_TextChanged(object sender, EventArgs e)
        {
            int length = 0;

            foreach (char c in RegTextBox.Text)
            {
                if (c == '0' || c == '1')
                {
                    length++;
                }
            }
            RegLabel.Text = $"Состояние регистра (24): {length}";
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            RegTextBox.Text = new string(RegTextBox.Text.Where(c => c == '0' || c == '1').ToArray());

            if (RegTextBox.Text.Length != 24)
            {
                MessageBox.Show("Длина регистра должна быть равна 24 символам!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(PlainTextBox.Text))
            {
                MessageBox.Show("Выберите файл с исходным текстом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitializeRegister(RegTextBox.Text);
            GenerateKey(plaintext.Length);

            KeyTextBox.Text = ArrayToStr(key);

            Encrypt();

            ResTextBox.Text = ArrayToStr(ciphertext);
            SaveButton.Enabled = true;
            сохранитьКакToolStripMenuItem.Enabled = true;
        }

        string ArrayToStr(bool[] array)
        {
            StringBuilder result = new();

            if (array.Length <= 160)
            {
                foreach (bool bit in array)
                {
                    result.Append(bit ? '1' : '0');
                }
            }
            else
            {
                result.Append("Первые 10 байт: \n");
                for (int i = 0; i < 80; i++)
                {
                    result.Append(array[i] ? '1' : '0');
                }

                result.Append($"{Environment.NewLine}Последние 10 байт: \n");
                for (int i = array.Length - 80; i < array.Length; i++)
                {
                    result.Append(array[i] ? '1' : '0');
                }
            }

            return result.ToString();
        }

        public void InitializeRegister(string input)
        {
            register = new bool[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                register[i] = input[i] == '1';
            }
        }

        public void GenerateKey(int length)
        {
            key = new bool[length];
            int[] taps = { 0, 2, 3, 23 }; // Позиции многочлена x^24 + x^3 + x^2 + x^0

            for (int i = 0; i < length; i++)
            {
                key[i] = register[0];
                bool newBit = false;

                foreach (int tap in taps)
                {
                    newBit ^= register[23 - tap];
                }

                for (int j = 0; j < register.Length - 1; j++)
                {
                    register[j] = register[j + 1];
                }

                register[register.Length - 1] = newBit;
            }
        }

        public void Encrypt()
        {
            ciphertext = new bool[plaintext.Length];
            for (int i = 0; i < plaintext.Length; i++)
            {
                ciphertext[i] = plaintext[i] ^ key[i];
            }
        }

        void OpenFile(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                StringBuilder stringBuilder = new StringBuilder();
                var bytes = File.ReadAllBytes(OpenFileDialog.FileName);

                foreach (byte b in bytes)
                {
                    for (int bit = 7; bit >= 0; bit--)
                    {
                        stringBuilder.Append(((b >> bit) & 1) == 1 ? '1' : '0');
                    }
                }

                plaintext = stringBuilder.ToString().Select(c => c == '1').ToArray();
                PlainTextBox.Text = ArrayToStr(plaintext);
            }
        }

        void SaveFile(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                using FileStream fileStream = new FileStream(SaveFileDialog.FileName, FileMode.Create);
                byte[] result = new byte[ciphertext.Length / 8];
                for (int i = 0; i < result.Length; i++)
                {
                    for (int bit = 0; bit < 8; bit++)
                    {
                        if (ciphertext[i * 8 + bit])
                        {
                            result[i] |= (byte)(1 << (7 - bit));
                        }
                    }
                }
                fileStream.Write(result, 0, result.Length);
            }
        }

        void ClearFields(object sender, EventArgs e)
        {
            KeyTextBox.Clear();
            PlainTextBox.Clear();
            ResTextBox.Clear();
        }
    }
}