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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        public void Guncelle()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtbransad.Text = "";
            txtbransid.Text = "";
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From  Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtbransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Guncelle();
            MessageBox.Show("Branş Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilien = dataGridView1.SelectedCells[0].RowIndex;
            txtbransid.Text = dataGridView1.Rows[secilien].Cells[0].Value.ToString();
            txtbransad.Text = dataGridView1.Rows[secilien].Cells[1].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branslar where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Guncelle();
            MessageBox.Show("Branş Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update  Tbl_Branslar set BransAd=@b1 where Bransid=@b2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtbransad.Text);
            komut.Parameters.AddWithValue("@b2", txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Guncelle();
            MessageBox.Show("Branş Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
