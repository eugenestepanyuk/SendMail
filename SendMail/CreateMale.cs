using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Limilabs.Client.IMAP;
using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.Headers;

namespace SendMail
{
    public partial class CreateMale : Form
    {
        string[] pathFileName;
        string[] attachFileName;
        bool attachBtnFlag = false;

        public CreateMale()
        {
            InitializeComponent();
        }

        public void SendMessage()
        {
            try
            {
                XElement element = XElement.Load("MailSettings.xml");

                MailBuilder builder = new MailBuilder();
                //builder.Subject = String.Format("{0} - {1}", themeTxb.Text, SendMail.MailSettings.SenderName);
                builder.Subject = themeTxb.Text + " - " + element.Element("GeneralInformation").Element("senderName").Value;
                //builder.Subject = themeTxb.Text + " - " + SendMail.MailSettings.SenderName;
                builder.From.Add(new MailBox(element.Element("GeneralInformation").Element("email").Value, element.Element("GeneralInformation").Element("email").Value));
                //builder.From.Add(new MailBox(SendMail.MailSettings.Email));
                builder.To.Add(new MailBox(whomTxb.Text));
                builder.Text = contentTxb.Text;
                if (attachBtnFlag == true)
                    foreach (var i in pathFileName)
                        builder.AddAttachment(i);

                IMail email = builder.Create();

                using (Smtp smtp = new Smtp())
                {
                    smtp.ConnectSSL(element.Element("SendingMail").Element("sendingMail").Value);
                    //smtp.ConnectSSL(SendMail.MailSettings.SendingMail);
                    smtp.Configuration.EnableChunking = true;
                    smtp.UseBestLogin(element.Element("SendingMail").Element("sendingLogin").Value, element.Element("SendingMail").Element("sendingPassword").Value);
                    //smtp.UseBestLogin(SendMail.MailSettings.SendingLogin, SendMail.MailSettings.SendingPassword);
                    smtp.SendMessage(email);
                    MessageBox.Show("Електронний лист успішно надіслано!");
                }

                using (Imap imap = new Imap())
                {
                    imap.ConnectSSL(element.Element("ReceivingMail").Element("receivingMail").Value);
                    //imap.ConnectSSL(SendMail.MailSettings.ReceivingMail);
                    imap.UseBestLogin(element.Element("ReceivingMail").Element("receivingLogin").Value, element.Element("ReceivingMail").Element("receivingPassword").Value);
                    //imap.UseBestLogin(SendMail.MailSettings.ReceivingLogin, SendMail.MailSettings.ReceivingPassword);

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

        public void AttachFiles()
        {
            attachBtnFlag = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFileName = fileDialog.FileNames;
                attachFileName = fileDialog.SafeFileNames;
            }

            attachFilesGrid.Columns.AddRange(new DataGridViewColumn[] { new DataGridViewTextBoxColumn() { Width = 260 }, new DataGridViewButtonColumn() { Width = 30 } });
            foreach (var i in attachFileName)
                attachFilesGrid.Rows.Add(i, "x");
            //int rowNumber = attachFilesGrid.Rows.Add();
            //attachFilesGrid.Rows[rowNumber].Cells[0].Value = attachFileName;
            //attachFilesGrid.Rows[rowNumber].Cells[1].Value = "Видалити";
        }

        private void sendMailBtn_Click(object sender, EventArgs e)
        {
            if (whomTxb.Text != String.Empty && themeTxb.Text != String.Empty)
                SendMessage();
            else
                MessageBox.Show("Заповніть поля \"Кому\" і \"Тема\"!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void attachFilesBtn_Click(object sender, EventArgs e)
        {
            AttachFiles();
        }

        private void attachFilesGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
                attachFilesGrid.Rows.RemoveAt(e.RowIndex);
        }
    }
}
