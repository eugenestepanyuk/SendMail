using System;
using System.Windows.Forms;

namespace SendMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void settingsMaleBtn_Click(object sender, EventArgs e)
        {
            MailSettings.ShowSettingsMale();
        }

        private void createMaleBtn_Click(object sender, EventArgs e)
        {
            MailSettings.ShowCreateMale();
        }

        private void getMaleBtn_Click(object sender, EventArgs e)
        {
            MailSettings.ShowGetMale();
        }
    }
}
