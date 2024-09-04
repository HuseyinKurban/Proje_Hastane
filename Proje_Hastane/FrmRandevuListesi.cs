using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proje_Hastane
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

        }

        public FrmSekreterDetay frm1;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            frm1.txtid.Text=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm1.msktarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm1.msksaat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm1.cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm1.cmbdoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm1.msktc.Text=dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            bool durum = Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value);
            frm1.chkdurum.Checked = durum;

        }
    }
}
