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

namespace _9._3._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int operacija = -1; // 0 - zbrajanje, 1 - oduzimanje, 2 - množenje, 3 - dijeljenje
        bool odabranaOperacija = false;

        private void button12_Click(object sender, EventArgs e)
        {
            operacija = 0;
            odabranaOperacija = true;
            obradi();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacija = 1;
            odabranaOperacija = true;
            obradi();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacija = 2;
            odabranaOperacija = true;
            obradi();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operacija = 3;
            odabranaOperacija = true;
            obradi();
        }

        private void obradi()
        {
            FileStream fs = new FileStream(@"D:\3.RT LK\Programiranje\9.3.2022\rezultati.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            {
                try
                {
                    if(odabranaOperacija)
                    {
                        
                        float rezultat = float.Parse(textBox1.Text.ToString());
                        switch (operacija)
                        {
                            case 0:
                                rezultat += float.Parse(textBox2.Text.ToString());
                                listBox1.Items.Add("+ " + textBox2.Text.ToString());
                                sw.WriteLine("+ " + textBox2.Text.ToString());
                                break;
                            case 1:
                                rezultat -= float.Parse(textBox2.Text.ToString());
                                listBox1.Items.Add("- " + textBox2.Text.ToString());
                                sw.WriteLine("- " + textBox2.Text.ToString());
                                break;
                            case 2:
                                rezultat *= float.Parse(textBox2.Text.ToString());
                                listBox1.Items.Add("* " + textBox2.Text.ToString());
                                sw.WriteLine("* " + textBox2.Text.ToString());
                                break;
                            case 3:
                                if (float.Parse(textBox2.Text.ToString()) == 0.0f)
                                    break;
                                rezultat /= float.Parse(textBox2.Text.ToString());
                                listBox1.Items.Add("/ " + textBox2.Text.ToString());
                                sw.WriteLine("/ " + textBox2.Text.ToString());
                                break;
                        }
                        
                        textBox1.Text = "" + rezultat;
                        textBox2.Text = "";
                        odabranaOperacija = false;
                    }
                }
                catch {
                    textBox2.Text = "";
                    operacija = -1;
                    odabranaOperacija = false;
                }

                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!odabranaOperacija)
                textBox2.Text += "1";
            else
                obradi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "2";
            else
                obradi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "3";
            else
                obradi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "4";
            else
                obradi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "5";
            else
                obradi();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "6";
            else
                obradi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "7";
            else
                obradi();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "8";
            else
                obradi();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "9";
            else
                obradi();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text += "0";
            else
                obradi();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!odabranaOperacija)
                textBox2.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\3.RT LK\Programiranje\9.3.2022\rezultati.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine("Rezultat: " + textBox1.Text);
            sw.WriteLine("");
            sw.WriteLine("-----------------------------------------------");
            sw.WriteLine("");
            sw.Flush();
            sw.Close();
            fs.Close();
            odabranaOperacija = false;
            operacija = -1;
            textBox1.Text = "0";
            textBox2.Text = "";
            listBox1.Items.Clear();
        }
    }
}
