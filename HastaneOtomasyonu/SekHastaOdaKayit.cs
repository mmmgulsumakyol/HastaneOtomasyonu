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
    public partial class SekHastaOdaKayit : Form
    {
        public SekHastaOdaKayit()
        {
            InitializeComponent();
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            SekIsmeGöreOda sekIsmeGöreOda = new SekIsmeGöreOda();
            sekIsmeGöreOda.Show();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            SekHastaBilgi sekHastaBilgi = new SekHastaBilgi();
            sekHastaBilgi.Show();   
        }

        private void btnDktrCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
