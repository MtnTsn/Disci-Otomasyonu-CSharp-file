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
    public partial class Form1 : Form
    {

        public static string activeDir = "C:\\disci";
            

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Visible = false;//bu formu yani Form1'i gizledik
            Form frm = new Form2(); //Burada Form2'nin aşırı yüklenmiş yapıcı methodunu kullanıyoruz
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Visible = false;//bu formu yani Form1'i gizledik
            Form3 frm = new Form3(); //Burada Form2'nin aşırı yüklenmiş yapıcı methodunu kullanıyoruz
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


           // this.Visible = false;//bu formu yani Form1'i gizledik
            Tedavi frm = new Tedavi(); //Burada Form2'nin aşırı yüklenmiş yapıcı methodunu kullanıyoruz
            frm.Show();

        }

     /*   private void button4_Click(object sender, EventArgs e)
        {
           // this.Visible = false;//bu formu yani Form1'i gizledik
            Form frm = new CariBilgiler(this); //Burada Form2'nin aşırı yüklenmiş yapıcı methodunu kullanıyoruz
            frm.Show();
        }*/

        private void button5_Click_1(object sender, EventArgs e)
        {



           // this.Visible = false;//bu formu yani Form1'i gizledik
            Form frm = new AnamnezFormu(this); //Burada Form2'nin aşırı yüklenmiş yapıcı methodunu kullanıyoruz
            frm.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\disci\randevu_verme.txt"))
            {
                RandevuListeleme frm = new RandevuListeleme();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Hiç randevu verilmemiş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void button7_Click(object sender, EventArgs e)
        {

           // string activeDir = "c:/disci";

           // System.IO.Directory.CreateDirectory(activeDir);

          

           // this.Visible = false;//bu formu yani Form1'i gizledik
            Form frm = new Randevu_Verme(this); //Burada Form2'nin aşırı yüklenmiş yapıcı methodunu kullanıyoruz
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            if (!Directory.Exists(activeDir))
                Directory.CreateDirectory(activeDir);

           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            CariBilgiler frm = new CariBilgiler(); //Burada Form2'nin aşırı yüklenmiş yapıcı methodunu kullanıyoruz
            frm.ShowDialog();
        }
    }
}
