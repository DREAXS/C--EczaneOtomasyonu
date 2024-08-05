using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Eczane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");

        void listele()
        {
            OleDbCommand komut = new OleDbCommand("select * from Satislar", con);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTcNo.Text == "" || txtBarkodNo.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Girin","Eksik Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                bool sonuc1 = false;
                bool sonuc2 = false;
                int toplamFiyat = 0,fyt=0;

                OleDbCommand komut1 = new OleDbCommand("select * from Hastalar where TcNo = @p1", con);
                con.Open();
                komut1.Parameters.AddWithValue("@p1", txtTcNo.Text);
                OleDbDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                {
                    sonuc1 = true;
                }
                con.Close();

                OleDbCommand komut2 = new OleDbCommand("select * from Ilaclar where BarkodNo = @p1", con);
                con.Open();
                komut2.Parameters.AddWithValue("@p1", txtBarkodNo.Text);
                OleDbDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read()) 
                {
                    fyt = int.Parse(dr2["Fiyat"].ToString() );
                    sonuc2 = true;
                }
                con.Close();

                if (!sonuc1)
                    MessageBox.Show("Lütfen Hasta Kaydı Yapınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!sonuc2)
                    MessageBox.Show("Lütfen İlaç Kaydı Yapınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    OleDbCommand komut = new OleDbCommand("insert into Satislar(HastaNo,IlacNo,Adet,ToplamFiyat,Tarih,Durum) values (?, ?, ?, ?, ?, ?)", con);
                    
                    con.Open();
                    toplamFiyat = fyt * int.Parse(numAdet.Value.ToString()) ;
                    komut.Parameters.AddWithValue("?", txtTcNo.Text);
                    komut.Parameters.AddWithValue("?", txtBarkodNo.Text);
                    komut.Parameters.AddWithValue("?", numAdet.Value);
                    komut.Parameters.AddWithValue("?", toplamFiyat);
                    komut.Parameters.AddWithValue("?", DateTime.Now);
                    komut.Parameters.AddWithValue("?", true);

                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Toplam Fiyat : " + toplamFiyat);
                        MessageBox.Show("Satış Yapıldı", "Satış");
                    }
                    else
                    {
                        MessageBox.Show("Satış işleminde hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    con.Close();
                }

                listele();
            }

        }

        private void hastaKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaKaydi fr = new FrmHastaKaydi();
            fr.Show();
        }

        private void hastalarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaListesi fr = new FrmHastaListesi();
            fr.Show();
        }

        private void hastaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaSil fr = new FrmHastaSil();
            fr.Show();
        }

        private void hastayıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaGuncelle fr = new FrmHastaGuncelle();
            fr.Show();
        }

        private void ilaçKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIlacKaydi fr=new FrmIlacKaydi();
            fr.Show();
        }

        private void ilaçlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIlacListele fr = new FrmIlacListele(); 
            fr.Show();
        }

        private void ilaçSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIlacSil fr = new FrmIlacSil();
            fr.Show();
        }

        private void ilaçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIlacGuncelle fr = new FrmIlacGuncelle();
            fr.Show();
        }

        private void güvenceEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGuvenceEkle fr = new FrmGuvenceEkle();
            fr.Show();
        }
    }
}
