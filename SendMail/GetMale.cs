using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Limilabs.Client.IMAP;
using Limilabs.Mail;

namespace SendMail
{

    public partial class GetMale : Form
    {
        IMail email = null;

        public GetMale()
        {
            InitializeComponent();
            GetMessages();
        }

        public void GetMessages()
        {
            //LastRun last = LoadPreviousRun();
            SendMail.LastRunMessage last = null;

            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.ukr.net");
                imap.UseBestLogin("kdocument.kai@ukr.net", "DKB2pSzrIcs25QL2");

                FolderStatus status = imap.SelectInbox();

                //List<long> uids = imap.GetAll();
                List<long> uids;
                if (last == null || last.UIDValidity != status.UIDValidity)
                {
                    uids = imap.GetAll();
                }
                else
                {
                    uids = imap.Search().Where(Expression.UID(Range.From(last.LargestUID)));
                    uids.Remove(last.LargestUID);
                }
                maleGrid.Columns.AddRange(new DataGridViewColumn[] {
                        new DataGridViewTextBoxColumn() { Width = 100 },
                        new DataGridViewTextBoxColumn() { Width = 300 },
                        new DataGridViewTextBoxColumn() { Width = 380 },
                    });
                foreach (long uid in uids)
                {
                    var eml = imap.GetMessageByUID(uid);
                    email = new MailBuilder().CreateFromEml(eml);
                    //maleGrid.Rows.Add(email.Sender.Name, email.Subject.ToString(), email.Text);
                    int rowNumber = maleGrid.Rows.Add();
                    maleGrid.Rows[rowNumber].Cells[0].Value = email.Sender.Name;
                    maleGrid.Rows[rowNumber].Cells[1].Value = email.Subject.ToString();
                    maleGrid.Rows[rowNumber].Cells[2].Value = email.Text;
                    maleGrid.Rows[rowNumber].Cells[2].ToolTipText = email.Text;
                    //ToolTip t = new ToolTip();
                    //t.SetToolTip(maleGrid, email.Text);

                    //MessageBox.Show(email.Sender.Name);
                    //MessageBox.Show(email.Subject.ToString());
                    //MessageBox.Show(email.Text);

                    SendMail.LastRunMessage current = new SendMail.LastRunMessage
                    {
                        UIDValidity = status.UIDValidity,
                        LargestUID = uid
                    };
                    //SaveThisRun(current);
                }
                imap.Close();
            }
        }

        //private void SaveThisRun(LastRun run)
        //{
        //    //Your code that saves run data.
        //}

        //private LastRun LoadPreviousRun()
        //{
        //    // Your code that loads last run data (null on the first run).
        //}
    }
}
