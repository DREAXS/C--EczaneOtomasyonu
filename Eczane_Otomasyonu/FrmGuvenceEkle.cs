using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    public partial class FrmGuvenceEkle : Form
    {
        public FrmGuvenceEkle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtGuvenceAdi.Text == "" )
            {
                MessageBox.Show("Güvence alanını eksiksiz giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                OleDbCommand komut = new OleDbCommand("insert into Guvence (GuvenceAdi,Durum) values(?, ?)", con);
                con.Open();
                komut.Parameters.AddWithValue("?", txtGuvenceAdi.Text);
                komut.Parameters.AddWithValue("?", true);

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Yapıldı");
                }
                else
                {
                    MessageBox.Show("Kayıt işleminde hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();


            }
            txtGuvenceAdi.Text = "";
        }
    }
}
