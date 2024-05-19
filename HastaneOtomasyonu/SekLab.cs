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
    public partial class SekLab : Form
    {
        public SekLab()
        {
            InitializeComponent();
        }

        private void btnSebLabSorgula_Click(object sender, EventArgs e)
        {
            LabSonucSorgu labSonucSorgu = new LabSonucSorgu();
            labSonucSorgu.Show();
        }
    }
}
