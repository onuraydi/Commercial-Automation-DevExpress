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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void lbcAdres_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mtbxTarih.Text);
            komut.Parameters.AddWithValue("@p2",mtbxSaat.Text);
            komut.Parameters.AddWithValue("@p3",txedBaslik.Text);
            komut.Parameters.AddWithValue("@p4",rtbxNotDetay.Text);
            komut.Parameters.AddWithValue("@p5",txedOlusturan.Text);
            komut.Parameters.AddWithValue("@p6",txedHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Not sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txedID.Text = dr["ID"].ToString();
                txedBaslik.Text = dr["BASLIK"].ToString();
                rtbxNotDetay.Text = dr["DETAY"].ToString();
                txedOlusturan.Text = dr["OLUSTURAN"].ToString();
                txedHitap.Text = dr["HITAP"].ToString();
                mtbxTarih.Text = dr["TARIH"].ToString();
                mtbxSaat.Text = dr["SAAT"].ToString();
            }
        }

        void Temizle()
        {
            txedID.Text = "";
            txedBaslik.Text = "";
            rtbxNotDetay.Text = "";
            txedOlusturan.Text = "";
            txedHitap.Text =  "";
            mtbxTarih.Text = "";
            mtbxSaat.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_NOTLAR where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Not sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_NOTLAR set TARIH = @p1, SAAT = @p2, BASLIK = @p3, DETAY = @p4, OLUSTURAN = @p5,HITAP = @p6 where ID = @p7",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtbxTarih.Text);
            komut.Parameters.AddWithValue("@p2", mtbxSaat.Text);
            komut.Parameters.AddWithValue("@p3", txedBaslik.Text);
            komut.Parameters.AddWithValue("@p4", rtbxNotDetay.Text);
            komut.Parameters.AddWithValue("@p5", txedOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", txedHitap.Text);
            komut.Parameters.AddWithValue("@p7", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr!= null)
            {
                fr.metin = dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
}
