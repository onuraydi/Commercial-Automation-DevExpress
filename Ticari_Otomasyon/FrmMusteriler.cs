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
using DevExpress.XtraDashboardLayout;
using DevExpress.XtraExport.Helpers;

namespace Ticari_Otomasyon
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void lbcIl_Click(object sender, EventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            temizle();
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
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
        }

        void temizle()
        {
            txedID.Text = "";
            txedAd.Text = "";
            txedSoyad.Text = "";
            mtbxTelefon.Text = "";
            mtbxtelefon2.Text = "";
            mtbsTc.Text = "";
            txedMail.Text = "";
            cbxIl.Text = "";
            cbxIlce.Text = "";
            txedVergiDairesi.Text = "";
            rtbxAdres.Text = "";
        }

        private void cbxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from TBL_ILCELER where sehir = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cbxIl.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbxIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close(); 
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRESI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedAd.Text);
            komut.Parameters.AddWithValue("@p2", txedSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbxTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mtbxtelefon2.Text);
            komut.Parameters.AddWithValue("@p5", mtbsTc.Text);
            komut.Parameters.AddWithValue("@p6", txedMail.Text);
            komut.Parameters.AddWithValue("@p7", cbxIl.Text);
            komut.Parameters.AddWithValue("@p8", cbxIlce.Text);
            komut.Parameters.AddWithValue("@p9", rtbxAdres.Text);
            komut.Parameters.AddWithValue("@p10",txedVergiDairesi.Text);
            komut.ExecuteNonQuery();
            
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                mtbxtelefon2.Text = dr["TELEFON2"].ToString();
                mtbsTc.Text = dr["TC"].ToString();
                txedMail.Text = dr["MAIL"].ToString();
                cbxIl.Text = dr["IL"].ToString();
                cbxIlce.Text = dr["ILCE"].ToString();
                rtbxAdres.Text = dr["ADRES"].ToString();
                txedVergiDairesi.Text = dr["VERGIDAIRESI"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_MUSTERILER where ID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri silindi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_MUSTERILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRESI=@p10 where ID=@p11",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedAd.Text);
            komut.Parameters.AddWithValue("@p2", txedSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtbxTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mtbxtelefon2.Text);
            komut.Parameters.AddWithValue("@p5", mtbsTc.Text);
            komut.Parameters.AddWithValue("@p6", txedMail.Text);
            komut.Parameters.AddWithValue("@p7", cbxIl.Text);
            komut.Parameters.AddWithValue("@p8", cbxIlce.Text);
            komut.Parameters.AddWithValue("@p9", rtbxAdres.Text);
            komut.Parameters.AddWithValue("@p10", txedVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p11", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşterinin bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
