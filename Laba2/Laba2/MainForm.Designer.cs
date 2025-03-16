namespace Laba2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            RegTextBox = new TextBox();
            RegLabel = new Label();
            KeyLabel = new Label();
            KeyTextBox = new TextBox();
            PlainTextLabel = new Label();
            CTextLabel = new Label();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            очиститьВсеПоляToolStripMenuItem = new ToolStripMenuItem();
            PlainTextBox = new TextBox();
            ResTextBox = new TextBox();
            ReadButton = new Button();
            SaveButton = new Button();
            ExecuteButton = new Button();
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RegTextBox
            // 
            RegTextBox.BorderStyle = BorderStyle.FixedSingle;
            RegTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegTextBox.Location = new Point(15, 73);
            RegTextBox.Multiline = true;
            RegTextBox.Name = "RegTextBox";
            RegTextBox.Size = new Size(336, 73);
            RegTextBox.TabIndex = 1;
            RegTextBox.TextChanged += RegTextBox_TextChanged;
            // 
            // RegLabel
            // 
            RegLabel.AutoSize = true;
            RegLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegLabel.Location = new Point(15, 43);
            RegLabel.Name = "RegLabel";
            RegLabel.Size = new Size(288, 27);
            RegLabel.TabIndex = 2;
            RegLabel.Text = "Состояние регистра (24): 0";
            // 
            // KeyLabel
            // 
            KeyLabel.AutoSize = true;
            KeyLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyLabel.Location = new Point(393, 43);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(264, 27);
            KeyLabel.TabIndex = 3;
            KeyLabel.Text = "Сгенерированный ключ:";
            // 
            // KeyTextBox
            // 
            KeyTextBox.BorderStyle = BorderStyle.FixedSingle;
            KeyTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyTextBox.Location = new Point(393, 73);
            KeyTextBox.Multiline = true;
            KeyTextBox.Name = "KeyTextBox";
            KeyTextBox.ReadOnly = true;
            KeyTextBox.Size = new Size(336, 73);
            KeyTextBox.TabIndex = 4;
            // 
            // PlainTextLabel
            // 
            PlainTextLabel.AutoSize = true;
            PlainTextLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlainTextLabel.Location = new Point(15, 163);
            PlainTextLabel.Name = "PlainTextLabel";
            PlainTextLabel.Size = new Size(181, 27);
            PlainTextLabel.TabIndex = 5;
            PlainTextLabel.Text = "Исходный текст:";
            // 
            // CTextLabel
            // 
            CTextLabel.AutoSize = true;
            CTextLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CTextLabel.Location = new Point(393, 163);
            CTextLabel.Name = "CTextLabel";
            CTextLabel.Size = new Size(114, 27);
            CTextLabel.TabIndex = 6;
            CTextLabel.Text = "Результат:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, очиститьВсеПоляToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(750, 33);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьКакToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(244, 34);
            открытьToolStripMenuItem.Text = "Открыть...";
            открытьToolStripMenuItem.Click += OpenFile;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Enabled = false;
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(244, 34);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            сохранитьКакToolStripMenuItem.Click += SaveFile;
            // 
            // очиститьВсеПоляToolStripMenuItem
            // 
            очиститьВсеПоляToolStripMenuItem.Name = "очиститьВсеПоляToolStripMenuItem";
            очиститьВсеПоляToolStripMenuItem.Size = new Size(179, 29);
            очиститьВсеПоляToolStripMenuItem.Text = "Очистить все поля";
            очиститьВсеПоляToolStripMenuItem.Click += ClearFields;
            // 
            // PlainTextBox
            // 
            PlainTextBox.BorderStyle = BorderStyle.FixedSingle;
            PlainTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlainTextBox.Location = new Point(15, 193);
            PlainTextBox.Multiline = true;
            PlainTextBox.Name = "PlainTextBox";
            PlainTextBox.ReadOnly = true;
            PlainTextBox.Size = new Size(336, 185);
            PlainTextBox.TabIndex = 8;
            // 
            // ResTextBox
            // 
            ResTextBox.BorderStyle = BorderStyle.FixedSingle;
            ResTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ResTextBox.Location = new Point(393, 193);
            ResTextBox.Multiline = true;
            ResTextBox.Name = "ResTextBox";
            ResTextBox.ReadOnly = true;
            ResTextBox.Size = new Size(336, 185);
            ResTextBox.TabIndex = 11;
            // 
            // ReadButton
            // 
            ReadButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ReadButton.Location = new Point(15, 394);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(336, 49);
            ReadButton.TabIndex = 12;
            ReadButton.Text = "Считать из файла";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += OpenFile;
            // 
            // SaveButton
            // 
            SaveButton.Enabled = false;
            SaveButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.Location = new Point(393, 394);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(336, 49);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Сохранить в файл";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveFile;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExecuteButton.Location = new Point(214, 466);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(318, 56);
            ExecuteButton.TabIndex = 14;
            ExecuteButton.Text = "Выполнить";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 541);
            Controls.Add(ExecuteButton);
            Controls.Add(SaveButton);
            Controls.Add(ReadButton);
            Controls.Add(ResTextBox);
            Controls.Add(PlainTextBox);
            Controls.Add(CTextLabel);
            Controls.Add(PlainTextLabel);
            Controls.Add(KeyTextBox);
            Controls.Add(RegTextBox);
            Controls.Add(KeyLabel);
            Controls.Add(RegLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лаба 2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox RegTextBox;
        private Label RegLabel;
        private Label KeyLabel;
        private TextBox KeyTextBox;
        private Label PlainTextLabel;
        private Label CTextLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem очиститьВсеПоляToolStripMenuItem;
        private TextBox PlainTextBox;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private TextBox ResTextBox;
        private Button ReadButton;
        private Button SaveButton;
        private Button ExecuteButton;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
    }
}
