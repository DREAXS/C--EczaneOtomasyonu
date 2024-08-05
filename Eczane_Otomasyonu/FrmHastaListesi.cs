using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    public partial class FrmHastaListesi : Form
    {
        public FrmHastaListesi()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbEczane.accdb");
        public void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Hastalar where Durum= true",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmHastaListesi_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
