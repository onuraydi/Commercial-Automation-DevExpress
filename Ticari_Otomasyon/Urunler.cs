using DevExpress.XtraBars;
using DevExpress.XtraExport.Helpers;
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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Urunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        void Ekle()
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // verileri kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER " +
                "(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",
                bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txedAd.Text);
            komut.Parameters.AddWithValue("@p2", txedMarka.Text);
            komut.Parameters.AddWithValue("@p3", txedModel.Text);
            komut.Parameters.AddWithValue("@p4", mtbxYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nmudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((txedAlisFiyat.Text)));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((txedSatisFiyat.Text)));
            komut.Parameters.AddWithValue("@p8", rtbxDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1",
                bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txedID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txedID.Text = dr["ID"].ToString();
            txedAd.Text = dr["URUNAD"].ToString();
            txedMarka.Text = dr["MARKA"].ToString();
            txedModel.Text = dr["Model"].ToString();
            mtbxYil.Text = dr["YIL"].ToString();
            nmudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            txedAlisFiyat.Text = dr["ALISFIYAT"].ToString();
            txedSatisFiyat.Text = dr["SATISFIYAT"].ToString();
            rtbxDetay.Text = dr["DETAY"].ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD = @p1, MARKA = @p2,MODEL = @p3,YIL=@p4,ADET = @p5,ALISFIYAT = @p6,SATISFIYAT = @p7,DETAY = @p8 where ID = @p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedAd.Text);
            komut.Parameters.AddWithValue("@p2", txedMarka.Text);
            komut.Parameters.AddWithValue("@p3", txedModel.Text);
            komut.Parameters.AddWithValue("@p4", mtbxYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nmudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((txedAlisFiyat.Text)));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((txedSatisFiyat.Text)));
            komut.Parameters.AddWithValue("@p8", rtbxDetay.Text);
            komut.Parameters.AddWithValue("@p9", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
