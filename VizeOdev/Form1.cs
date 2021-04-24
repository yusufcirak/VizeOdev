using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace VizeOdev
{




public partial class Form1 : Form
    {
        DataTable tablo = new DataTable();
       
        public Form1()
        {
            InitializeComponent();
                      

        }

           
        public string dakkasaat;
        private void Form1_Load(object sender, EventArgs e)
        {


            label5.Text=("Veriler Hergün Saat 15:00'da Kayıt Edilecektir."+ "\n"+ "Lütfen Kayıt İşlemi Sırasında Kayıt Yerini Seçiniz...");

            timer1.Enabled = true;
            timer1.Start();

            dataGridView1.DataSource = tablo;
            tablo.Columns.Add("Döviz Cins", typeof(string));
            tablo.Columns.Add("Altın", typeof(double));
            tablo.Columns.Add("Gümüş", typeof(double));
            tablo.Columns.Add("Platin", typeof(double));
            tablo.Columns.Add("Paladyum", typeof(double));
      


            string exchangeRate = "https://www.borsaistanbul.com/datfile/kmtpkpnsxml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);

           
            
            string metal = xmlDoc.SelectSingleNode("IGE/IGE_GUN/gun").InnerXml;
            string metal1 = "TL";
            string metal2 = xmlDoc.SelectSingleNode("IGE/TL/altindeger").InnerXml;
            string metal3 = xmlDoc.SelectSingleNode("IGE/TL/gumusdeger").InnerXml;
            string metal4 = xmlDoc.SelectSingleNode("IGE/TL/platindeger").InnerXml;
            string metal5 = xmlDoc.SelectSingleNode("IGE/TL/paladyumdeger").InnerXml;
          
            string metal7 = "DOLAR";
            string metal8 = xmlDoc.SelectSingleNode("IGE/DOLAR/altindeger").InnerXml;
            string metal9 = xmlDoc.SelectSingleNode("IGE/DOLAR/gumusdeger").InnerXml;
            string metal10 = xmlDoc.SelectSingleNode("IGE/DOLAR/platindeger").InnerXml;
            string metal11 = xmlDoc.SelectSingleNode("IGE/DOLAR/paladyumdeger").InnerXml;
            string metal12 = "EURO";
            string metal13 = xmlDoc.SelectSingleNode("IGE/EURO/altindeger").InnerXml;
            string metal14 = xmlDoc.SelectSingleNode("IGE/EURO/gumusdeger").InnerXml;
            string metal15 = xmlDoc.SelectSingleNode("IGE/EURO/platindeger").InnerXml;
            string metal16 = xmlDoc.SelectSingleNode("IGE/EURO/paladyumdeger").InnerXml;
          
            label1.Text = metal;
            tablo.Rows.Add(metal1,metal2,metal3,metal4,metal5);
            tablo.Rows.Add(metal7, metal8, metal9, metal10,metal11);
            tablo.Rows.Add(metal12, metal13, metal14, metal15, metal16);
            ;



           










        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {








        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string daksaat = DateTime.Now.Minute.ToString();
            string saat = DateTime.Now.Hour.ToString();
            dakkasaat = saat + ":" + daksaat;
            label3.Text = dakkasaat;

            if (dakkasaat == "15:0")
            {


                timer1.Enabled = false;
                txtAktar.txtKaydet(dataGridView1);



                



            }
        }
    }
}
class txtAktar
{
    public static void txtKaydet(DataGridView veriTablosu)
    {
        try
        {
            SaveFileDialog dosyakaydet = new SaveFileDialog();
            dosyakaydet.FileName = "Metal Guncel Fiyat";
            dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            dosyakaydet.Filter = "Txt Dosyası|*.txt";
            if (dosyakaydet.ShowDialog() == DialogResult.OK)
            {
                TextWriter txt = new StreamWriter(dosyakaydet.FileName);
                foreach (DataGridViewColumn sutun in veriTablosu.Columns)
                {
                    txt.Write(sutun.HeaderText + "    ");
                }
                txt.Write("\n");
                foreach (DataGridViewRow satir in veriTablosu.Rows)
                {
                    foreach (DataGridViewCell hucre in satir.Cells)
                    {
                        txt.Write(hucre.Value.ToString() + "     ");
                    }
                    txt.Write("\n");
                }
                txt.Close();
                MessageBox.Show("TXT dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
            }
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message);
        }

    }
}