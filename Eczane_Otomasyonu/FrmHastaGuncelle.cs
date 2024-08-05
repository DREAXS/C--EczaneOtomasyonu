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
    public partial class FrmHastaGuncelle : Form
    {
        public FrmHastaGuncelle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");

        public void guvenceGetir()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Guvence", con);
            DataTable table = new DataTable();
            da.Fill(table);
            cbGuvence.ValueMember = "GuvenceNo";
            cbGuvence.DisplayMember = "GuvenceAdi";
            cbGuvence.DataSource = table;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select * from Hastalar where TcNo='" + txtTcNo.Text + "'", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtAdSoyad.Text = dr["AdSoyad"].ToString();
                txtAdress.Text = dr["Adres"].ToString();
                txtTel.Text = dr["Tel"].ToString();
                cbGuvence.SelectedValue = dr["Guvence"].ToString();
                cbDurum.Checked = bool.Parse(dr["Durum"].ToString()) ? true : false;
            }
            else
            {
                MessageBox.Show("Aradığınız kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();
        }

        private void FrmHastaGuncelle_Load(object sender, EventArgs e)
        {
            guvenceGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtTcNo.Text == "" || txtAdress.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Tüm alanları eksiksiz giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else {
                OleDbCommand komut = new OleDbCommand("update Hastalar set AdSoyad = @p1,Adres = @p2 , Tel=@p3, Guvence=@p4, Durum=@p5 where TcNo=@p6", con);
                con.Open();
                
                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtAdress.Text);
                komut.Parameters.AddWithValue("@p3", txtTel.Text);
                komut.Parameters.AddWithValue("@p4", cbGuvence.SelectedValue);
                komut.Parameters.AddWithValue("@p5", cbDurum.Checked ? true : false);
                komut.Parameters.AddWithValue("@p6", txtTcNo.Text);

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
                txtAdSoyad.Text = "";
                txtAdress.Text = "";
                txtTcNo.Text = "";
                txtTel.Text = "";
            }
        }
    }
}
