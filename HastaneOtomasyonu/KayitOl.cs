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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        MySqlConnection connection;

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=localhost;Database=hastaneotomasyonu;Uid=root;Pwd=1234");
            if (txtad.Text == "" || txtsoyad.Text == "" || txttc.Text == "" || txttel.Text == "" || txtsifre.Text == "" || txtdyeri.Text==" "|dateTimePicker1.Text==""||txtanne.Text==""||txtbaba.Text==""||txtil.Text==""||txtilce.Text==""|txteposta.Text==""||txtadres.Text=="")
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                MySqlCommand komutkayıt = new MySqlCommand("insert into hastalar (hasta_ad,hasta_soyad,hasta_tc,hasta_tel,hasta_sifre,hasta_dyeri,hasta_dogum,hasta_anne,hasta_baba,hasta_il,hasta_ilce,hasta_eposta,hasta_adres,hasta_cins) values (@e1,@e2,@e3,@e4,@e5,@e6,@e7,@e8,@e9,@e10,@e11,@e12,@e13,@e14)");
                komutkayıt.Parameters.AddWithValue("@e1", txtad.Text);
                komutkayıt.Parameters.AddWithValue("@e2", txtsoyad.Text);
                komutkayıt.Parameters.AddWithValue("@e3", int.Parse(txttc.Text));
                komutkayıt.Parameters.AddWithValue("@e4", int.Parse(txttel.Text));
                komutkayıt.Parameters.AddWithValue("@e5", txtsifre.Text);
                komutkayıt.Parameters.AddWithValue("@e6", txtdyeri.Text);
                komutkayıt.Parameters.AddWithValue("@e7", dateTimePicker1.Text);
                komutkayıt.Parameters.AddWithValue("@e8", txtanne.Text);
                komutkayıt.Parameters.AddWithValue("@e9", txtbaba.Text);
                komutkayıt.Parameters.AddWithValue("@e10", txtil.Text);
                komutkayıt.Parameters.AddWithValue("@e11", txtilce.Text);
                komutkayıt.Parameters.AddWithValue("@e12", txteposta.Text);
                komutkayıt.Parameters.AddWithValue("@e13", txtadres.Text);
                komutkayıt.Parameters.AddWithValue("@e14", cmbcinsiyet.Text);
                komutkayıt.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kaydınız Oluşturuldu.");

              
            }
        }
       
    }
}
