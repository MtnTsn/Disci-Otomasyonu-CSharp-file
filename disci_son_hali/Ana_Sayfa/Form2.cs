using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "" ||
            textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox12.Text == "" ||
            textBox11.Text == "" || textBox13.Text == "" || textBox14.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show(" Tüm Bilgileri Eksiksiz Giriniz! ");

            }

            else
            {




                // System.IO.Directory.CreateDirectory(@"C:\disci");
                // Path.Combine(SettingsFolder, "file.txt");

                // TextWriter dosya = new StreamWriter(@"C:\hastakayit.txt");

                // FileStream dr;
                //StreamWriter dw;

                FileStream f = new FileStream(@"C:\disci\hasta_kayit.txt", FileMode.Append);
                StreamWriter writer = new StreamWriter(f);
                // Stream dosya = File.OpenRead(@"C:\file_handling\file.txt");
                //StreamWriter dw =new StreamWriter(dosya);

                string secili = null;

                secili += textBox1.Text + ":";
                secili += textBox2.Text + ":";
                secili += textBox3.Text + ":";
                secili += textBox4.Text + ":";
                secili += maskedTextBox1.Text + ":";
                secili += textBox6.Text + ":";
                secili += textBox7.Text + ":";
                secili += textBox8.Text + ":";
                secili += textBox9.Text + ":";
                secili += textBox10.Text + ":";
                secili += textBox11.Text + ":";
                secili += textBox12.Text + ":";
                secili += textBox13.Text + ":";
                secili += textBox14.Text + ":";
                secili += comboBox1.Text + ":";
                secili += comboBox2.Text + ":";
                secili += dateTimePicker1.Text;


                writer.WriteLine(secili);
                writer.Close();
                f.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                maskedTextBox1.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";



            }


           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

             
    }
}
