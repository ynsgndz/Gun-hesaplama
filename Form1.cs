using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yasHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Gün";
            comboBox2.Text = "Ay";
            comboBox3.Text = "Yıl";
            comboBox4.Text = "Yıl";
            comboBox5.Text = "Ay";
            comboBox6.Text = "Gün";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(comboBox1.Text);
            int ay = Convert.ToInt32(comboBox2.Text);
            int yil = Convert.ToInt32(comboBox3.Text);

            int dGun = Convert.ToInt32(comboBox6.Text);
            int dAy = Convert.ToInt32(comboBox5.Text);
            int dYil = Convert.ToInt32(comboBox4.Text);

            DateTime dTarihi = new DateTime(dYil,dAy,dGun);
            DateTime suanTarihi = new DateTime(yil,ay,gun);
            //yıl ay gün saat dakika saniye 

            TimeSpan hesapla = suanTarihi - dTarihi;
            label6.Text =Convert.ToString( hesapla.TotalDays);
            label5.Text =Convert.ToString( hesapla.TotalHours);
            label4.Text=Convert.ToString( hesapla.Days/365);



        }
    }
}
