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
    public partial class AnamnezFormu : Form
    {
        private Form frm1;
        public AnamnezFormu()
        {
            InitializeComponent();
        }
        public AnamnezFormu(Form eski)
        {
            frm1 = eski; //Form2'nin kendisini oluşturan formu frm1 değişkenine atıyoruz
            
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string secili = "";
            FileStream f = new FileStream(@"C:\disci\anamnez_formu.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(f);
            // Stream dosya = File.OpenRead(@"C:\file_handling\file.txt");
            //StreamWriter dw =new StreamWriter(dosya);
            secili += maskedTextBox1.Text + ":";
            secili += textBox2.Text + ":";
            secili += textBox3.Text + ":";
            secili += textBox4.Text + ":";

            secili += textBox6.Text + ":";
            secili += textBox7.Text + ":";
            secili += textBox8.Text + ":";
            secili += textBox9.Text + ":";
            secili += textBox10.Text + ":";

            secili += groupBox1.Text + ":";
            secili += groupBox2.Text + ":";
            secili += groupBox3.Text + ":";
            secili += groupBox4.Text + ":";
            secili += groupBox5.Text + ":";
            secili += groupBox6.Text + ":";

            secili += checkedListBox1.Text + ":";



            secili += textBox6.Text + ":";
            secili += textBox7.Text + ":";
            secili += textBox8.Text + ":";
            secili += textBox9.Text + ":";
            secili += textBox10.Text + ":";

            secili += groupBox7.Text + ":";
            secili += groupBox8.Text + ":";
            secili += groupBox9.Text + ":";






            writer.WriteLine(secili);
            writer.Close();
        }

        private void AnamnezFormu_Load(object sender, EventArgs e)
        {

        }
        private void AnamnezFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Visible = true;//Form2'yi oluşturan formu görünür yapıyoruz yani Form1'i
        }
    }
}
