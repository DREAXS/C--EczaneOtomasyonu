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
    public partial class FrmHastaKaydi : Form
    {
        public FrmHastaKaydi()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");
        public void guvenceGetir()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Guvence",con);
            DataTable table = new DataTable();
            da.Fill(table);
            cbGuvence.ValueMember = "GuvenceNo";
            cbGuvence.DisplayMember = "GuvenceAdi";
            cbGuvence.DataSource = table;
        }

        private void FrmHastaKaydi_Load(object sender, EventArgs e)
        {
            guvenceGetir();
        }

        public int tcVarmi(string tc)
        {
            int sonuc = 1;
            OleDbCommand komut1 = new OleDbCommand("select * from Hastalar where TcNo = @p1", con);
            con.Open();
            komut1.Parameters.AddWithValue("@p1", tc);
            OleDbDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                sonuc = 0;
            }
            con.Close();

            
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtNo.Text == "" || txtAdress.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Tüm alanları eksiksiz giriniz!","Hata",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int tcSonuc = tcVarmi(txtNo.Text);

                if (tcSonuc == 0)
                {
                    MessageBox.Show(txtNo.Text + " Numaralı kayıt zaten mevcuttur", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    OleDbCommand komut = new OleDbCommand("insert into Hastalar values(?, ?, ?, ?, ?, ?)", con);
                    con.Open();
                    komut.Parameters.AddWithValue("?", txtNo.Text);
                    komut.Parameters.AddWithValue("?", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("?", txtAdress.Text);
                    komut.Parameters.AddWithValue("?", txtTel.Text);
                    komut.Parameters.AddWithValue("?", cbGuvence.SelectedValue);
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
                
            }
            txtAdress.Text = "";
            txtAdSoyad.Text = "";
            txtNo.Text = "";
            txtTel.Text = "";
        }
    }
}
