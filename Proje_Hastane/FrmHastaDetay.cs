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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }


        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        public void randevuguncelle()
        {
          
            //Randevuları Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE HastaTC = '" + tc + "'", bgl.baglanti());//randevuu doktorunu benim doktoruma eşit olanları getirecek
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            // ad soyad çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            randevuguncelle();


            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();



        }


        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();  // `cmbdoktor`'daki mevcut tüm öğeleri temizle

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());//// SQL komutunu oluştur
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);// Seçilen branşı SQL komutunun parametresi olarak ekle
            SqlDataReader dr3 = komut3.ExecuteReader();  // SQL komutunu çalıştır ve veri okuyucusunu al
            while (dr3.Read()) // Verileri okuyun ve `cmbdoktor`'a ekleyin
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close(); // Veritabanı bağlantısını kapat
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cmbbrans.Text + "'" + "and RandevuDoktor='" + cmbdoktor.Text + "'and RandevuDurum=0 ", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = lbltc.Text;
            fr.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.Add("@p1", lbltc.Text);
            komut.Parameters.Add("@p2", rchsikayet.Text);
            komut.Parameters.Add("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            randevuguncelle();
            bgl.baglanti().Close();

            MessageBox.Show("Randevu Alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
