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
            tablo.Columns.Add("Birim", typeof(double));
            tablo.Columns.Add("Döviz Cinsi", typeof(string));
            tablo.Columns.Add("Döviz Alış", typeof(double));
            tablo.Columns.Add("Döviz Satış", typeof(double));
            tablo.Columns.Add("Efektif Alış", typeof(double));
            tablo.Columns.Add("Efektif Satış", typeof(double));


            string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);

            //   string tarih= xmlDoc.SelectSingleNode("Tarih_Date").InnerXml;
            //  label1.Text = tarih;

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

            string dkk = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='DKK'] / Isim").InnerXml;
            string dkk2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='DKK'] / Unit").InnerXml;
            string dkk3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='DKK'] / CurrencyName").InnerXml;
            string dkk4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='DKK'] / ForexBuying").InnerXml;
            string dkk5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='DKK'] / ForexSelling").InnerXml;
            string dkk6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='DKK'] / BanknoteBuying").InnerXml;
            string dkk7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='DKK'] / BanknoteSelling").InnerXml;

            string EUR = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / Isim").InnerXml;
            string EUR2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / Unit").InnerXml;
            string EUR3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / CurrencyName").InnerXml;
            string EUR4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / ForexBuying").InnerXml;
            string EUR5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / ForexSelling").InnerXml;
            string EUR6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / BanknoteBuying").InnerXml;
            string EUR7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / BanknoteSelling").InnerXml;

            string GBP = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='GBP'] / Isim").InnerXml;
            string GBP2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='GBP'] / Unit").InnerXml;
            string GBP3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='GBP'] / CurrencyName").InnerXml;
            string GBP4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='GBP'] / ForexBuying").InnerXml;
            string GBP5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='GBP'] / ForexSelling").InnerXml;
            string GBP6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='GBP'] / BanknoteBuying").InnerXml;
            string GBP7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='GBP'] / BanknoteSelling").InnerXml;

            string CHF = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CHF'] / Isim").InnerXml;
            string CHF2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CHF'] / Unit").InnerXml;
            string CHF3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CHF'] / CurrencyName").InnerXml;
            string CHF4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CHF'] / ForexBuying").InnerXml;
            string CHF5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CHF'] / ForexSelling").InnerXml;
            string CHF6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CHF'] / BanknoteBuying").InnerXml;
            string CHF7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CHF'] / BanknoteSelling").InnerXml;

            string SEK = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SEK'] / Isim").InnerXml;
            string SEK2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SEK'] / Unit").InnerXml;
            string SEK3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SEK'] / CurrencyName").InnerXml;
            string SEK4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SEK'] / ForexBuying").InnerXml;
            string SEK5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SEK'] / ForexSelling").InnerXml;
            string SEK6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SEK'] / BanknoteBuying").InnerXml;
            string SEK7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SEK'] / BanknoteSelling").InnerXml;

            string CAD = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CAD'] / Isim").InnerXml;
            string CAD2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CAD'] / Unit").InnerXml;
            string CAD3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CAD'] / CurrencyName").InnerXml;
            string CAD4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CAD'] / ForexBuying").InnerXml;
            string CAD5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CAD'] / ForexSelling").InnerXml;
            string CAD6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CAD'] / BanknoteBuying").InnerXml;
            string CAD7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='CAD'] / BanknoteSelling").InnerXml;

            string KWD = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='KWD'] / Isim").InnerXml;
            string KWD2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='KWD'] / Unit").InnerXml;
            string KWD3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='KWD'] / CurrencyName").InnerXml;
            string KWD4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='KWD'] / ForexBuying").InnerXml;
            string KWD5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='KWD'] / ForexSelling").InnerXml;
            string KWD6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='KWD'] / BanknoteBuying").InnerXml;
            string KWD7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='KWD'] / BanknoteSelling").InnerXml;

            string NOK = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='NOK'] / Isim").InnerXml;
            string NOK2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='NOK'] / Unit").InnerXml;
            string NOK3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='NOK'] / CurrencyName").InnerXml;
            string NOK4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='NOK'] / ForexBuying").InnerXml;
            string NOK5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='NOK'] / ForexSelling").InnerXml;
            string NOK6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='NOK'] / BanknoteBuying").InnerXml;
            string NOK7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='NOK'] / BanknoteSelling").InnerXml;

            string SAR = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SAR'] / Isim").InnerXml;
            string SAR2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SAR'] / Unit").InnerXml;
            string SAR3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SAR'] / CurrencyName").InnerXml;
            string SAR4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SAR'] / ForexBuying").InnerXml;
            string SAR5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SAR'] / ForexSelling").InnerXml;
            string SAR6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SAR'] / BanknoteBuying").InnerXml;
            string SAR7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='SAR'] / BanknoteSelling").InnerXml;


            string JPY = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='JPY'] / Isim").InnerXml;
            string JPY2 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='JPY'] / Unit").InnerXml;
            string JPY3 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='JPY'] / CurrencyName").InnerXml;
            string JPY4 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='JPY'] / ForexBuying").InnerXml;
            string JPY5 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='JPY'] / ForexSelling").InnerXml;
            string JPY6 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='JPY'] / BanknoteBuying").InnerXml;
            string JPY7 = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='JPY'] / BanknoteSelling").InnerXml;

            tablo.Rows.Add(usd, usd2, usd3, usd4, usd5, usd6, usd7);
            tablo.Rows.Add(aud, aud2, aud3, aud4, aud5, aud6, aud7);
            tablo.Rows.Add(dkk, dkk2, dkk3, dkk4, dkk5, dkk6, dkk7);
            tablo.Rows.Add(EUR, EUR2, EUR3, EUR4, EUR5, EUR6, EUR7);
            tablo.Rows.Add(GBP, GBP2, GBP3, GBP4, GBP5, GBP6, GBP7);
            tablo.Rows.Add(CHF, CHF2, CHF3, CHF4, CHF5, CHF6, CHF7);
            tablo.Rows.Add(SEK, SEK2, SEK3, SEK4, SEK5, SEK6, SEK7);
            tablo.Rows.Add(CAD, CAD2, CAD3, CAD4, CAD5, CAD6, CAD7);
            tablo.Rows.Add(KWD, KWD2, KWD3, KWD4, KWD5, KWD6, KWD7);
            tablo.Rows.Add(NOK, NOK2, NOK3, NOK4, NOK5, NOK6, NOK7);
            tablo.Rows.Add(SAR, SAR2, SAR3, SAR4, SAR5, SAR6, SAR7);
            tablo.Rows.Add(JPY, JPY2, JPY3, JPY4, JPY5, JPY6, JPY7);

            //usd = tablo.Columns[0].ToString();



           



        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                            txt.Write(hucre.Value + ";");

                        }
                        txt.Write("\n");


                    }
                    txt.Close();
                    MessageBox.Show("Yeni Döviz Kurları Kaydedildi!\n" + "Dosya Konumu: " + dosyakaydet.FileName);
                }





            }

        }

    }
}