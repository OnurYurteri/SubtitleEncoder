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

namespace SubtitleEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Altyazı Seçiniz";
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Altyazı Dosyaları (SRT,SUB,TXT)|*.SRT;*.SUB;*.TXT";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog1.FileName;
                if (File.Exists(dosyaYolu) == true && (Path.GetExtension(dosyaYolu) == ".srt" || Path.GetExtension(dosyaYolu) == ".txt" || Path.GetExtension(dosyaYolu) == ".sub"))
                {
                    string text = File.ReadAllText(dosyaYolu, Encoding.Default);
                    File.WriteAllText(dosyaYolu, text, Encoding.UTF8);
                    MessageBox.Show("Altyazı Dönüştürüldü\n");
                }
                else
                {
                    MessageBox.Show("Sadece '.srt', '.sub' ve '.txt' formatları desteklenmektedir");
                }
            }
            

        }
    }
}
