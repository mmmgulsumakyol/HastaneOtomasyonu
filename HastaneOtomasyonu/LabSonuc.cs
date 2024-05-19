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
    public partial class LabSonuc : Form
    {
        public LabSonuc()
        {
            InitializeComponent();
        }

        private void btnLabKaydet_Click(object sender, EventArgs e)
        {
         
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            LabSonucSorgu labSonucS = new LabSonucSorgu();
            labSonucS.Show();
        }
    }
}
