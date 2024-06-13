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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FATURABILGI",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Temizle()
        {
            txedID.Text = "";
            txedSeriNo.Text = "";
            txedSiraNo.Text = "";
            mksTarih.Text = "";
            mskSaat.Text = "";
            txedVergidai.Text = "";
            txedAlici.Text = "";
            txedTeslimEden.Text = "";
            txedTeslimAlan.Text = "";
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(txedFaturaID.Text =="")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txedSeriNo.Text);
                komut.Parameters.AddWithValue("@p2", txedSiraNo.Text);
                komut.Parameters.AddWithValue("@p3", mksTarih.Text);
                komut.Parameters.AddWithValue("@p4", mskSaat.Text);
                komut.Parameters.AddWithValue("@p5", txedVergidai.Text);
                komut.Parameters.AddWithValue("@p6", txedAlici.Text);
                komut.Parameters.AddWithValue("@p7", txedTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", txedTeslimAlan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            if(txedFaturaID.Text !="")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txedFiyat.Text);
                miktar = Convert.ToDouble(txedMiktar.Text);
                tutar = miktar * fiyat;
                txedTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());

                komut2.Parameters.AddWithValue("@p1",txedUrunAdi.Text);
                komut2.Parameters.AddWithValue("@p2",txedMiktar.Text);
                komut2.Parameters.AddWithValue("@p3",txedFiyat.Text);
                komut2.Parameters.AddWithValue("@p4",txedTutar.Text);
                komut2.Parameters.AddWithValue("@p5",txedFaturaID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Faturaya Ait Ürün Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txedID.Text = dr["FATURABILGIID"].ToString();
                txedSeriNo.Text = dr["SERI"].ToString();
                txedSiraNo.Text = dr["SIRANO"].ToString();
                mksTarih.Text = dr["TARIH"].ToString();
                mskSaat.Text = dr["SAAT"].ToString();
                txedVergidai.Text = dr["VERGIDAIRE"].ToString();
                txedAlici.Text = dr["ALICI"].ToString();
                txedTeslimEden.Text = dr["TESLIMEDEN"].ToString();
                txedTeslimAlan.Text = dr["TESLIMALAN"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FATURABILGI where FATURABILGIID = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SERI = @p1,SIRANO = @p2, TARIH = @p3, SAAT =@p4, VERGIDAIRE = @p5, ALICI = @p6,TESLIMEDEN = @p7, TESLIMALAN = @p8 where FATURABILGIID = @p9",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedSeriNo.Text);
            komut.Parameters.AddWithValue("@p2", txedSiraNo.Text);
            komut.Parameters.AddWithValue("@p3", mksTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", txedVergidai.Text);
            komut.Parameters.AddWithValue("@p6", txedAlici.Text);
            komut.Parameters.AddWithValue("@p7", txedTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", txedTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay fr = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!= null)
            {
                fr.ID = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }
    }
}
