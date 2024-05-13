using DevExpress.Utils.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            temizle();
        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedAd.Text);
            komut.Parameters.AddWithValue("@p2", txedSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbxTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mtbsTc.Text);
            komut.Parameters.AddWithValue("@p5", txedMail.Text);
            komut.Parameters.AddWithValue("@p6", cbxIl.Text);
            komut.Parameters.AddWithValue("@p7", cbxIlce.Text);
            komut.Parameters.AddWithValue("@p8", rtbxAdres.Text);
            komut.Parameters.AddWithValue("@p9", txedGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel sisteme eklendi","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select sehir From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbxIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void cbxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from TBL_ILCELER where sehir = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cbxIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbxIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        void temizle()
        {
            txedAd.Text = "";
            txedSoyad.Text = "";
            txedID.Text = "";
            txedGorev.Text = "";
            txedMail.Text = "";
            cbxIl.Text = "";
            cbxIlce.Text = "";
            mtbsTc.Text = "";
            mtbxTelefon.Text = "";
            rtbxAdres.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_PERSONELLER where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Kaydı Silindi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txedID.Text = dr["ID"].ToString();
                txedAd.Text = dr["Ad"].ToString();
                txedSoyad.Text = dr["SOYAD"].ToString();
                mtbxTelefon.Text = dr["TELEFON"].ToString();
                mtbsTc.Text = dr["TC"].ToString();
                txedMail.Text = dr["MAIL"].ToString();
                cbxIl.Text = dr["IL"].ToString();
                cbxIlce.Text = dr["ILCE"].ToString();
                rtbxAdres.Text = dr["ADRES"].ToString();
                txedGorev.Text = dr["GOREV"].ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER set AD=@p1,SOYAD = @p2,TELEFON = @p3,TC = @p4,MAIL=@p5," +
                " IL = @p6,ILCE = @P7,ADRES = @p8,GOREV = @p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txedAd.Text);
            komut.Parameters.AddWithValue("@p2",txedSoyad.Text);
            komut.Parameters.AddWithValue("@p3",mtbxTelefon.Text);
            komut.Parameters.AddWithValue("@p4",mtbsTc.Text);
            komut.Parameters.AddWithValue("@p5",txedMail.Text);
            komut.Parameters.AddWithValue("@p6",cbxIl.Text);
            komut.Parameters.AddWithValue("@p7",cbxIlce.Text);
            komut.Parameters.AddWithValue("@p8",rtbxAdres.Text);
            komut.Parameters.AddWithValue("@p9",txedGorev.Text);
            komut.Parameters.AddWithValue("@p10",txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel kaydı güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
