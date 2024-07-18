using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            
            misir = Convert.ToInt16(txtMisir.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);
            bilet = Convert.ToInt16(txtBilet.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tüm Textbox'ları tekrar boşaltır.
            txtBilet.Text = "";
            txtSu.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtMisir.Focus(); // Textbox'a odaklar.
        }
    }
}
            

