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
        int bilet,salon; 
        int[] koltuk = new int[4];
       
        


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_biletsat_Click(object sender, EventArgs e)
        {
            koltuk[salon] = koltuk[salon] - 1;
           
            salon = int.Parse(txt_salon.Text);
            if (cbx_indirim.Checked ==true)
            {
                bilet = bilet + 10;
            }
            else
            {
                bilet = bilet + 20;
            }
        }

        private void btn_boskoltuk_Click(object sender, EventArgs e)
        {
            salon = int.Parse(txt_salon.Text);
            lbl_sayi.Text = koltuk[salon].ToString();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            salon = int.Parse(txt_salon.Text);
            koltuk[salon] = koltuk[salon] + int.Parse(txt_koltuk.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
           
            
        }

        private void btn_bakiye_Click(object sender, EventArgs e)
        {
            salon = int.Parse(txt_salon.Text);
            MessageBox.Show("Sinema'nın Bakiyesi = "+bilet);
        }

        private void btn_biletiptal_Click(object sender, EventArgs e)
        {
            salon = int.Parse(txt_salon.Text);
            koltuk[salon] = koltuk[salon] + 1;
         
            if (cbx_indirim.Checked == true)
            {
                bilet = bilet - 10;
            }
            else
            {
                bilet = bilet - 20;
            }

        }
    }
}
