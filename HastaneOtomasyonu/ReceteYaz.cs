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
    public partial class ReceteYaz : Form
    {
        public ReceteYaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceteGoruntule receteGoruntule = new ReceteGoruntule();
            receteGoruntule.Show();
        }
    }
}
