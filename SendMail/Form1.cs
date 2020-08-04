using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
//using System.Net;
//using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Limilabs.Client.IMAP;
using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.Headers;

namespace SendMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        //public void SendMessage()
        //{
        //    try
        //    {
        //        MailAddress fromMailAddress = new MailAddress("sup@kai.ua");
        //        MailAddress toAddress = new MailAddress("sup@kai.ua");

        //        using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
        //        using (SmtpClient smtpClient = new SmtpClient())
        //        {
        //            mailMessage.Subject = "Test Email";
        //            mailMessage.Body = "Helllllooo!!!";

        //            smtpClient.Host = "mail.adm.tools";
        //            smtpClient.Port = 25;
        //            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        //            smtpClient.EnableSsl = true;
        //            smtpClient.UseDefaultCredentials = false;
        //            smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Kai_2020");

        //            smtpClient.Send(mailMessage);
        //            MessageBox.Show("Email sent successfully!");
        //        }

        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void SendMessage()
        {
            try
            {
                MailBuilder builder = new MailBuilder();
                builder.Subject = "Test subject";
                builder.From.Add(new MailBox("sup@kai.ua"));
                builder.To.Add(new MailBox("sup@kai.ua"));
                builder.Text = "This is plain text email";
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                    builder.AddAttachment(fileDialog.FileName);
                IMail email = builder.Create();

                using (Smtp smtp = new Smtp())
                {
                    smtp.ConnectSSL("mail.adm.tools", 465);
                    smtp.Configuration.EnableChunking = true;
                    smtp.UseBestLogin("sup@kai.ua", "Kai_2020");
                    smtp.SendMessage(email);
                    MessageBox.Show("Email sent successfully!");
                }

                using (Imap imap = new Imap())
                {
                    imap.Connect("mail.adm.tools");
                    imap.UseBestLogin("sup@kai.ua", "Kai_2020");

                    CommonFolders folders = new CommonFolders(imap.GetFolders());
                    imap.UploadMessage(folders.Sent, email);

                    imap.Close();
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
