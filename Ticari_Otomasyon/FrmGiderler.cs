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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            temizle();
        }

        void temizle()
        {
            txedID.Text = "";
            cbxAy.Text = "";
            txedyil.Text = "";
            txedElektrik.Text = "";
            txedSu.Text = "";
            txedDogalGaz.Text = "";
            txedInternet.Text = "";
            txedMaaslar.Text = "";
            txedEkstra.Text = "";
            rtbxNotlar.Text = "";
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cbxAy.Text);
            komut.Parameters.AddWithValue("@p2", txedyil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txedElektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txedSu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txedDogalGaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txedInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txedMaaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txedEkstra.Text));
            komut.Parameters.AddWithValue("@p9", rtbxNotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Tabloya eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txedID.Text = dr["GIDERID"].ToString();
                cbxAy.Text = dr["AY"].ToString();
                txedyil.Text = dr["YIL"].ToString();
                txedElektrik.Text = dr["ELEKTRIK"].ToString();
                txedSu.Text = dr["SU"].ToString();
                txedDogalGaz.Text = dr["DOGALGAZ"].ToString();
                txedInternet.Text = dr["INTERNET"].ToString();
                txedMaaslar.Text = dr["MAASLAR"].ToString();
                txedEkstra.Text = dr["EKSTRA"].ToString();
                rtbxNotlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_GIDERLER where GIDERID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Tablodan Silindi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_GIDERLER set AY = @p1, YIL =@p2, ELEKTRIK = @p3," +
                "SU = @p4, DOGALGAZ = @P5, INTERNET = @P6, MAASLAR = @P7, EKSTRA = @p8, NOTLAR = @p9 where GIDERID = @p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cbxAy.Text);
            komut.Parameters.AddWithValue("@p2", txedyil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txedElektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txedSu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txedDogalGaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txedInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txedMaaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txedEkstra.Text));
            komut.Parameters.AddWithValue("@p9", rtbxNotlar.Text);
            komut.Parameters.AddWithValue("@p10", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgisi Güncellendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
