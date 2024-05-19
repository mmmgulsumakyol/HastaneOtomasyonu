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
    public partial class SekreterGiris : Form
    {
        public SekreterGiris()
        {
            InitializeComponent();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
          SekHastaOdaKayit hastaOdaKayit = new SekHastaOdaKayit();    
         hastaOdaKayit.Show();
        }

        private void btnDktrRandevu_Click(object sender, EventArgs e)
        {
           HastaRandevuSorgula hastaRandevuSorgula = new HastaRandevuSorgula();
            hastaRandevuSorgula.Show();
        }

        private void btnSekLab_Click(object sender, EventArgs e)
        {
           LabSonuc labSonuc = new LabSonuc();
            labSonuc.Show();
        }

        private void btnKlinik_Click(object sender, EventArgs e)
        {
            Klinik  klinik = new Klinik();  
            klinik.Show();  
        }

        private void btnSekDktr_Click(object sender, EventArgs e)
        {
            SekDoktor sekDoktor = new SekDoktor();
            sekDoktor.Show();
        }

        private void btnSekCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
