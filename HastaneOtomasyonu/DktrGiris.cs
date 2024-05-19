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
    public partial class DktrGiris : Form
    {
        public DktrGiris()
        {
            InitializeComponent();
        }

        private void DktrGiris_Load(object sender, EventArgs e)
        {


        }

        private void btnDktrRandevu_Click(object sender, EventArgs e)
        {

            Randevularım randevularım   = new Randevularım();
            randevularım.Show();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
           ReceteYaz receteYaz = new ReceteYaz();   
           receteYaz.Show();
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            Laboratuvar lab= new Laboratuvar(); 
            lab.Show(); 
        }

        private void btnDktrBilgi_Click(object sender, EventArgs e)
        {
            DktrBilgi dktrBilgi = new DktrBilgi();
            dktrBilgi.Show();

        }
    }
}
