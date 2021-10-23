using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaotomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bilet,indirim;
        int[] koltuk = new int[4];
        


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_biletsat_Click(object sender, EventArgs e)
        {
            
           
            
                koltuk[int.Parse(txt_salon.Text)] = koltuk[int.Parse(txt_salon.Text)] - int.Parse(txt_koltuk.Text);
                if (koltuk[int.Parse(txt_salon.Text)] > 0)
                {
                    bilet = int.Parse(txt_koltuk.Text) * 40;
                    if (cbx_indirim.Checked == true)
                    {
                        indirim = (bilet * 20) / 100;
                        bilet = bilet - indirim;
                    }
                }
                else
                {
                    MessageBox.Show("Koltuk Sayısı Yeterince Yok!");
                }
            
          
            


        }

        private void btn_boskoltuk_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text = koltuk[int.Parse(txt_salon.Text)].ToString();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            koltuk[int.Parse(txt_salon.Text)] = koltuk[int.Parse(txt_salon.Text)] + int.Parse(txt_koltuk.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            koltuk[1] = 30;
            koltuk[2] = 30;
            koltuk[3] = 30;
        }

        private void btn_bakiye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinema'nın Bakiyesi = "+bilet);
        }

        private void btn_biletiptal_Click(object sender, EventArgs e)
        {
            koltuk[int.Parse(txt_salon.Text)] =koltuk[int.Parse(txt_salon.Text)] + int.Parse(txt_koltuk.Text);
            if (koltuk[int.Parse(txt_salon.Text)] > 0 )
            {
                bilet = int.Parse(txt_koltuk.Text) / 40;
                if (cbx_indirim.Checked == true)
                {
                    bilet = indirim + bilet;
                }
            }
            else
            {
                MessageBox.Show("Koltuk Sayısı Yeterince Yok!");
            }

        }
    }
}
