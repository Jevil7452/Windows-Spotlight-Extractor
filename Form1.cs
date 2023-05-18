using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotlight_Extract
{
    public partial class Form1 : Form
    {
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Spotlight";
        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\\LocalState\\Assets";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(path))
            {
                if (!Directory.Exists(this.folder))
                {
                    Directory.CreateDirectory(this.folder);
                }
                foreach (string text in Directory.GetFiles(path))
                {
                    try
                    {
                        Image image = Image.FromFile(text);
                        if (image.Width > image.Height)
                        {
                            string str2 = "Landscape_" + Path.GetFileName(text) + ".jpg";
                            File.Copy(text, folder + "\\" + str2, true);
                        }

                        image.Dispose();
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(path))
            {
                if (!Directory.Exists(this.folder))
                {
                    Directory.CreateDirectory(this.folder);
                }
                foreach (string text in Directory.GetFiles(path))
                {
                    try
                    {
                        Image image = Image.FromFile(text);
                        if (image.Width < image.Height)
                        {
                            string str2 = "Portrait_" + Path.GetFileName(text) + ".jpg";
                            File.Copy(text, folder + "\\" + str2, true);
                        }

                        image.Dispose();
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(path))
            {
                if (!Directory.Exists(this.folder))
                {
                    Directory.CreateDirectory(this.folder);
                }
                foreach (string text in Directory.GetFiles(path))
                {
                    try
                    {
                        Image image = Image.FromFile(text);
                        if (image.Width > image.Height)
                        {
                            string str2 = "Landscape_" + Path.GetFileName(text) + ".jpg";
                            File.Copy(text, folder + "\\" + str2, true);
                        }
                        if (image.Width < image.Height)
                        {
                            string str2 = "Portrait_" + Path.GetFileName(text) + ".jpg";
                            File.Copy(text, folder + "\\" + str2, true);
                        }

                        image.Dispose();
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}