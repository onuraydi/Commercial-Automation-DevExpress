namespace frm_Urunler
{
    partial class frmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rtbxDetay = new System.Windows.Forms.RichTextBox();
            this.lbcDetay = new DevExpress.XtraEditors.LabelControl();
            this.txedSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.lbcSatisFiyat = new DevExpress.XtraEditors.LabelControl();
            this.txedAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.lbcAlisFiyat = new DevExpress.XtraEditors.LabelControl();
            this.lbcAdet = new DevExpress.XtraEditors.LabelControl();
            this.lbcYil = new DevExpress.XtraEditors.LabelControl();
            this.nmudAdet = new System.Windows.Forms.NumericUpDown();
            this.txedModel = new DevExpress.XtraEditors.TextEdit();
            this.lbcModel = new DevExpress.XtraEditors.LabelControl();
            this.txedMarka = new DevExpress.XtraEditors.TextEdit();
            this.lbcMarka = new DevExpress.XtraEditors.LabelControl();
            this.txedAd = new DevExpress.XtraEditors.TextEdit();
            this.lbcAd = new DevExpress.XtraEditors.LabelControl();
            this.mtbxYil = new System.Windows.Forms.MaskedTextBox();
            this.txedID = new DevExpress.XtraEditors.TextEdit();
            this.lblcID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txedSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(798, 540);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.rtbxDetay);
            this.groupControl1.Controls.Add(this.lbcDetay);
            this.groupControl1.Controls.Add(this.txedSatisFiyat);
            this.groupControl1.Controls.Add(this.lbcSatisFiyat);
            this.groupControl1.Controls.Add(this.txedAlisFiyat);
            this.groupControl1.Controls.Add(this.lbcAlisFiyat);
            this.groupControl1.Controls.Add(this.lbcAdet);
            this.groupControl1.Controls.Add(this.lbcYil);
            this.groupControl1.Controls.Add(this.nmudAdet);
            this.groupControl1.Controls.Add(this.txedModel);
            this.groupControl1.Controls.Add(this.lbcModel);
            this.groupControl1.Controls.Add(this.txedMarka);
            this.groupControl1.Controls.Add(this.lbcMarka);
            this.groupControl1.Controls.Add(this.txedAd);
            this.groupControl1.Controls.Add(this.lbcAd);
            this.groupControl1.Controls.Add(this.mtbxYil);
            this.groupControl1.Controls.Add(this.txedID);
            this.groupControl1.Controls.Add(this.lblcID);
            this.groupControl1.Location = new System.Drawing.Point(804, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(241, 540);
            this.groupControl1.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(104, 422);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(125, 45);
            this.BtnKaydet.TabIndex = 19;
            this.BtnKaydet.Text = "Kaydet";
            // 
            // rtbxDetay
            // 
            this.rtbxDetay.Location = new System.Drawing.Point(104, 320);
            this.rtbxDetay.Name = "rtbxDetay";
            this.rtbxDetay.Size = new System.Drawing.Size(125, 96);
            this.rtbxDetay.TabIndex = 18;
            this.rtbxDetay.Text = "";
            // 
            // lbcDetay
            // 
            this.lbcDetay.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcDetay.Appearance.Options.UseFont = true;
            this.lbcDetay.Location = new System.Drawing.Point(5, 318);
            this.lbcDetay.Name = "lbcDetay";
            this.lbcDetay.Size = new System.Drawing.Size(51, 22);
            this.lbcDetay.TabIndex = 17;
            this.lbcDetay.Text = "Detay:";
            // 
            // txedSatisFiyat
            // 
            this.txedSatisFiyat.Location = new System.Drawing.Point(104, 281);
            this.txedSatisFiyat.Name = "txedSatisFiyat";
            this.txedSatisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedSatisFiyat.Properties.Appearance.Options.UseFont = true;
            this.txedSatisFiyat.Size = new System.Drawing.Size(125, 32);
            this.txedSatisFiyat.TabIndex = 16;
            // 
            // lbcSatisFiyat
            // 
            this.lbcSatisFiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcSatisFiyat.Appearance.Options.UseFont = true;
            this.lbcSatisFiyat.Location = new System.Drawing.Point(5, 284);
            this.lbcSatisFiyat.Name = "lbcSatisFiyat";
            this.lbcSatisFiyat.Size = new System.Drawing.Size(90, 22);
            this.lbcSatisFiyat.TabIndex = 15;
            this.lbcSatisFiyat.Text = "Satış Fiyatı:";
            // 
            // txedAlisFiyat
            // 
            this.txedAlisFiyat.Location = new System.Drawing.Point(104, 247);
            this.txedAlisFiyat.Name = "txedAlisFiyat";
            this.txedAlisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedAlisFiyat.Properties.Appearance.Options.UseFont = true;
            this.txedAlisFiyat.Size = new System.Drawing.Size(125, 32);
            this.txedAlisFiyat.TabIndex = 14;
            // 
            // lbcAlisFiyat
            // 
            this.lbcAlisFiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcAlisFiyat.Appearance.Options.UseFont = true;
            this.lbcAlisFiyat.Location = new System.Drawing.Point(5, 250);
            this.lbcAlisFiyat.Name = "lbcAlisFiyat";
            this.lbcAlisFiyat.Size = new System.Drawing.Size(80, 22);
            this.lbcAlisFiyat.TabIndex = 13;
            this.lbcAlisFiyat.Text = "Alış Fiyatı:";
            // 
            // lbcAdet
            // 
            this.lbcAdet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcAdet.Appearance.Options.UseFont = true;
            this.lbcAdet.Location = new System.Drawing.Point(5, 215);
            this.lbcAdet.Name = "lbcAdet";
            this.lbcAdet.Size = new System.Drawing.Size(42, 22);
            this.lbcAdet.TabIndex = 12;
            this.lbcAdet.Text = "Adet:";
            // 
            // lbcYil
            // 
            this.lbcYil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcYil.Appearance.Options.UseFont = true;
            this.lbcYil.Location = new System.Drawing.Point(5, 180);
            this.lbcYil.Name = "lbcYil";
            this.lbcYil.Size = new System.Drawing.Size(24, 22);
            this.lbcYil.TabIndex = 10;
            this.lbcYil.Text = "Yıl:";
            // 
            // nmudAdet
            // 
            this.nmudAdet.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmudAdet.Location = new System.Drawing.Point(104, 212);
            this.nmudAdet.Name = "nmudAdet";
            this.nmudAdet.Size = new System.Drawing.Size(125, 29);
            this.nmudAdet.TabIndex = 9;
            // 
            // txedModel
            // 
            this.txedModel.Location = new System.Drawing.Point(104, 143);
            this.txedModel.Name = "txedModel";
            this.txedModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedModel.Properties.Appearance.Options.UseFont = true;
            this.txedModel.Size = new System.Drawing.Size(125, 32);
            this.txedModel.TabIndex = 8;
            // 
            // lbcModel
            // 
            this.lbcModel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcModel.Appearance.Options.UseFont = true;
            this.lbcModel.Location = new System.Drawing.Point(5, 146);
            this.lbcModel.Name = "lbcModel";
            this.lbcModel.Size = new System.Drawing.Size(53, 22);
            this.lbcModel.TabIndex = 7;
            this.lbcModel.Text = "Model:";
            // 
            // txedMarka
            // 
            this.txedMarka.Location = new System.Drawing.Point(104, 109);
            this.txedMarka.Name = "txedMarka";
            this.txedMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedMarka.Properties.Appearance.Options.UseFont = true;
            this.txedMarka.Size = new System.Drawing.Size(125, 32);
            this.txedMarka.TabIndex = 6;
            // 
            // lbcMarka
            // 
            this.lbcMarka.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcMarka.Appearance.Options.UseFont = true;
            this.lbcMarka.Location = new System.Drawing.Point(5, 112);
            this.lbcMarka.Name = "lbcMarka";
            this.lbcMarka.Size = new System.Drawing.Size(53, 22);
            this.lbcMarka.TabIndex = 5;
            this.lbcMarka.Text = "Marka:";
            // 
            // txedAd
            // 
            this.txedAd.Location = new System.Drawing.Point(104, 75);
            this.txedAd.Name = "txedAd";
            this.txedAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedAd.Properties.Appearance.Options.UseFont = true;
            this.txedAd.Size = new System.Drawing.Size(125, 32);
            this.txedAd.TabIndex = 4;
            // 
            // lbcAd
            // 
            this.lbcAd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcAd.Appearance.Options.UseFont = true;
            this.lbcAd.Location = new System.Drawing.Point(5, 78);
            this.lbcAd.Name = "lbcAd";
            this.lbcAd.Size = new System.Drawing.Size(27, 22);
            this.lbcAd.TabIndex = 3;
            this.lbcAd.Text = "Ad:";
            // 
            // mtbxYil
            // 
            this.mtbxYil.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxYil.Location = new System.Drawing.Point(104, 177);
            this.mtbxYil.Mask = "0000";
            this.mtbxYil.Name = "mtbxYil";
            this.mtbxYil.Size = new System.Drawing.Size(125, 29);
            this.mtbxYil.TabIndex = 2;
            // 
            // txedID
            // 
            this.txedID.Location = new System.Drawing.Point(104, 41);
            this.txedID.Name = "txedID";
            this.txedID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedID.Properties.Appearance.Options.UseFont = true;
            this.txedID.Size = new System.Drawing.Size(125, 32);
            this.txedID.TabIndex = 1;
            // 
            // lblcID
            // 
            this.lblcID.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcID.Appearance.Options.UseFont = true;
            this.lblcID.Location = new System.Drawing.Point(5, 44);
            this.lblcID.Name = "lblcID";
            this.lblcID.Size = new System.Drawing.Size(25, 22);
            this.lblcID.TabIndex = 0;
            this.lblcID.Text = "ID:";
            this.lblcID.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 538);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmUrunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txedSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblcID;
        private System.Windows.Forms.MaskedTextBox mtbxYil;
        private DevExpress.XtraEditors.TextEdit txedID;
        private DevExpress.XtraEditors.TextEdit txedModel;
        private DevExpress.XtraEditors.LabelControl lbcModel;
        private DevExpress.XtraEditors.TextEdit txedMarka;
        private DevExpress.XtraEditors.LabelControl lbcMarka;
        private DevExpress.XtraEditors.TextEdit txedAd;
        private DevExpress.XtraEditors.LabelControl lbcAd;
        private DevExpress.XtraEditors.LabelControl lbcYil;
        private System.Windows.Forms.NumericUpDown nmudAdet;
        private DevExpress.XtraEditors.LabelControl lbcAdet;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox rtbxDetay;
        private DevExpress.XtraEditors.LabelControl lbcDetay;
        private DevExpress.XtraEditors.TextEdit txedSatisFiyat;
        private DevExpress.XtraEditors.LabelControl lbcSatisFiyat;
        private DevExpress.XtraEditors.TextEdit txedAlisFiyat;
        private DevExpress.XtraEditors.LabelControl lbcAlisFiyat;
    }
}

