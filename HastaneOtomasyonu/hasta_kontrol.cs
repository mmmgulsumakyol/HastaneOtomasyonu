using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class hasta_kontrol : Form
    {
        public string hastatc;
        public hasta_kontrol()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void hasta_kontrol_Load(object sender, EventArgs e)
        {
         
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            RandevuGecmisi randevuGecmisi = new RandevuGecmisi();
            randevuGecmisi.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            BilgiGuncelle bilgiGuncelle = new BilgiGuncelle();  
            bilgiGuncelle.Show();   
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
