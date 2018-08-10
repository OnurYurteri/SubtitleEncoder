using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SubtitleEncoder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0 && File.Exists(args[0]))
            {
                
                string dosyaYolu = args[0];
                if ((Path.GetExtension(dosyaYolu) == ".srt" || Path.GetExtension(dosyaYolu) == ".txt" || Path.GetExtension(dosyaYolu) == ".sub"))
                {
                    string text = File.ReadAllText(dosyaYolu, Encoding.Default);
                    File.WriteAllText(dosyaYolu, text, Encoding.UTF8);
                    MessageBox.Show("Altyazı Dönüştürüldü\nKrdş napıyon altyazıma geldi?");
                }
                else
                {
                    MessageBox.Show("Sadece '.srt', '.sub' ve '.txt' formatları desteklenmektedir");
                }
                
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
