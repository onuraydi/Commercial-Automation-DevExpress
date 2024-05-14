using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            txedMail.Text = mail;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new NetworkCredential("yazilimdeneme1934@gmail.com","Onur1934");  //gönderenin mail adresi ve şifresi
            istemci.Port = 587; //tr'de böyle
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            istemci.UseDefaultCredentials = true;
            mesaj.From = new MailAddress("yazilimdeneme1934@gmail.com","Deneme");// kimden gönderiliği
            mesaj.To.Add(txedMail.Text);
            mesaj.Subject = txedKonu.Text;
            mesaj.IsBodyHtml = true;
            
            mesaj.Body = richTextBox1.Text;
            istemci.Send(mesaj);

        }
    }
}
