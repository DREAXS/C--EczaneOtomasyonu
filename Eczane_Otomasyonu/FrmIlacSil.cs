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
    public partial class FrmIlacSil : Form
    {
        public FrmIlacSil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");
        public void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Ilaclar where Durum= true", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmIlacSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                MessageBox.Show("Aradığınız ilacın numarasını giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand("select * from Ilaclar where Durum= true and BarkodNo=@p1",con );
                cmd.Parameters.AddWithValue("@p1",int.Parse(txtBarkodNo.Text));
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                con.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz ilacın numarasını giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand("update Ilaclar set Durum = false where BarkodNo=@p1", con);
                cmd.Parameters.AddWithValue("@p1", int.Parse(txtBarkodNo.Text));
                con.Open();
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show(txtBarkodNo.Text + "  Numaralı kayıt silindi");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();
                txtBarkodNo.Text = "";

                listele();
            }
        }
    }
}
