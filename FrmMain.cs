using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WinGost
{
    public partial class FrmMain : Form
    {
        byte[] encrByteFile, byteKey, decrByteFile;

        public FrmMain()
        {
            InitializeComponent();
           
            progressBar1.Minimum = 0;
            progressBar2.Minimum = 0;
        }

        // Обработчик кнопки шифрования текста
        private void fileEncryptButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            E32 e32;
            FileStream fileEn;


            if (decrTextBox.Text == "" || encrTextBox.Text == "")
                MessageBox.Show("Заполните все поля");
            else
            {
                byteKey = Encoding.Default.GetBytes(keyTextBox.Text);

                if ((byteKey == null) || (byteKey.Length != 32))
                    MessageBox.Show("Введдите 32-символьный ключ (256 бит)");
                else
                {
                    try
                    {
                        byte[] tmpArray = File.ReadAllBytes(decrTextBox.Text);

                        int size = tmpArray.Length;

                        while (size % 8 != 0)
                        {
                            size++;
                        }
                        byte[] text = new byte[size];

                        for (int i = 0; i < tmpArray.Length; i++)
                        {

                            text[i] = tmpArray[i];

                        }
                        if (tmpArray.Length % 8 == 0)
                        {
                            for (int i = tmpArray.Length; i < size; i++)
                            {

                                text[i] = 0;

                            }
                        }

                        progressBar1.Maximum = text.Length;

                        //encrTextBox.Text = "";
                        fileEn = System.IO.File.Create(encrTextBox.Text);

                        for (int i = 0; i < text.Length; i += 8)
                        {
                            byte[] block = new byte[8];
                            int k = 0;
                            for (int j = i; j < i + 8; j++)
                            {
                                block[k] = text[j];
                                k++;
                            }
                            // MessageBox.Show(block);


                            e32 = new E32(block, byteKey);
                            encrByteFile = e32.GetEncryptFile;


                            for (int j = 0; j < 8; j++)
                            {
                                fileEn.WriteByte(encrByteFile[j]);
                            }

                            //fileEn.Write(encrByteFile, i, 7);

                            progressBar1.Value += 8;
                        }
                        fileEn.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Ошибка!");
                    }
                }
            }
        }

        /// <summary>
        /// Обработчик кнопки создания ключа
        /// </summary>
        private void keyGenerateButton_Click(object sender, EventArgs e)
        {
            byteKey = CreateKey(tbPass.Text);
            keyTextBox.Text = BitConverter.ToString(byteKey).Replace("-","").Remove(32,32);

        }
        /// <summary>
        /// Постоянная "соль" для ключа
        /// </summary>
        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        /// <summary>
        /// Создание 256 битного ключа
        /// </summary>
        private static byte[] CreateKey(string password, int keyBytes = 32)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }

        // Обработчик кнопки дешефрования текста
        private void fileDecryptButton_Click(object sender, EventArgs e)
        {
            D32 d32;
            progressBar2.Value = 0;
            FileStream fileEn;
            if (textBoxInEn.Text == "" || textBoxText.Text == "")
                MessageBox.Show("Заполните все поля!");
            else
            {
                byteKey = Encoding.Default.GetBytes(keyTextBox.Text);

                if ((byteKey == null) || (byteKey.Length != 32))
                    MessageBox.Show("Введдите 32-символьный ключ (256 бит)");
                else
                {
                    try
                    {
                        byte[] tmpArray = File.ReadAllBytes(textBoxInEn.Text);

                        fileEn = System.IO.File.Create(textBoxText.Text);

                        int size = tmpArray.Length;

                        while (size % 8 != 0)
                        {
                            size++;
                        }
                        byte[] text = new byte[size];

                        for (int i = 0; i < tmpArray.Length; i++)
                        {

                            text[i] = tmpArray[i];

                        }
                        if (tmpArray.Length % 8 == 0)
                        {
                            for (int i = tmpArray.Length; i < size; i++)
                            {

                                text[i] = 0;

                            }
                        }

                        progressBar2.Maximum = text.Length;
                        for (int i = 0; i < text.Length; i += 8)
                        {
                            byte[] block = new byte[8];
                            int k = 0;
                            for (int j = i; j < i + 8; j++)
                            {
                                block[k] = text[j];
                                k++;
                            }


                            d32 = new D32(block, byteKey);
                            decrByteFile = d32.GetDecryptFile;


                            for (int j = 0; j < 8; j++)
                            {
                                fileEn.WriteByte(decrByteFile[j]);
                            }


                            //textBoxText.Text += Encoding.Default.GetString(decrByteFile);
                            progressBar2.Value += 8;
                        }
                        fileEn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!");
                    }
                }

            }
        }

      
      
        private void buttonSaveKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(OPF.FileName, keyTextBox.Text);
                    MessageBox.Show("Ключ успешно записан!", "успех!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Внимание ошибка: " + ex.Message, "Ошибка!");
                }
            }
        }

        private void textBoxInEn_TextChanged(object sender, EventArgs e)
        {
            if(textBoxInEn.Text.Length > 0)
            {
                fileDecryptButton.Enabled = true;

            }
            else
            {
                fileDecryptButton.Enabled = false;
            }
        }

        private void decrTextBox_TextChanged(object sender, EventArgs e)
        {
            var words = decrTextBox.Text;
            int wordss = words.Length;
          

            if (decrTextBox.Text.Length%8 == 0)
            {
                fileEncryptButton.Enabled = true;
            }
            else
            {
                fileEncryptButton.Enabled = false;
            }
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа выполнена в рамках курса:\nИнформационная безопасность\nСтудент СПбГТИ(ТУ) группы 475: Роман Овчинников","Разработчик");

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(OPF.FileName, decrTextBox.Text);
                    MessageBox.Show("Текст успешно записан!", "успех!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Внимание ошибка: " + ex.Message, "Ошибка!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxInEn.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(OPF.FileName, textBoxText.Text);
                    MessageBox.Show("Текст успешно записан!", "успех!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Внимание ошибка: " + ex.Message, "Ошибка!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(OPF.FileName, encrTextBox.Text);
                    MessageBox.Show("Шифр успешно записан!", "успех!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Внимание ошибка: " + ex.Message, "Ошибка!");
                }
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpED window = new HelpED();
            window.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void OpenButText_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                decrTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void OpenButEn_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    encrTextBox.Text = OPF.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Внимание ошибка: " + ex.Message, "Ошибка!");
                }
            }
        }

        private void OpenFileEnPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxInEn.Text = openFileDialog1.FileName;
            }
        }

        private void OpenFileTextPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPF = new SaveFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxText.Text = OPF.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Внимание ошибка: " + ex.Message, "Ошибка!");
                }
            }
        }


        // Обработчик кнопки загрузки ключа шифрования
        private void loadKeyButton_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string key = openFileDialog1.FileName;
                byteKey = File.ReadAllBytes(key);
                keyTextBox.Text = Encoding.Default.GetString(byteKey);
            }
        }

  
        // Обработчик кнопки загрузки файла
        private void fileLoadButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                decrByteFile = File.ReadAllBytes(file);
                decrTextBox.Text = Encoding.Default.GetString(decrByteFile);
            }
        }
    }
}
