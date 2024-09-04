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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string Tc;


        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = Tc;

            //Doktor Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0]+" "+dr[1];
            }
            bgl.baglanti().Close();


            //Randevuları Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+lbladsoyad.Text+"'", bgl.baglanti());//randevuu doktorunu benim doktoruma eşit olanları getirecek
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr=new FrmDoktorBilgiDuzenle();
            fr.TCNO = lbltc.Text;
            fr.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text=dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
