using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double sonuc = (a)/Math.Pow(b,2);
            if (sonuc <= 18.5)
            {
                MessageBox.Show("İdealin Altı / Endeksi: " + sonuc );
            }
            else if (sonuc >= 18.5 && sonuc <= 25)
            {
                MessageBox.Show("İdeal / Endeksi: " + sonuc);
            }
            else if (sonuc >= 25 && sonuc < 29.99)
            {
                MessageBox.Show("İdeal Üzeri / Endeksi: " + sonuc);
            }
            else MessageBox.Show("Kilolu  / Endeksi: " + sonuc);
        }
    }
}
