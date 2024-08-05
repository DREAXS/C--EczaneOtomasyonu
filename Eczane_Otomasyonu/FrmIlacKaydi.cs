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
    public partial class FrmIlacKaydi : Form
    {
        public FrmIlacKaydi()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");

        

        private void FrmIlacKaydi_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFirmaAdi.Text == "" ||  txtIlacAdi.Text == "" || txtFiyat.Text == "" || txtAdet.Text=="")
            {
                MessageBox.Show("Tüm alanları eksiksiz giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                    OleDbCommand komut = new OleDbCommand("insert into Ilaclar (IlacAdı,FirmaAdı,Fiyat,Adet,Durum) values(?, ?, ?, ?, ?)", con);
                    con.Open();
                    komut.Parameters.AddWithValue("?", txtIlacAdi.Text);
                    komut.Parameters.AddWithValue("?", txtFirmaAdi.Text);
                    komut.Parameters.AddWithValue("?", txtFiyat.Text);
                    komut.Parameters.AddWithValue("?", txtAdet.Text);
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
            txtAdet.Text = "";
            txtFirmaAdi.Text = "";
            txtFiyat.Text = "";
            txtIlacAdi.Text = "";
        }
    }
}
