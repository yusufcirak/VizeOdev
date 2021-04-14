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




        private void button1_Click(object sender, EventArgs e)
        {

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
            

            tablo.Rows.Add(usd,usd2,usd3,usd4,usd5,usd6,usd7); 
           
            //usd = tablo.Columns[0].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
                   

            

           
            
            
        }
    }
}
