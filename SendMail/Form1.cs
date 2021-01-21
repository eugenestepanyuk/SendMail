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

        public void ShowSettingsMale ()
        {
            SettingsMale settingsMale = new SettingsMale();
            settingsMale.ShowDialog();
        }
        public void ShowCreateMale()
        {
            CreateMale createMale = new CreateMale();
            createMale.ShowDialog();
        }
        public void ShowGetMale()
        {
            GetMale getMale = new GetMale();
            getMale.ShowDialog();
        }

        private void settingsMaleBtn_Click(object sender, EventArgs e)
        {
            ShowSettingsMale();
        }

        private void createMaleBtn_Click(object sender, EventArgs e)
        {
            ShowCreateMale();
        }

        private void getMaleBtn_Click(object sender, EventArgs e)
        {
            GetMale getMale = new GetMale();
            getMale.ShowDialog();
        }
    }
}
