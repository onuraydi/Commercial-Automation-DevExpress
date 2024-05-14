namespace Ticari_Otomasyon
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.lblMail = new System.Windows.Forms.Label();
            this.txedMail = new DevExpress.XtraEditors.TextEdit();
            this.txedKonu = new DevExpress.XtraEditors.TextEdit();
            this.lblKonu = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txedMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedKonu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 27);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(129, 28);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail Adresi:";
            // 
            // txedMail
            // 
            this.txedMail.Location = new System.Drawing.Point(147, 24);
            this.txedMail.Name = "txedMail";
            this.txedMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedMail.Properties.Appearance.Options.UseFont = true;
            this.txedMail.Size = new System.Drawing.Size(297, 34);
            this.txedMail.TabIndex = 1;
            // 
            // txedKonu
            // 
            this.txedKonu.Location = new System.Drawing.Point(147, 79);
            this.txedKonu.Name = "txedKonu";
            this.txedKonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txedKonu.Properties.Appearance.Options.UseFont = true;
            this.txedKonu.Size = new System.Drawing.Size(297, 34);
            this.txedKonu.TabIndex = 3;
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Location = new System.Drawing.Point(12, 82);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(72, 28);
            this.lblKonu.TabIndex = 2;
            this.lblKonu.Text = "Konu:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(17, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(427, 407);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnGonder.Location = new System.Drawing.Point(147, 558);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(151, 41);
            this.btnGonder.TabIndex = 5;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 611);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txedKonu);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.txedMail);
            this.Controls.Add(this.lblMail);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAİL";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txedMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txedKonu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private DevExpress.XtraEditors.TextEdit txedMail;
        private DevExpress.XtraEditors.TextEdit txedKonu;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
    }
}