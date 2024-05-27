using DevExpress.Utils.Html;
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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select TBL_BANKALAR.ID,BANKAADI,TBL_BANKALAR.IL,TBL_BANKALAR.ILCE,SUBE,IBAN,HESAPNO,YETKILI,TBL_BANKALAR.TELEFON,\r\nTARIH,HESAPTURU,AD from TBL_BANKALAR inner join TBL_FIRMALAR on TBL_BANKALAR.FIRMAID = TBL_FIRMALAR.ID", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
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

        void FirmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBL_FIRMALAR",bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.NullText = "Lütfen Firma Seçiniz";
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        void temizle()
        {
            txedID.Text = "";
            txedBankaAdi.Text = "";
            cbxIl.Text = "";
            cbxIlce.Text = "";
            txedSube.Text = "";
            mtbxIban.Text = "";
            mtbxHesapNo.Text = "";
            txedYetkili.Text = "";
            mtbxTelefon.Text = "";
            mtbxTarih.Text = "";
            txedHesapTuru.Text = "";
            lookUpEdit1.Text = "";
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
            FirmaListesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR(BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", cbxIl.Text);
            komut.Parameters.AddWithValue("@p3", cbxIlce.Text);
            komut.Parameters.AddWithValue("@p4", txedSube.Text);
            komut.Parameters.AddWithValue("@p5", mtbxIban.Text);
            komut.Parameters.AddWithValue("@p6", mtbxHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", txedYetkili.Text);
            komut.Parameters.AddWithValue("@p8", mtbxTelefon.Text);
            komut.Parameters.AddWithValue("@p9", mtbxTarih.Text);
            komut.Parameters.AddWithValue("@p10", txedHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka bilgisi sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txedID.Text = dr["ID"].ToString();
                txedBankaAdi.Text = dr["BANKAADI"].ToString();
                cbxIl.Text = dr["IL"].ToString();
                cbxIlce.Text = dr["ILCE"].ToString();
                txedSube.Text = dr["SUBE"].ToString();
                mtbxIban.Text = dr["IBAN"].ToString();
                mtbxHesapNo.Text = dr["HESAPNO"].ToString();
                txedYetkili.Text = dr["YETKILI"].ToString();
                mtbxTelefon.Text = dr["TELEFON"].ToString();
                mtbxTarih.Text = dr["TARIH"].ToString();
                txedHesapTuru.Text = dr["HESAPTURU"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_BANKALAR where ID = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("Banka Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_BANKALAR set BANKAADI = @p1, IL = @p2, ILCE = @p3,SUBE = @p4," +
                "IBAN = @p5, HESAPNO = @p6, YETKILI = @p7, TELEFON = @p8,TARIH = @p9, HESAPTURU = @p10, FIRMAID = @p11 WHERE ID = @p12",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txedBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", cbxIl.Text);
            komut.Parameters.AddWithValue("@p3", cbxIlce.Text);
            komut.Parameters.AddWithValue("@p4", txedSube.Text);
            komut.Parameters.AddWithValue("@p5", mtbxIban.Text);
            komut.Parameters.AddWithValue("@p6", mtbxHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", txedYetkili.Text);
            komut.Parameters.AddWithValue("@p8", mtbxTelefon.Text);
            komut.Parameters.AddWithValue("@p9", mtbxTarih.Text);
            komut.Parameters.AddWithValue("@p10", txedHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12", txedID.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
