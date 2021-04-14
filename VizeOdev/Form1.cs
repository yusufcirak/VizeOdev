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






        private void Form1_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = tablo;
            tablo.Columns.Add("Döviz Kodu", typeof(string));
            tablo.Columns.Add("Birim", typeof(float));
            tablo.Columns.Add("Döviz Cinsi", typeof(string));
            tablo.Columns.Add("Döviz Alış", typeof(float));
            tablo.Columns.Add("Döviz Satış", typeof(float));
            tablo.Columns.Add("Efektif Alış", typeof(float));
            tablo.Columns.Add("Efektif Satış", typeof(float));


            string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);
            string usd = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / Isim").InnerXml;
            string usd2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / Unit").InnerXml;
            string usd3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / CurrencyName").InnerXml;
            string usd4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / ForexBuying").InnerXml;
            string usd5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / ForexSelling").InnerXml;
            string usd6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / BanknoteBuying").InnerXml;
            string usd7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / BanknoteSelling").InnerXml;

            string aud = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='AUD'] / Isim").InnerXml;
            string aud2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='AUD'] / Unit").InnerXml;
            string aud3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='AUD'] / CurrencyName").InnerXml;
            string aud4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='AUD'] / ForexBuying").InnerXml;
            string aud5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='AUD'] / ForexSelling").InnerXml;
            string aud6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='AUD'] / BanknoteBuying").InnerXml;
            string aud7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='AUD'] / BanknoteSelling").InnerXml;

            tablo.Rows.Add(usd, usd2, usd3, usd4, usd5, usd6, usd7);
            tablo.Rows.Add(aud, aud2, aud3, aud4, aud5, aud6, aud7);
            //usd = tablo.Columns[0].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {








        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtAktar.txtKaydet(dataGridView1);

        }



        public class txtAktar
        {
            public static void txtKaydet(DataGridView veriTablosu)
            {
                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "Döviz Kurları";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "Txt Dosyası|*.txt";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    TextWriter txt = new StreamWriter(dosyakaydet.FileName);
                    foreach (DataGridViewColumn srg in veriTablosu.Columns)
                    {
                        txt.Write(srg.HeaderText + ";");
                    }
                    txt.Write("\n");
                    foreach (DataGridViewRow satir in veriTablosu.Rows)
                    {
                        foreach (DataGridViewCell hucre in satir.Cells)
                        {
                            //txt.Write(hucre.Value.ToString() + ";");
                            txt.Write(hucre.Value + ";");

                        }
                        txt.Write("\n");


                    }
                    txt.Close();
                    MessageBox.Show("TXT dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName);
                }

            }

        }
    }
}