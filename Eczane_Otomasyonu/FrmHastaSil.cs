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
    public partial class FrmHastaSil : Form
    {
        public FrmHastaSil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");
        public void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Hastalar where Durum= true", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmHastaSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtTcNo.Text == "")
            {
                MessageBox.Show("Aradığınız kişinin numarasını giriniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Hastalar where Durum= true and TcNo='" + txtTcNo.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("update  Hastalar set Durum = false where TcNo=@p1",con);
            con.Open();
            cmd.Parameters.AddWithValue("@p1",txtTcNo.Text);
            int sonuc=cmd.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show(txtTcNo.Text + "  Numaralı kayıt silindi");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();

            listele();
        }

        private void txtTcNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
