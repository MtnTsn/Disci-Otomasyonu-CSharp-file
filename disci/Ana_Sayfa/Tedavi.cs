using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Tedavi : Form
    {
        string[] page = null;

        bool yeniMusteri = true;

        ArrayList tedavi = new ArrayList();

        public Tedavi()
        {
            InitializeComponent();
        }

        private string updateTreatmentData()
        {

            string[] customer = page[comboMusteriler.SelectedIndex].Split(':');

            string kayit = (customer[1] + ":" + customer[2]);


            for (int i = 0; i < chkListTedaviler.Items.Count; i++)
            {
                kayit += (":" + chkListTedaviler.GetItemCheckState(i).ToString());
            }

            for (int i = 0; i < chkListDisler1.Items.Count; i++)
            {
                kayit += (":" + chkListDisler1.GetItemCheckState(i).ToString());
            }


            for (int i = 0; i < chkListDisler2.Items.Count; i++)
            {
                kayit += (":" + chkListDisler2.GetItemCheckState(i).ToString());
            }


            for (int i = 0; i < chkListDisler3.Items.Count; i++)
            {
                kayit += (":" + chkListDisler3.GetItemCheckState(i).ToString());
            }


            for (int i = 0; i < chkListDisler4.Items.Count; i++)
            {
                kayit += (":" + chkListDisler4.GetItemCheckState(i).ToString());
            }

            return kayit;

        }

        private void setCustomers()
        {
            if (File.Exists(@"C:\disci\hasta_kayit.txt"))
            {
                StreamReader sr = new StreamReader(@"C:\disci\hasta_kayit.txt", true);
                page = sr.ReadToEnd().Split('\n');
                sr.Close();

                string[] line = null;

                for (int i = 0; i < page.Length - 1; i++)
                {
                    line = page[i].Split(':');

                    comboMusteriler.Items.Add(line[1] + " " + line[2]);
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] customer = page[comboMusteriler.SelectedIndex].Split(':');

            string[] line = null;

            foreach (string i in tedavi)
            {
                line = i.Split(':');

                if (line[0] == customer[1] && line[1] == customer[2])
                {
                    yeniMusteri = false;
                }
            }

            line = null;

            if (yeniMusteri)  //yeni müşteri değilse tedavi bilgileri için dosyaya ekleme işlemi yapar.
            {
                StreamWriter sw = new StreamWriter(@"c:\disci\tedavi.txt", true);
                sw.WriteLine(updateTreatmentData());
                sw.Close();
            }

            else // mevcut müşterinin tedavi bilgileri değiştirildiyse yeni ekleme yapmaz mevcut kaydı değiştirir.
            {


                for (int i = 0; i < tedavi.Count; i++)
                {
                    line = ArrayListToString(tedavi, i).Split(':');

                    if (line[0] == customer[1] && line[1] == customer[2])
                    {
                        tedavi[i] = updateTreatmentData();
                    }

                }

                File.Delete(@"C:\disci\tedavi.txt");

                StreamWriter sw = new StreamWriter(@"c:\disci\tedavi.txt", true);

                foreach (string i in tedavi)
                {
                    sw.WriteLine(i);
                }

                sw.Close();
            }

            readTreatmentData();
        }

        private void Tedavi_Load(object sender, EventArgs e)
        {
            setCustomers();
            readTreatmentData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\dis_resmi_3.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] customer = page[comboMusteriler.SelectedIndex].Split(':');

            string[] line = null;
            CheckState state = CheckState.Unchecked;

            bool musteriVarMi = false;

            foreach (string i in tedavi)
            {
                line = i.Split(':');

                if (line[0] == customer[1] && line[1] == customer[2])
                {
                    musteriVarMi = true;
                }
            }

            line = null;

            for (int i = 0; i < tedavi.Count; i++)
            {
                line = ArrayListToString(tedavi, i).Split(':');

                if (line[0] == customer[1] && line[1] == customer[2])
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (j < chkListTedaviler.Items.Count)
                        {
                            if (line[j + 2] == "Checked")
                                state = CheckState.Checked;
                            else if (line[j + 2] == "Unchecked")
                                state = CheckState.Unchecked;
                            chkListTedaviler.SetItemCheckState(j, state);
                        }
                        else if (j < (chkListTedaviler.Items.Count + chkListDisler1.Items.Count))
                        {
                            if (line[j + 2] == "Checked")
                                state = CheckState.Checked;
                            else if (line[j + 2] == "Unchecked")
                                state = CheckState.Unchecked;
                            chkListDisler1.SetItemCheckState(j - chkListTedaviler.Items.Count, state);

                        }
                        else if (j < (chkListTedaviler.Items.Count + chkListDisler1.Items.Count + chkListDisler2.Items.Count))
                        {
                            if (line[j + 2] == "Checked")
                                state = CheckState.Checked;
                            else if (line[j + 2] == "Unchecked")
                                state = CheckState.Unchecked;
                            chkListDisler2.SetItemCheckState(j - (chkListTedaviler.Items.Count + chkListDisler1.Items.Count), state);

                        }
                        else if (j < (chkListTedaviler.Items.Count + chkListDisler1.Items.Count + chkListDisler2.Items.Count + chkListDisler3.Items.Count))
                        {
                            if (line[j + 2] == "Checked")
                                state = CheckState.Checked;
                            else if (line[j + 2] == "Unchecked")
                                state = CheckState.Unchecked;
                            chkListDisler3.SetItemCheckState(j - (chkListTedaviler.Items.Count + chkListDisler1.Items.Count + chkListDisler2.Items.Count), state);

                        }
                        else if (j < (chkListTedaviler.Items.Count + chkListDisler1.Items.Count + chkListDisler2.Items.Count + chkListDisler3.Items.Count + chkListDisler4.Items.Count))
                        {
                            if (line[j + 2] == "Checked")
                                state = CheckState.Checked;
                            else if (line[j + 2] == "Unchecked")
                                state = CheckState.Unchecked;
                            chkListDisler4.SetItemCheckState(j - (chkListTedaviler.Items.Count + chkListDisler1.Items.Count + chkListDisler2.Items.Count + chkListDisler3.Items.Count), state);
                        }
                    }
                }
            }

            if (!musteriVarMi) // bu koşul ifadesi yeni kaydedilmiş bir müşterinin tedavi kaydının olmaması durumunda ekrandaki eski tedavi bilgilerini temizler.
            {
                for (int k = 0; k < chkListTedaviler.Items.Count; k++)
                {
                    chkListTedaviler.SetItemCheckState(k, CheckState.Unchecked);
                }

                for (int k = 0; k < chkListDisler1.Items.Count; k++)
                {
                    chkListDisler1.SetItemCheckState(k, CheckState.Unchecked);
                }


                for (int k = 0; k < chkListDisler2.Items.Count; k++)
                {
                    chkListDisler2.SetItemCheckState(k, CheckState.Unchecked);
                }


                for (int k = 0; k < chkListDisler3.Items.Count; k++)
                {
                    chkListDisler3.SetItemCheckState(k, CheckState.Unchecked);
                }


                for (int k = 0; k < chkListDisler4.Items.Count; k++)
                {
                    chkListDisler4.SetItemCheckState(k, CheckState.Unchecked);
                }

            }


        }

    }

}
    

