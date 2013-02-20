using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        
        private void Form3_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("Adı", typeof(String));
            dt.Columns.Add("Soyadı", typeof(String));
            dt.Columns.Add("TC No", typeof(String));
            dt.Columns.Add("Ev Tel", typeof(String));
            dt.Columns.Add("Cep Tel", typeof(String));


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            while (dt.Rows.Count>0)
               dt.Rows.RemoveAt(0);

            StreamReader sr = new StreamReader(@"C:\disci\hasta_kayit.txt",true);
            string[] page = sr.ReadToEnd().Split('\n');
            sr.Close();
            string[] line = null;

            for (int i = 0; i < page.Length - 1; i++)
            {

                line = page[i].Split(':');

                if (line[1] == txtAd.Text && line[2] == txtSoyad.Text)
                {

                    dt.Rows.Add(line[1], line[2], line[0], line[9], line[10]);
                }
            }

            dataGridView1.DataSource = dt;

        }
        
    }
}
