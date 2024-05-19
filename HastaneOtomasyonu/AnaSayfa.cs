using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HastaneOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt;

        KayitOl kayitOl = new KayitOl();    
        sifremi_unuttum sfr = new sifremi_unuttum();
        public AnaSayfa()
        {
            InitializeComponent();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitOl.Show();
        }

        private void sifre_unuttum_Click(object sender, EventArgs e)
        {
            sfr.Show();
          

        }

        private void giris_yap_Click(object sender, EventArgs e)
        {
            if (txtc.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new MySqlCommand("Select * From hastalar where txtc=@p1 and txtsifre=@p2", connection);
                command.Parameters.AddWithValue("@p1", txtc.Text);
                command.Parameters.AddWithValue("@p2", txtsifre.Text);
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    hasta_kontrol frmhasta = new hasta_kontrol();
                    frmhasta.hastatc = txtc.Text;
                    frmhasta.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("TC Kimlik No veya Şifre hatalı lütfen tekrar deneyiniz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void btnDktrGiris_Click(object sender, EventArgs e)
        {
            DktrGiris dktrGiris = new DktrGiris();  
            dktrGiris.Show();
        }

        private void btnSekGiris_Click(object sender, EventArgs e)
        {
            SekreterGiris sekreterGiris = new SekreterGiris();
            sekreterGiris.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

           

        }
    }
}
