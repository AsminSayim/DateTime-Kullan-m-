using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "En Küçük" + DateTime.MinValue;
            label2.Text = "En Büyük: " + DateTime.MaxValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Now  : " + DateTime.Now;
            label3.Text = "Today: " + DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime tarihSaat1 = new DateTime();
            tarihSaat1 = DateTime.Now;

            DateTime tarih1 = new DateTime();
            tarih1 = DateTime.Today;

            label5.Text = tarihSaat1.ToString();
            label6.Text = tarih1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime tarihSaat = new DateTime();
            tarihSaat = DateTime.Now;

            DateTime tarih = new DateTime();
            tarih = DateTime.Today;

            label8.Text = tarihSaat.ToString();
            label7.Text = tarih.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = new DateTime(2022, 8, 25);


            label10.Text = "Tarih: " + bugun.ToShortDateString();
            label9.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime bugun1 = DateTime.Today;

            DateTime odemeGunu1 = dateTimePicker1.Value;


            label12.Text = "Tarih: " + bugun1.ToShortDateString();
            label11.Text = "Ödeme Günü: " + odemeGunu1.ToShortDateString();
        }
    }
}
