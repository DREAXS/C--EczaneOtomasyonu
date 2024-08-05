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
    public partial class FrmIlacGuncelle : Form
    {
        public FrmIlacGuncelle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                MessageBox.Show("Lütfen aradığınız ilacın numarasını giriniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand("select * from Ilaclar where BarkodNo=@p1", con);
                cmd.Parameters.AddWithValue("@p1", int.Parse(txtBarkodNo.Text));
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtIlacAdi.Text = dr[1].ToString();
                    txtFirmaAdi.Text = dr[2].ToString();
                    txtFiyat.Text = dr[3].ToString();
                    txtAdet.Text = dr[4].ToString();
                    cbDurum.Checked = bool.Parse(dr[5].ToString()) ? true : false;
                }
                else
                {
                    MessageBox.Show("Aradığınız kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();
            }
            
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtIlacAdi.Text == "" || txtFirmaAdi.Text == "" || txtBarkodNo.Text == "" || txtAdet.Text == ""||txtFiyat.Text=="")
            {
                MessageBox.Show("Tüm alanları eksiksiz giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                OleDbCommand komut = new OleDbCommand("update Ilaclar set IlacAdı = @p1,FirmaAdı = @p2 , Fiyat=@p3, Adet=@p4, Durum=@p5 where BarkodNo=@p6", con);
                con.Open();

                komut.Parameters.AddWithValue("@p1", txtIlacAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtFirmaAdi.Text);
                komut.Parameters.AddWithValue("@p3", txtFiyat.Text);
                komut.Parameters.AddWithValue("@p4", txtAdet.Text);
                komut.Parameters.AddWithValue("@p5", cbDurum.Checked ? true : false);
                komut.Parameters.AddWithValue("@p6", txtBarkodNo.Text);

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme Yapıldı");
                }
                else
                {
                    MessageBox.Show("Güncelleme işleminde hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();
                txtAdet.Text = "";
                txtBarkodNo.Text = "";
                txtFirmaAdi.Text = "";
                txtFiyat.Text = "";
                txtIlacAdi.Text = "";
            }
        }
    }
}
