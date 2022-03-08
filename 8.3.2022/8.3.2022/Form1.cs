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
using System.Diagnostics;

namespace _8._3._2022
{
    public partial class Form1 : Form
    {
        public string path = "D:\\Backup\\Pictures\\";
        public void getPictures()
        {
            listBox1.Items.Clear();
            try
            {
                foreach (string datoteka in Directory.GetFiles(path))
                {
                    string imeDatoteke = Path.GetFileName(datoteka);
                    if(imeDatoteke.EndsWith(".png") || imeDatoteke.EndsWith(".jpg"))
                        listBox1.Items.Add(imeDatoteke);
                }
            }
            catch { }
        }

        public Form1()
        {
            InitializeComponent();
            getPictures();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getPictures();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach(FileInfo file in di.GetFiles())
                {
                    if (file.Name.EndsWith(".png") || file.Name.EndsWith(".jpg"))
                    {
                        if ((file.CreationTime >= monthCalendar1.SelectionStart && file.CreationTime <= monthCalendar1.SelectionEnd) || (file.LastWriteTime >= monthCalendar1.SelectionStart && file.LastWriteTime <= monthCalendar1.SelectionEnd))
                        {
                            listBox2.Items.Add(file.Name.ToString());
                        }
                    }
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int tempI = 0;
            int x = 0;
            int y = 0;
            int sizeX = 200;
            int sizeY = 200;
            for (int i=0;i<numericUpDown1.Value;i++)
            {
                Random rnd = new Random();
                Panel pan = new Panel();
                pan.Size = new Size(sizeX, sizeY);
                pan.BackgroundImage = Image.FromFile(path + listBox1.Items[rnd.Next(listBox1.Items.Count)].ToString());
                pan.BackgroundImageLayout = ImageLayout.Zoom;
                if(i < 3)
                    pan.Location = new Point(x + (sizeX * i) + 15, y);
                else
                {
                    pan.Location = new Point(x + (sizeX * tempI) + 15, y + sizeY + 15);
                    tempI++;
                }
                pan.ContextMenuStrip = contextMenuStrip1;
                panel1.Controls.Add(pan);
            }
        }

        private void izbrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control odabraniPanel = contextMenuStrip1.SourceControl;
            panel1.Controls.Remove(odabraniPanel);
        }
    }
}
