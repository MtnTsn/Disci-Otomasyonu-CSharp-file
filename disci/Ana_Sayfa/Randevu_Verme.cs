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
    public partial class Randevu_Verme : Form
    {
       private Form frm1;
        public Randevu_Verme()
        {
            InitializeComponent();
        }
        public Randevu_Verme(Form eski)
        {
            frm1 = eski; //Form2'nin kendisini oluşturan formu frm1 değişkenine atıyoruz
            
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string activeDir = "c:/disci";



            //Create a new subfolder under the current active folder
            // string newPath = System.IO.Path.Combine(activeDir, "disci");

            // Create the subfolder
            System.IO.Directory.CreateDirectory(activeDir);

            // Create a new file name. This example generates
            // a random string.
            string newFileName = System.IO.Path.GetRandomFileName();






            string secili = "";
            FileStream f = new FileStream("C:/disci/randevu_verme.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(f);
            // Stream dosya = File.OpenRead(@"C:\file_handling\file.txt");
            //StreamWriter dw =new StreamWriter(dosya);
            secili += textad.Text + ";";
            secili += textsoyad.Text + ";";
            secili += maskedTextBox1.Text + ";";
            secili += maskedTextBox2.Text + ";";
            secili += textBox5.Text + ";";
            secili += textBox6.Text + ";";

           
         



            writer.WriteLine(secili);
            writer.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Randevu_Verme_Load(object sender, EventArgs e)
        {

        }
        private void RandevuVerme_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Visible = true;//Form2'yi oluşturan formu görünür yapıyoruz yani Form1'i
        }
    }
}
