namespace WinGost
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.loadKeyButton = new System.Windows.Forms.Button();
            this.fileEncryptButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenButEn = new System.Windows.Forms.Button();
            this.encrTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenButText = new System.Windows.Forms.Button();
            this.decrTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OpenFileTextPath = new System.Windows.Forms.Button();
            this.OpenFileEnPath = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInEn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.fileDecryptButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button8 = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ длиной 32 символа:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.keyTextBox.Location = new System.Drawing.Point(13, 73);
            this.keyTextBox.MaxLength = 32;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(422, 30);
            this.keyTextBox.TabIndex = 1;
            this.keyTextBox.Text = "6EC732EF1A78AE5880BC9A46F677C3CB";
            // 
            // loadKeyButton
            // 
            this.loadKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadKeyButton.Font = new System.Drawing.Font("Arial", 12F);
            this.loadKeyButton.Location = new System.Drawing.Point(443, 59);
            this.loadKeyButton.Name = "loadKeyButton";
            this.loadKeyButton.Size = new System.Drawing.Size(120, 57);
            this.loadKeyButton.TabIndex = 2;
            this.loadKeyButton.Text = "Загрузить ключ";
            this.loadKeyButton.UseVisualStyleBackColor = true;
            this.loadKeyButton.Click += new System.EventHandler(this.loadKeyButton_Click);
            // 
            // fileEncryptButton
            // 
            this.fileEncryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileEncryptButton.Font = new System.Drawing.Font("Arial", 12F);
            this.fileEncryptButton.Location = new System.Drawing.Point(524, 225);
            this.fileEncryptButton.Name = "fileEncryptButton";
            this.fileEncryptButton.Size = new System.Drawing.Size(123, 51);
            this.fileEncryptButton.TabIndex = 7;
            this.fileEncryptButton.Text = "Шифровать";
            this.fileEncryptButton.UseVisualStyleBackColor = true;
            this.fileEncryptButton.Click += new System.EventHandler(this.fileEncryptButton_Click);
            // 
            // buttonSaveKey
            // 
            this.buttonSaveKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveKey.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonSaveKey.Location = new System.Drawing.Point(569, 59);
            this.buttonSaveKey.Name = "buttonSaveKey";
            this.buttonSaveKey.Size = new System.Drawing.Size(120, 57);
            this.buttonSaveKey.TabIndex = 9;
            this.buttonSaveKey.Text = "Сохранить ключ";
            this.buttonSaveKey.UseVisualStyleBackColor = true;
            this.buttonSaveKey.Click += new System.EventHandler(this.buttonSaveKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите путь к исходному тексту:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F);
            this.tabControl1.Location = new System.Drawing.Point(15, 171);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 329);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.OpenButEn);
            this.tabPage1.Controls.Add(this.encrTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.OpenButText);
            this.tabPage1.Controls.Add(this.decrTextBox);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.fileEncryptButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифровать";
            // 
            // OpenButEn
            // 
            this.OpenButEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButEn.Location = new System.Drawing.Point(552, 122);
            this.OpenButEn.Name = "OpenButEn";
            this.OpenButEn.Size = new System.Drawing.Size(95, 36);
            this.OpenButEn.TabIndex = 20;
            this.OpenButEn.Text = "Обзор";
            this.OpenButEn.UseVisualStyleBackColor = true;
            this.OpenButEn.Click += new System.EventHandler(this.OpenButEn_Click);
            // 
            // encrTextBox
            // 
            this.encrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encrTextBox.Location = new System.Drawing.Point(22, 128);
            this.encrTextBox.Name = "encrTextBox";
            this.encrTextBox.Size = new System.Drawing.Size(522, 30);
            this.encrTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(18, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Введите путь для сохранения результата:\r\n";
            // 
            // OpenButText
            // 
            this.OpenButText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButText.Location = new System.Drawing.Point(552, 43);
            this.OpenButText.Name = "OpenButText";
            this.OpenButText.Size = new System.Drawing.Size(95, 36);
            this.OpenButText.TabIndex = 17;
            this.OpenButText.Text = "Обзор";
            this.OpenButText.UseVisualStyleBackColor = true;
            this.OpenButText.Click += new System.EventHandler(this.OpenButText_Click);
            // 
            // decrTextBox
            // 
            this.decrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decrTextBox.Location = new System.Drawing.Point(22, 49);
            this.decrTextBox.Name = "decrTextBox";
            this.decrTextBox.Size = new System.Drawing.Size(522, 30);
            this.decrTextBox.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(22, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(625, 31);
            this.progressBar1.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.OpenFileTextPath);
            this.tabPage2.Controls.Add(this.OpenFileEnPath);
            this.tabPage2.Controls.Add(this.textBoxText);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxInEn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.fileDecryptButton);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифровать";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // OpenFileTextPath
            // 
            this.OpenFileTextPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileTextPath.Location = new System.Drawing.Point(545, 125);
            this.OpenFileTextPath.Name = "OpenFileTextPath";
            this.OpenFileTextPath.Size = new System.Drawing.Size(95, 36);
            this.OpenFileTextPath.TabIndex = 29;
            this.OpenFileTextPath.Text = "Обзор";
            this.OpenFileTextPath.UseVisualStyleBackColor = true;
            this.OpenFileTextPath.Click += new System.EventHandler(this.OpenFileTextPath_Click);
            // 
            // OpenFileEnPath
            // 
            this.OpenFileEnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileEnPath.Location = new System.Drawing.Point(545, 41);
            this.OpenFileEnPath.Name = "OpenFileEnPath";
            this.OpenFileEnPath.Size = new System.Drawing.Size(95, 36);
            this.OpenFileEnPath.TabIndex = 28;
            this.OpenFileEnPath.Text = "Обзор";
            this.OpenFileEnPath.UseVisualStyleBackColor = true;
            this.OpenFileEnPath.Click += new System.EventHandler(this.OpenFileEnPath_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxText.Location = new System.Drawing.Point(19, 131);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(520, 30);
            this.textBoxText.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Введите путь для сохранения результата:\r\n";
            // 
            // textBoxInEn
            // 
            this.textBoxInEn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInEn.Location = new System.Drawing.Point(19, 48);
            this.textBoxInEn.Name = "textBoxInEn";
            this.textBoxInEn.Size = new System.Drawing.Size(520, 30);
            this.textBoxInEn.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Введите путь к шифр-тексту:";
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(19, 179);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(621, 33);
            this.progressBar2.TabIndex = 21;
            // 
            // fileDecryptButton
            // 
            this.fileDecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDecryptButton.Location = new System.Drawing.Point(505, 221);
            this.fileDecryptButton.Name = "fileDecryptButton";
            this.fileDecryptButton.Size = new System.Drawing.Size(135, 51);
            this.fileDecryptButton.TabIndex = 8;
            this.fileDecryptButton.Text = "Дешифровать";
            this.fileDecryptButton.UseVisualStyleBackColor = true;
            this.fileDecryptButton.Click += new System.EventHandler(this.fileDecryptButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 36);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разработчикToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // разработчикToolStripMenuItem
            // 
            this.разработчикToolStripMenuItem.Name = "разработчикToolStripMenuItem";
            this.разработчикToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.разработчикToolStripMenuItem.Text = "Разработчик";
            this.разработчикToolStripMenuItem.Click += new System.EventHandler(this.разработчикToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Arial", 12F);
            this.button8.Location = new System.Drawing.Point(441, 132);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(248, 33);
            this.button8.TabIndex = 16;
            this.button8.Text = "Сгенерировать";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.keyGenerateButton_Click);
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.Font = new System.Drawing.Font("Arial", 12F);
            this.tbPass.Location = new System.Drawing.Point(13, 136);
            this.tbPass.MaxLength = 32;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(422, 30);
            this.tbPass.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Текст для генерации ключа:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 507);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSaveKey);
            this.Controls.Add(this.loadKeyButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(723, 554);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм шифрования ГОСТ 28147-89";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button loadKeyButton;
        private System.Windows.Forms.Button fileEncryptButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button fileDecryptButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox encrTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OpenButText;
        private System.Windows.Forms.TextBox decrTextBox;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInEn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenButEn;
        private System.Windows.Forms.Button OpenFileTextPath;
        private System.Windows.Forms.Button OpenFileEnPath;
    }
}

