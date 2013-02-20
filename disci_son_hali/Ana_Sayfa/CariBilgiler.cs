using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CariBilgiler : Form
    {

        ArrayList tedavi = new ArrayList();
        ArrayList fiyatlar = new ArrayList();
        DataTable dt = new DataTable();

        private string[] existCustomers = null;

        public CariBilgiler()
        {
            InitializeComponent();
        }

        private string ArrayListToString(ArrayList array, int index)
        {
            string[] gecici = new string[array.Count];

            int j = 0;

            foreach (string i in array)
            {
                gecici[j] = i;
                j++;
            }

            return gecici[index];
        }

        private void readTreatmentData()
        {
            if (File.Exists(@"C:\disci\tedavi.txt"))
            {
                StreamReader sr = new StreamReader(@"C:\disci\tedavi.txt", true);
                string[] tedaviler = sr.ReadToEnd().Split('\n');
                sr.Close();

                tedavi.Clear();
                tedavi.AddRange(tedaviler);
                tedavi.RemoveAt(tedavi.Count - 1);
            }
        }

        private void readPriceData() 
        {
            if (File.Exists(@"C:\disci\fiyat.txt"))
            {
                StreamReader sr = new StreamReader(@"C:\disci\fiyat.txt", true);
                string[] page = sr.ReadToEnd().Split('\n');
                sr.Close();

                for (int i = 0; i < page.Length - 1; i++)
                {
                    fiyatlar.Clear();
                    fiyatlar.AddRange(page);
                    fiyatlar.RemoveAt(fiyatlar.Count - 1);

                }
            }
        }

        private void setCustomers()
        {
            if (File.Exists(@"C:\disci\hasta_kayit.txt"))
            {
                StreamReader sr = new StreamReader(@"C:\disci\hasta_kayit.txt", true);
                existCustomers = sr.ReadToEnd().Split('\n');
                sr.Close();

                string[] line = null;

                for (int i = 0; i < existCustomers.Length - 1; i++)
                {
                    line = existCustomers[i].Split(':');

                    comboMusteriler.Items.Add(line[1] + " " + line[2]);
                }
            }
        }

        private void getCustomerTreatmentData()
        {
            string[] customer = existCustomers[comboMusteriler.SelectedIndex].Split(':');
            string[] line = null;
            string[] fiyatLine = null;

            while (dt.Rows.Count > 0)
                dt.Rows.RemoveAt(0);
           
            int tutar = 0;

            for (int i = 0; i < tedavi.Count; i++)
            {
                line = ArrayListToString(tedavi, i).Split(':');

                if (line[0] == customer[1] && line[1] == customer[2])
                {
                    for (int j = 0; j < 35; j++)
                    {
                        if (line[j + 2] == "Checked" && j < 33)
                        {
                            fiyatLine = ArrayListToString(fiyatlar,j).Split('|');

                            dt.Rows.Add(fiyatLine[1], fiyatLine[2]);
                            tutar += Convert.ToInt32(fiyatLine[2]);
                        }
                    }
                }
            }

            dataGridTedaviler.DataSource = dt;
            txtToplamTutar.Text = tutar.ToString();





            DataTable dtt = new DataTable();
            dtt.Columns.Add("AdıSoyadı", typeof(String));
            dtt.Columns.Add("kalanborc", typeof(String));

            while (dtt.Rows.Count > 0)
                dtt.Rows.RemoveAt(0);

            StreamReader sr = new StreamReader(@"C:\disci\cari_bilgi.txt", true);
            string[] page = sr.ReadToEnd().Split('\n');
            sr.Close();

            int kalan = tutar;
            int toplamodenen = 0;
            string[] line1 = null;

            for (int i = 0; i < page.Length - 1; i++)
            {

                line1 = page[i].Split(';');

                if (line1[0] == comboMusteriler.Text)
                {

                    dtt.Rows.Add(line1[0], line1[1]);
                    toplamodenen += Convert.ToInt32(line1[1]);
                    kalan -= Convert.ToInt32(line1[1]);


                }
                txtOdenenTutar.Text = Convert.ToString(toplamodenen);
                txtKalanTutar.Text = Convert.ToString(kalan);

            }












        }
       
        private void CariBilgiler_Load(object sender, EventArgs e)
        {
            setCustomers();
            readTreatmentData();
            readPriceData();

            dt.Columns.Add("Uygulanan Tedavi", typeof(string));
            dt.Columns.Add("Fiyatı", typeof(string));



        }

        private void btnTedaviler_Click(object sender, EventArgs e)
        {
           getCustomerTreatmentData();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


        /*    string activeDir = "c:/disci";



            //Create a new subfolder under the current active folder
            // string newPath = System.IO.Path.Combine(activeDir, "disci");

            // Create the subfolder
            System.IO.Directory.CreateDirectory(activeDir);

            // Create a new file name. This example generates
            // a random string.
            string newFileName = System.IO.Path.GetRandomFileName();






            string secili = "";
            FileStream f = new FileStream("C:/disci/cari_bilgi.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(f);
            // Stream dosya = File.OpenRead(@"C:\file_handling\file.txt");
            //StreamWriter dw =new StreamWriter(dosya);*/

            string secili = "";


            string activeDir = "c:/disci";



            //Create a new subfolder under the current active folder
            // string newPath = System.IO.Path.Combine(activeDir, "disci");

            // Create the subfolder
            System.IO.Directory.CreateDirectory(activeDir);

            // Create a new file name. This example generates
            // a random string.
            string newFileName = System.IO.Path.GetRandomFileName();







            FileStream f = new FileStream("C:/disci/cari_bilgi.txt", FileMode.Append, FileAccess.Write);

            // Stream dosya = File.OpenRead(@"C:\file_handling\file.txt");
            //StreamWriter dw =new StreamWriter(dosya);



            int toplamtutar = Convert.ToInt32(txtToplamTutar.Text);
            int odenentutar = Convert.ToInt32(txtOdenenTutar.Text);

            secili += comboMusteriler.Text + ";";

            secili += Convert.ToString(odenentutar) + ";";



            StreamWriter writer = new StreamWriter(f);



            writer.WriteLine(secili);
            writer.Close();

            txtToplamTutar.Text = "";
            txtOdenenTutar.Text = "";
            txtKalanTutar.Text = "";
            comboMusteriler.Text = "";
            dt.Clear();




        }

        private void dataGridTedaviler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtToplamTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOdenenTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKalanTutar_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
