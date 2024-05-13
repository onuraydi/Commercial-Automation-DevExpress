using DevExpress.Utils.DirectXPaint;
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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void firmaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR",bgl.baglanti());
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

        void temizle()
        {
            txedID.Text = "";
            txedAd.Text = "";
            txedSektor.Text = "";
            txedYetkili.Text = "";
            txedYetkiliGorev.Text = "";
            mtbTc.Text = "";
            mtbTel.Text = "";
            mtbTel2.Text = "";
            mtbTel3.Text = "";
            mtbFax.Text = "";
            txedMail.Text = "";
            cbxIl.Text = "";
            cbxIlce.Text = "";
            txedVergiDairesi.Text = "";
            rctbAdres.Text = "";
            txedOzelKod1.Text = "";
            txedOzelKod2.Text = "";
            txedOzelKod3.Text = "";
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmaListele();
            sehirListesi();
            carikodaciklamalar();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                txedID.Text = dr["ID"].ToString();
                txedAd.Text = dr["AD"].ToString();
                txedYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
                txedYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                mtbTc.Text = dr["YETKILITC"].ToString();
                txedSektor.Text = dr["SEKTOR"].ToString();
                mtbTel.Text = dr["TELEFON1"].ToString();
                mtbTel2.Text = dr["TELEFON2"].ToString();
                mtbTel3.Text = dr["TELEFON3"].ToString();
                txedMail.Text = dr["MAIL"].ToString();
                mtbFax.Text = dr["FAX"].ToString();
                cbxIl.Text = dr["IL"].ToString();
                cbxIlce.Text = dr["ILCE"].ToString();
                txedVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
                rctbAdres.Text = dr["ADRES"].ToString();
                txedOzelKod1.Text = dr["OZELKOD1"].ToString();
                txedOzelKod2.Text = dr["OZELKOD2"].ToString();
                txedOzelKod3.Text = dr["OZELKOD3"].ToString();

            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3," +
                "MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14," +
                "@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txedAd.Text);
            komut.Parameters.AddWithValue("@p2",txedYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p3",txedYetkili.Text);
            komut.Parameters.AddWithValue("@p4",mtbTc.Text);
            komut.Parameters.AddWithValue("@p5",txedSektor.Text);
            komut.Parameters.AddWithValue("@p6",mtbTel.Text);
            komut.Parameters.AddWithValue("@p7",mtbTel2.Text);
            komut.Parameters.AddWithValue("@p8",mtbTel3.Text);
            komut.Parameters.AddWithValue("@p9",txedMail.Text);
            komut.Parameters.AddWithValue("@p10",mtbFax.Text);
            komut.Parameters.AddWithValue("@p11",cbxIl.Text);
            komut.Parameters.AddWithValue("@p12",cbxIlce.Text);
            komut.Parameters.AddWithValue("@p13",txedVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p14",rctbAdres.Text);
            komut.Parameters.AddWithValue("@p15",txedOzelKod1.Text);
            komut.Parameters.AddWithValue("@p16",txedOzelKod2.Text);
            komut.Parameters.AddWithValue("@p17",txedOzelKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListele();
        }
        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rctbOzelKod1.Text = dr[0].ToString();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_FIRMALAR where ID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Silindi!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            firmaListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FIRMALAR set AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3," +
                "YETKILITC = @p4,SEKTOR = @p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12," +
                "VERGIDAIRE=@p13,ADRES = @p14,OZELKOD1 = @p15,OZELKOD2 = @p16, OZELKOD3 = @p17 where ID=@p18",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedAd.Text);
            komut.Parameters.AddWithValue("@p2", txedYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p3", txedYetkili.Text);
            komut.Parameters.AddWithValue("@p4", mtbTc.Text);
            komut.Parameters.AddWithValue("@p5", txedSektor.Text);
            komut.Parameters.AddWithValue("@p6", mtbTel.Text);
            komut.Parameters.AddWithValue("@p7", mtbTel2.Text);
            komut.Parameters.AddWithValue("@p8", mtbTel3.Text);
            komut.Parameters.AddWithValue("@p9", txedMail.Text);
            komut.Parameters.AddWithValue("@p10", mtbFax.Text);
            komut.Parameters.AddWithValue("@p11", cbxIl.Text);
            komut.Parameters.AddWithValue("@p12", cbxIlce.Text);
            komut.Parameters.AddWithValue("@p13", txedVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p14", rctbAdres.Text);
            komut.Parameters.AddWithValue("@p15", txedOzelKod1.Text);
            komut.Parameters.AddWithValue("@p16", txedOzelKod2.Text);
            komut.Parameters.AddWithValue("@p17", txedOzelKod3.Text);
            komut.Parameters.AddWithValue("@p18", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
