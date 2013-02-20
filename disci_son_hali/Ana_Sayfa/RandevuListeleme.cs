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
    public partial class RandevuListeleme : Form
    {
        ArrayList tedavii = new ArrayList();
        public RandevuListeleme()
        {
            InitializeComponent();
        }
        DataTable dtt = new DataTable();

        private void RandevuListeleme_Load(object sender, EventArgs e)
        {

            dtt.Columns.Add("ADI", typeof(String));
            dtt.Columns.Add("SOYADI", typeof(String));
            dtt.Columns.Add("TARİH", typeof(String));
            dtt.Columns.Add("SAAT", typeof(String));
            dtt.Columns.Add("DOKTOR", typeof(String));
            dtt.Columns.Add("SIRA", typeof(String));


        /*    if (File.Exists(@"C:\disci\randevu_verme.txt"))
            {
                StreamReader sr = new StreamReader(@"C:\disci\randevu_verme.txt", true);
                string[] tedaviler1 = sr.ReadToEnd().Split('\n');
                sr.Close();

                tedavii.Clear();
                tedavii.AddRange(tedaviler1);
                tedavii.RemoveAt(tedavii.Count - 1);
            }

        */ 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* while (dtt.Rows.Count > 0)
               dtt.Rows.RemoveAt(0);*/

            StreamReader sr = new StreamReader(@"C:\disci\randevu_verme.txt", true);
            string[] page = sr.ReadToEnd().Split('\n');
            sr.Close();
            string[] line = null;

            for (int i = 0; i < page.Length - 1; i++)
            {

                line = page[i].Split(';');



                dtt.Rows.Add(line[0], line[1], line[2], line[3], line[4], line[5]);

            }

            dataGridView1.DataSource = dtt;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    /*    private void RandevuListeleme_Load(object sender, EventArgs e)
        {


            string rLine;
            string[] satirDizi;


            int i = 0;
            DataRow dRow;
            DataTable dt = new DataTable();
            try
            {
                if (File.Exists(@"C:/disci/randevu_verme.txt"))   //Öncelikle bu isimde bir dosyanın var olup olmadığını kontrol edelim.
                {
                    //üzerinde çalışacağımız txt dosyasına ulaşmak ve üzerinde çalışmak için bir reader nesnesi oluşturuyoruz.
                    StreamReader reader = File.OpenText(@"C:/disci/randevu_verme.txt");
                    rLine = reader.ReadLine();                    // txt dosyasının ilk satırını değişkenimize atıyoruz.
                    satirDizi = rLine.Split(';');


                    // Daha sonra tab ile değişkeni split ederek string dizimize atıyoruz.

                    //Datatable'ımıza ekleyeceğimiz değişken sayısı kadar kolon ekliyoruz.
                    for (int m = 0; m < satirDizi.Length; m++)
                    {

                        dt.Columns.Add(satirDizi[m]);
                    }

                    // dosyadan okuyabildiği sürece dönecek while.
                    while (rLine != null)
                    {
                        //datatable'a her seferinde bir satır ekliyoruz.
                        dRow = dt.NewRow();
                        dt.Rows.Add(dRow);
                        rLine = reader.ReadLine();
                        if (rLine != null)
                        {

                            satirDizi = rLine.Split(';');
                        }
                        //datatable'ın tüm hücrelerini teker teker dolduruyoruz.
                        for (int j = 0; j < satirDizi.Length; j++)
                        {

                            dt.Rows[i][j] = satirDizi[j].ToString();

                        }
                        i++;


                    }

                    dataGridView1.DataSource = dt;
                    // dataGridView1.DataSource = dt.Columns;
                    reader.Close();

                }
                else
                    MessageBox.Show("Dosya Bulunamadı...", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.ToString(), "Error");
            }
        }*/
        
    }
}
