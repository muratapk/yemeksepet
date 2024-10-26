using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemeksepet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi;
            double urunFiyat;
           
            urunAdi = textBox1.Text;
            urunFiyat =Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                urunFiyat =urunFiyat- (urunFiyat * 3) / 100;
                toplam = toplam + urunFiyat;
            }
            else if (radioButton2.Checked)
            {
                urunFiyat =urunFiyat- (urunFiyat * 5) / 100;
                toplam=toplam + urunFiyat;
            }
            else if (radioButton3.Checked) {
                toplam =toplam+ urunFiyat;
            }
            else
            {
                MessageBox.Show("Bir Seçim Yapınız");
            }
            listBox1.Items.Add($"Ürün Adı{urunAdi} Ürün Fiyatı {urunFiyat}");
            textBox3.Text=toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
        }
    }
}
