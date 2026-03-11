using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace lab2
{
    public partial class Form1 : Form
    {
        string ext;
        CipherAlg alg;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileImportButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    byte[] fileContent = System.IO.File.ReadAllBytes(filePath);
                    ext = Converter.GetExtension(openFileDialog.FileName);

                    plainText.Text = Converter.GetStringByBytes(fileContent);
                }
            }
        }

        private void fileExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = ext;
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    File.WriteAllBytes(fileName, alg.data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void encodeButton_Click(object sender, EventArgs e)
        {
            BitArray plain = Converter.GetBits(plainText.Text);
            string key = Converter.GetCorrectString(keyText.Text);
            if (CipherAlg.GetRegLength() == key.Length)
            {
                alg = new CipherAlg(plain, Converter.GetCorrectString(keyText.Text));
                byte[] cipher = alg.GetCipherText();
                keyText.Text = alg.GetKey();
                cipherText.Text = Converter.GetStringByBytes(alg.GetCipherText());
            }


            //           1010100010110100101110101111010
            //           1111111111111111111111111111111
            //           0000000000000000000000000000000
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            keyText.Text = "";
        }
    }
}
