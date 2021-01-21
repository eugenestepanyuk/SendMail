using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Limilabs.Client.IMAP;
using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.Headers;

namespace SendMail
{
    public partial class SettingsMale : Form
    {
        public SettingsMale()
        {
            InitializeComponent();
        }

        private void SettingsMale_Load(object sender, EventArgs e)
        {
            LoadMailSettings();
            SendMail.MailSettings.Email = emailTxb.Text;
            SendMail.MailSettings.SenderName = senderNameCmb.Text;
            SendMail.MailSettings.SendingMail = sendingMailTxb.Text;
            SendMail.MailSettings.SendingLogin = sendingLoginCmb.Text;
            SendMail.MailSettings.SendingPassword = sendingPasswordTxb.Text;
            SendMail.MailSettings.ReceivingMail = receivingMailTxb.Text;
            SendMail.MailSettings.ReceivingLogin = receivingLoginCmb.Text;
            SendMail.MailSettings.ReceivingPassword = receivingPasswordTxb.Text;
        }

        //public void SendMessage()
        //{
        //    try
        //    {
        //        MailAddress fromMailAddress = new MailAddress("kdocument.kai@ukr.net");
        //        MailAddress toAddress = new MailAddress("kdocument.kai@ukr.net");

        //        using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
        //        using (SmtpClient smtpClient = new SmtpClient("smtp.ukr.net", 465))
        //        {
        //            mailMessage.Subject = "Test Email";
        //            mailMessage.Body = "Helllllooo!!!";

        //            smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "kdocument_2021");
        //            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        //            smtpClient.EnableSsl = true;
        //            smtpClient.UseDefaultCredentials = false;

        //            smtpClient.Send(mailMessage);
        //            MessageBox.Show("Email sent successfully!");
        //        }
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void TestSendMessage()
        {
            try
            {
                MailBuilder builder = new MailBuilder();
                builder.Subject = String.Format("Тестовий лист - {0}", senderNameCmb.Text);
                builder.From.Add(new MailBox(emailTxb.Text, emailTxb.Text));
                builder.To.Add(new MailBox(emailTxb.Text));
                builder.Text = "Це електронний лист із простим текстом";

                IMail email = builder.Create();

                using (Smtp smtp = new Smtp())
                {
                    smtp.ConnectSSL(sendingMailTxb.Text);
                    smtp.Configuration.EnableChunking = true;
                    smtp.UseBestLogin(sendingLoginCmb.Text, sendingPasswordTxb.Text);
                    smtp.SendMessage(email);
                    MessageBox.Show("Електронний лист успішно надіслано!");
                }

                using (Imap imap = new Imap())
                {
                    imap.ConnectSSL(receivingMailTxb.Text);
                    imap.UseBestLogin(receivingLoginCmb.Text, receivingPasswordTxb.Text);

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

        private string PrintMailboxes(IEnumerable<MailAddress> addresses)
        {
            List<MailBox> mailboxes = new List<MailBox>();
            foreach (MailAddress address in addresses)
            {
                mailboxes.AddRange(address.GetMailboxes());
            }
            return string.Join(", ", mailboxes.ConvertAll(
                x => string.Format("'{0}' <{1}>", x.Name, x.Address)).ToArray());
        }


        private void SaveMailSettings()
        {
            try
            {
                XDocument xDoc = new XDocument();
                XElement xroot = new XElement("settings");

                //Создаем первый элемент General Information
                XElement generalInformation = new XElement("GeneralInformation");
                XElement email = new XElement("email", emailTxb.Text);
                XElement senderName = new XElement("senderName", senderNameCmb.Text);
                XElement organization = new XElement("organization", organizationTxb.Text);
                XElement storageLocation = new XElement("storageLocation", storageLocationTxb.Text);
                generalInformation.Add(email);
                generalInformation.Add(senderName);
                generalInformation.Add(organization);
                generalInformation.Add(storageLocation);

                //Создаем второй элемент Receiving Mail IMAP
                XElement imap = new XElement("ReceivingMail");
                XElement receivingMail = new XElement("receivingMail", receivingMailTxb.Text);
                XElement receivingPort = new XElement("receivingPort", receivingPortNum.Text);
                XElement receivingConnProtection = new XElement("receivingConnProtection", receivingConnProtectionCmb.Text);
                XElement receivingLogin = new XElement("receivingLogin", receivingLoginCmb.Text);
                XElement receivingPassword = new XElement("receivingPassword", receivingPasswordTxb.Text);
                imap.Add(receivingMail);
                imap.Add(receivingPort);
                imap.Add(receivingConnProtection);
                imap.Add(receivingLogin);
                imap.Add(receivingPassword);

                //Создаем третий элемент Sending Mail SMTP
                XElement smtp = new XElement("SendingMail");
                XElement sendingMail = new XElement("sendingMail", sendingMailTxb.Text);
                XElement maxNumRecipients = new XElement("maxNumRecipients", maxNumRecipientsNum.Text);
                XElement sendingPort = new XElement("sendingPort", sendingPortNum.Text);
                XElement sendingConnProtection = new XElement("sendingConnProtection", sendingConnProtectionCmb.Text);
                XElement sendingLogin = new XElement("sendingLogin", sendingLoginCmb.Text);
                XElement sendingPassword = new XElement("sendingPassword", sendingPasswordTxb.Text);
                smtp.Add(sendingMail);
                smtp.Add(maxNumRecipients);
                smtp.Add(sendingPort);
                smtp.Add(sendingConnProtection);
                smtp.Add(sendingLogin);
                smtp.Add(sendingPassword);

                xroot.Add(generalInformation);
                xroot.Add(imap);
                xroot.Add(smtp);
                xDoc.Add(xroot);

                xDoc.Save("MailSettings.xml");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadMailSettings()
        {
            try
            {
                XElement element = XElement.Load("MailSettings.xml");
                emailTxb.Text = element.Element("GeneralInformation").Element("email").Value;
                senderNameCmb.Items.Add(element.Element("GeneralInformation").Element("senderName").Value);
                senderNameCmb.SelectedIndex = 0;
                organizationTxb.Text = element.Element("GeneralInformation").Element("organization").Value;
                storageLocationTxb.Text = element.Element("GeneralInformation").Element("storageLocation").Value;

                receivingMailTxb.Text = element.Element("ReceivingMail").Element("receivingMail").Value;
                receivingPortNum.Text = element.Element("ReceivingMail").Element("receivingPort").Value;
                receivingConnProtectionCmb.Items.Add(element.Element("ReceivingMail").Element("receivingConnProtection").Value);
                receivingLoginCmb.Items.Add(element.Element("ReceivingMail").Element("receivingLogin").Value);
                receivingPasswordTxb.Text = element.Element("ReceivingMail").Element("receivingPassword").Value;
                receivingConnProtectionCmb.SelectedIndex = receivingLoginCmb.SelectedIndex = 0;

                sendingMailTxb.Text = element.Element("SendingMail").Element("sendingMail").Value;
                maxNumRecipientsNum.Text = element.Element("SendingMail").Element("maxNumRecipients").Value;
                sendingPortNum.Text = element.Element("SendingMail").Element("sendingPort").Value;
                sendingConnProtectionCmb.Items.Add(element.Element("SendingMail").Element("sendingConnProtection").Value);
                sendingLoginCmb.Items.Add(element.Element("SendingMail").Element("sendingLogin").Value);
                sendingPasswordTxb.Text = element.Element("SendingMail").Element("sendingPassword").Value;
                sendingConnProtectionCmb.SelectedIndex = sendingLoginCmb.SelectedIndex = 0;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            receivingLoginCmb.Text = sendingLoginCmb.Text = emailTxb.Text;
        }

        private void trySettingBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Бажаєте відправити тестовий лист?", "Тест", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                TestSendMessage();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            SaveMailSettings();
            CreateMale createMale = new CreateMale();
            createMale.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void storageLocationBtn_Click(object sender, EventArgs e)
        {
            if (storageLocationFolderDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = storageLocationFolderDialog.SelectedPath;
                storageLocationTxb.Text = filepath;
            }
        }

        private void showReceivingPasswordChb_CheckedChanged(object sender, EventArgs e)
        {
            receivingPasswordTxb.UseSystemPasswordChar = showReceivingPasswordChb.Checked == true ? false : true;
        }

        private void showSendingPasswordChb_CheckedChanged(object sender, EventArgs e)
        {
            sendingPasswordTxb.UseSystemPasswordChar = showSendingPasswordChb.Checked == true ? false : true;
        }
    }
}
