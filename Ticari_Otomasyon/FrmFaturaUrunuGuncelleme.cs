using DevExpress.XtraBars;
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
    public partial class FrmFaturaUrunuGuncelleme : Form
    {
        public FrmFaturaUrunuGuncelleme()
        {
            InitializeComponent();
        }
        public string urunID;
        private void FrmFaturaUrunuGuncelleme_Load(object sender, EventArgs e)
        {
            txedFaturaDetayID.Text = urunID;

            SqlCommand komut = new SqlCommand("Select * From TBL_FATURADETAY where FATURAURUNID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunID);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txedUrunAdi.Text = dr[1].ToString();
                txedMiktar.Text = dr[2].ToString();
                txedFiyat.Text = dr[3].ToString();
                txedTutar.Text = dr[4].ToString();

                bgl.baglanti().Close();
            }
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURADETAY set URUNAD = @p1, MIKTAR = @p2, FIYAT = @p3, TUTAR = @p4 where FATURAURUNID = @p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedUrunAdi.Text);
            komut.Parameters.AddWithValue("@p2", txedMiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txedFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txedTutar.Text));
            komut.Parameters.AddWithValue("@p5", txedFaturaDetayID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedFaturaDetayID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün bilgisi silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
