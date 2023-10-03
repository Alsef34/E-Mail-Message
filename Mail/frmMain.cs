using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient a = new SmtpClient();
            a.Credentials = new System.Net.NetworkCredential("alisefikaydin34@gmail.com", "Alisef28");
            a.Port = 587;
            a.Host = "smtp.gmail.com";
            a.EnableSsl = true;
            mesaj.To.Add(tbKime.Text);
            mesaj.From = new MailAddress("alisefikaydin34@gmail.com");
            mesaj.Subject = (tbKonu.Text);
            mesaj.Body = tbKutu.Text;
            a.Send(mesaj);
            MessageBox.Show("Mail gönderildi.");
        }
    }
}
