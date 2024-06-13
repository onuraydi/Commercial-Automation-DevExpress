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
    public partial class FrmFaturaUrunDetay : Form
    {
        public FrmFaturaUrunDetay()
        {
            InitializeComponent();
        }
        public string ID;
        sqlbaglantisi bgl = new sqlbaglantisi();

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURADETAY where FATURAID ='"+ID+"'",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunuGuncelleme fr2 = new FrmFaturaUrunuGuncelleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!= null)
            {
                fr2.urunID = dr["FATURAURUNID"].ToString();
            }
            fr2.Show();
            //this.Hide();
        }
    }
}
