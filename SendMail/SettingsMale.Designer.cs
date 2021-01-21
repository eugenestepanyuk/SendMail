namespace SendMail
{
    partial class SettingsMale
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralInformation = new System.Windows.Forms.TabPage();
            this.storageLocationBtn = new System.Windows.Forms.Button();
            this.storageLocationTxb = new System.Windows.Forms.TextBox();
            this.storageLocationLbl = new System.Windows.Forms.Label();
            this.organizationTxb = new System.Windows.Forms.TextBox();
            this.organizationLbl = new System.Windows.Forms.Label();
            this.senderNameCmb = new System.Windows.Forms.ComboBox();
            this.senderNameLbl = new System.Windows.Forms.Label();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.ReceivingMail = new System.Windows.Forms.TabPage();
            this.deleteEmailsChb = new System.Windows.Forms.CheckBox();
            this.showReceivingPasswordChb = new System.Windows.Forms.CheckBox();
            this.receivingPasswordTxb = new System.Windows.Forms.TextBox();
            this.receivingPasswordLbl = new System.Windows.Forms.Label();
            this.receivingLoginCmb = new System.Windows.Forms.ComboBox();
            this.receivingLoginLbl = new System.Windows.Forms.Label();
            this.receivingConnProtectionCmb = new System.Windows.Forms.ComboBox();
            this.receivingConnProtectionLbl = new System.Windows.Forms.Label();
            this.receivingPortNum = new System.Windows.Forms.NumericUpDown();
            this.receivingPortLbl = new System.Windows.Forms.Label();
            this.receivingMailTxb = new System.Windows.Forms.TextBox();
            this.receivingMailLbl = new System.Windows.Forms.Label();
            this.SendingMail = new System.Windows.Forms.TabPage();
            this.maxNumRecipientsNum = new System.Windows.Forms.NumericUpDown();
            this.maxNumRecipientsLbl = new System.Windows.Forms.Label();
            this.showSendingPasswordChb = new System.Windows.Forms.CheckBox();
            this.sendingPasswordTxb = new System.Windows.Forms.TextBox();
            this.sendingPasswordLbl = new System.Windows.Forms.Label();
            this.sendingLoginCmb = new System.Windows.Forms.ComboBox();
            this.sendingLoginLbl = new System.Windows.Forms.Label();
            this.sendingConnProtectionCmb = new System.Windows.Forms.ComboBox();
            this.sendingConnProtectionLbl = new System.Windows.Forms.Label();
            this.sendingPortNum = new System.Windows.Forms.NumericUpDown();
            this.sendingPortLbl = new System.Windows.Forms.Label();
            this.sendingMailTxb = new System.Windows.Forms.TextBox();
            this.sendingMailLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.trySettingBtn = new System.Windows.Forms.Button();
            this.fieldsRequiredLbl = new System.Windows.Forms.Label();
            this.storageLocationFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.GeneralInformation.SuspendLayout();
            this.ReceivingMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivingPortNum)).BeginInit();
            this.SendingMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumRecipientsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendingPortNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GeneralInformation);
            this.tabControl1.Controls.Add(this.ReceivingMail);
            this.tabControl1.Controls.Add(this.SendingMail);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 256);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // GeneralInformation
            // 
            this.GeneralInformation.Controls.Add(this.storageLocationBtn);
            this.GeneralInformation.Controls.Add(this.storageLocationTxb);
            this.GeneralInformation.Controls.Add(this.storageLocationLbl);
            this.GeneralInformation.Controls.Add(this.organizationTxb);
            this.GeneralInformation.Controls.Add(this.organizationLbl);
            this.GeneralInformation.Controls.Add(this.senderNameCmb);
            this.GeneralInformation.Controls.Add(this.senderNameLbl);
            this.GeneralInformation.Controls.Add(this.emailTxb);
            this.GeneralInformation.Controls.Add(this.emailLbl);
            this.GeneralInformation.Location = new System.Drawing.Point(4, 22);
            this.GeneralInformation.Name = "GeneralInformation";
            this.GeneralInformation.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralInformation.Size = new System.Drawing.Size(515, 230);
            this.GeneralInformation.TabIndex = 0;
            this.GeneralInformation.Text = "Загальні відомості";
            this.GeneralInformation.UseVisualStyleBackColor = true;
            // 
            // storageLocationBtn
            // 
            this.storageLocationBtn.BackgroundImage = global::SendMail.Properties.Resources.folder;
            this.storageLocationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.storageLocationBtn.Location = new System.Drawing.Point(317, 179);
            this.storageLocationBtn.Name = "storageLocationBtn";
            this.storageLocationBtn.Size = new System.Drawing.Size(35, 20);
            this.storageLocationBtn.TabIndex = 8;
            this.storageLocationBtn.UseVisualStyleBackColor = true;
            this.storageLocationBtn.Click += new System.EventHandler(this.storageLocationBtn_Click);
            // 
            // storageLocationTxb
            // 
            this.storageLocationTxb.Location = new System.Drawing.Point(10, 179);
            this.storageLocationTxb.Name = "storageLocationTxb";
            this.storageLocationTxb.Size = new System.Drawing.Size(301, 20);
            this.storageLocationTxb.TabIndex = 7;
            // 
            // storageLocationLbl
            // 
            this.storageLocationLbl.AutoSize = true;
            this.storageLocationLbl.Location = new System.Drawing.Point(7, 163);
            this.storageLocationLbl.Name = "storageLocationLbl";
            this.storageLocationLbl.Size = new System.Drawing.Size(234, 13);
            this.storageLocationLbl.TabIndex = 6;
            this.storageLocationLbl.Text = "Місце зберігання пошти (локальний каталог)";
            // 
            // organizationTxb
            // 
            this.organizationTxb.Location = new System.Drawing.Point(10, 130);
            this.organizationTxb.Name = "organizationTxb";
            this.organizationTxb.Size = new System.Drawing.Size(342, 20);
            this.organizationTxb.TabIndex = 5;
            // 
            // organizationLbl
            // 
            this.organizationLbl.AutoSize = true;
            this.organizationLbl.Location = new System.Drawing.Point(7, 114);
            this.organizationLbl.Name = "organizationLbl";
            this.organizationLbl.Size = new System.Drawing.Size(66, 13);
            this.organizationLbl.TabIndex = 4;
            this.organizationLbl.Text = "Організація";
            // 
            // senderNameCmb
            // 
            this.senderNameCmb.FormattingEnabled = true;
            this.senderNameCmb.Location = new System.Drawing.Point(10, 81);
            this.senderNameCmb.Name = "senderNameCmb";
            this.senderNameCmb.Size = new System.Drawing.Size(342, 21);
            this.senderNameCmb.TabIndex = 3;
            // 
            // senderNameLbl
            // 
            this.senderNameLbl.AutoSize = true;
            this.senderNameLbl.Location = new System.Drawing.Point(7, 65);
            this.senderNameLbl.Name = "senderNameLbl";
            this.senderNameLbl.Size = new System.Drawing.Size(250, 13);
            this.senderNameLbl.TabIndex = 2;
            this.senderNameLbl.Text = "Ім\'я відправника (пишеться у заголовках листа)";
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(10, 32);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(342, 20);
            this.emailTxb.TabIndex = 1;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLbl.Location = new System.Drawing.Point(7, 3);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(247, 26);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Ваша адреса поштової скриньки (email).\r\nНаприклад login@server.ua";
            // 
            // ReceivingMail
            // 
            this.ReceivingMail.Controls.Add(this.deleteEmailsChb);
            this.ReceivingMail.Controls.Add(this.showReceivingPasswordChb);
            this.ReceivingMail.Controls.Add(this.receivingPasswordTxb);
            this.ReceivingMail.Controls.Add(this.receivingPasswordLbl);
            this.ReceivingMail.Controls.Add(this.receivingLoginCmb);
            this.ReceivingMail.Controls.Add(this.receivingLoginLbl);
            this.ReceivingMail.Controls.Add(this.receivingConnProtectionCmb);
            this.ReceivingMail.Controls.Add(this.receivingConnProtectionLbl);
            this.ReceivingMail.Controls.Add(this.receivingPortNum);
            this.ReceivingMail.Controls.Add(this.receivingPortLbl);
            this.ReceivingMail.Controls.Add(this.receivingMailTxb);
            this.ReceivingMail.Controls.Add(this.receivingMailLbl);
            this.ReceivingMail.Location = new System.Drawing.Point(4, 22);
            this.ReceivingMail.Name = "ReceivingMail";
            this.ReceivingMail.Padding = new System.Windows.Forms.Padding(3);
            this.ReceivingMail.Size = new System.Drawing.Size(515, 230);
            this.ReceivingMail.TabIndex = 1;
            this.ReceivingMail.Text = "Прийом пошти (IMAP)";
            this.ReceivingMail.UseVisualStyleBackColor = true;
            // 
            // deleteEmailsChb
            // 
            this.deleteEmailsChb.AutoSize = true;
            this.deleteEmailsChb.Location = new System.Drawing.Point(10, 207);
            this.deleteEmailsChb.Name = "deleteEmailsChb";
            this.deleteEmailsChb.Size = new System.Drawing.Size(193, 17);
            this.deleteEmailsChb.TabIndex = 11;
            this.deleteEmailsChb.Text = "Видаляти листи після отримання";
            this.deleteEmailsChb.UseVisualStyleBackColor = true;
            // 
            // showReceivingPasswordChb
            // 
            this.showReceivingPasswordChb.AutoSize = true;
            this.showReceivingPasswordChb.Location = new System.Drawing.Point(229, 171);
            this.showReceivingPasswordChb.Name = "showReceivingPasswordChb";
            this.showReceivingPasswordChb.Size = new System.Drawing.Size(114, 17);
            this.showReceivingPasswordChb.TabIndex = 10;
            this.showReceivingPasswordChb.Text = "Показати пароль";
            this.showReceivingPasswordChb.UseVisualStyleBackColor = true;
            this.showReceivingPasswordChb.CheckedChanged += new System.EventHandler(this.showReceivingPasswordChb_CheckedChanged);
            // 
            // receivingPasswordTxb
            // 
            this.receivingPasswordTxb.Location = new System.Drawing.Point(10, 168);
            this.receivingPasswordTxb.Name = "receivingPasswordTxb";
            this.receivingPasswordTxb.Size = new System.Drawing.Size(201, 20);
            this.receivingPasswordTxb.TabIndex = 9;
            this.receivingPasswordTxb.UseSystemPasswordChar = true;
            // 
            // receivingPasswordLbl
            // 
            this.receivingPasswordLbl.AutoSize = true;
            this.receivingPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivingPasswordLbl.Location = new System.Drawing.Point(7, 152);
            this.receivingPasswordLbl.Name = "receivingPasswordLbl";
            this.receivingPasswordLbl.Size = new System.Drawing.Size(51, 13);
            this.receivingPasswordLbl.TabIndex = 8;
            this.receivingPasswordLbl.Text = "Пароль";
            // 
            // receivingLoginCmb
            // 
            this.receivingLoginCmb.FormattingEnabled = true;
            this.receivingLoginCmb.Location = new System.Drawing.Point(10, 117);
            this.receivingLoginCmb.Name = "receivingLoginCmb";
            this.receivingLoginCmb.Size = new System.Drawing.Size(344, 21);
            this.receivingLoginCmb.TabIndex = 7;
            // 
            // receivingLoginLbl
            // 
            this.receivingLoginLbl.AutoSize = true;
            this.receivingLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivingLoginLbl.Location = new System.Drawing.Point(7, 101);
            this.receivingLoginLbl.Name = "receivingLoginLbl";
            this.receivingLoginLbl.Size = new System.Drawing.Size(221, 13);
            this.receivingLoginLbl.TabIndex = 6;
            this.receivingLoginLbl.Text = "Користувач (логін) або адреса email";
            // 
            // receivingConnProtectionCmb
            // 
            this.receivingConnProtectionCmb.FormattingEnabled = true;
            this.receivingConnProtectionCmb.Location = new System.Drawing.Point(145, 68);
            this.receivingConnProtectionCmb.Name = "receivingConnProtectionCmb";
            this.receivingConnProtectionCmb.Size = new System.Drawing.Size(209, 21);
            this.receivingConnProtectionCmb.TabIndex = 5;
            // 
            // receivingConnProtectionLbl
            // 
            this.receivingConnProtectionLbl.AutoSize = true;
            this.receivingConnProtectionLbl.Location = new System.Drawing.Point(142, 52);
            this.receivingConnProtectionLbl.Name = "receivingConnProtectionLbl";
            this.receivingConnProtectionLbl.Size = new System.Drawing.Size(95, 13);
            this.receivingConnProtectionLbl.TabIndex = 4;
            this.receivingConnProtectionLbl.Text = "Захист з\'єднання";
            // 
            // receivingPortNum
            // 
            this.receivingPortNum.Location = new System.Drawing.Point(10, 68);
            this.receivingPortNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.receivingPortNum.Name = "receivingPortNum";
            this.receivingPortNum.Size = new System.Drawing.Size(56, 20);
            this.receivingPortNum.TabIndex = 3;
            // 
            // receivingPortLbl
            // 
            this.receivingPortLbl.AutoSize = true;
            this.receivingPortLbl.Location = new System.Drawing.Point(7, 52);
            this.receivingPortLbl.Name = "receivingPortLbl";
            this.receivingPortLbl.Size = new System.Drawing.Size(32, 13);
            this.receivingPortLbl.TabIndex = 2;
            this.receivingPortLbl.Text = "Порт";
            // 
            // receivingMailTxb
            // 
            this.receivingMailTxb.Location = new System.Drawing.Point(10, 19);
            this.receivingMailTxb.Name = "receivingMailTxb";
            this.receivingMailTxb.Size = new System.Drawing.Size(344, 20);
            this.receivingMailTxb.TabIndex = 1;
            // 
            // receivingMailLbl
            // 
            this.receivingMailLbl.AutoSize = true;
            this.receivingMailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receivingMailLbl.Location = new System.Drawing.Point(7, 3);
            this.receivingMailLbl.Name = "receivingMailLbl";
            this.receivingMailLbl.Size = new System.Drawing.Size(231, 13);
            this.receivingMailLbl.TabIndex = 0;
            this.receivingMailLbl.Text = "Адреса сервера прийому пошти IMAP";
            // 
            // SendingMail
            // 
            this.SendingMail.Controls.Add(this.maxNumRecipientsNum);
            this.SendingMail.Controls.Add(this.maxNumRecipientsLbl);
            this.SendingMail.Controls.Add(this.showSendingPasswordChb);
            this.SendingMail.Controls.Add(this.sendingPasswordTxb);
            this.SendingMail.Controls.Add(this.sendingPasswordLbl);
            this.SendingMail.Controls.Add(this.sendingLoginCmb);
            this.SendingMail.Controls.Add(this.sendingLoginLbl);
            this.SendingMail.Controls.Add(this.sendingConnProtectionCmb);
            this.SendingMail.Controls.Add(this.sendingConnProtectionLbl);
            this.SendingMail.Controls.Add(this.sendingPortNum);
            this.SendingMail.Controls.Add(this.sendingPortLbl);
            this.SendingMail.Controls.Add(this.sendingMailTxb);
            this.SendingMail.Controls.Add(this.sendingMailLbl);
            this.SendingMail.Location = new System.Drawing.Point(4, 22);
            this.SendingMail.Name = "SendingMail";
            this.SendingMail.Size = new System.Drawing.Size(515, 230);
            this.SendingMail.TabIndex = 2;
            this.SendingMail.Text = "Відправка пошти (SMTP)";
            this.SendingMail.UseVisualStyleBackColor = true;
            // 
            // maxNumRecipientsNum
            // 
            this.maxNumRecipientsNum.Location = new System.Drawing.Point(369, 25);
            this.maxNumRecipientsNum.Name = "maxNumRecipientsNum";
            this.maxNumRecipientsNum.Size = new System.Drawing.Size(60, 20);
            this.maxNumRecipientsNum.TabIndex = 23;
            // 
            // maxNumRecipientsLbl
            // 
            this.maxNumRecipientsLbl.AutoSize = true;
            this.maxNumRecipientsLbl.Location = new System.Drawing.Point(366, 9);
            this.maxNumRecipientsLbl.Name = "maxNumRecipientsLbl";
            this.maxNumRecipientsLbl.Size = new System.Drawing.Size(149, 13);
            this.maxNumRecipientsLbl.TabIndex = 22;
            this.maxNumRecipientsLbl.Text = "Макс. кількість отримувачів";
            // 
            // showSendingPasswordChb
            // 
            this.showSendingPasswordChb.AutoSize = true;
            this.showSendingPasswordChb.Location = new System.Drawing.Point(229, 177);
            this.showSendingPasswordChb.Name = "showSendingPasswordChb";
            this.showSendingPasswordChb.Size = new System.Drawing.Size(114, 17);
            this.showSendingPasswordChb.TabIndex = 21;
            this.showSendingPasswordChb.Text = "Показати пароль";
            this.showSendingPasswordChb.UseVisualStyleBackColor = true;
            this.showSendingPasswordChb.CheckedChanged += new System.EventHandler(this.showSendingPasswordChb_CheckedChanged);
            // 
            // sendingPasswordTxb
            // 
            this.sendingPasswordTxb.Location = new System.Drawing.Point(10, 174);
            this.sendingPasswordTxb.Name = "sendingPasswordTxb";
            this.sendingPasswordTxb.Size = new System.Drawing.Size(201, 20);
            this.sendingPasswordTxb.TabIndex = 20;
            this.sendingPasswordTxb.UseSystemPasswordChar = true;
            // 
            // sendingPasswordLbl
            // 
            this.sendingPasswordLbl.AutoSize = true;
            this.sendingPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendingPasswordLbl.Location = new System.Drawing.Point(7, 158);
            this.sendingPasswordLbl.Name = "sendingPasswordLbl";
            this.sendingPasswordLbl.Size = new System.Drawing.Size(51, 13);
            this.sendingPasswordLbl.TabIndex = 19;
            this.sendingPasswordLbl.Text = "Пароль";
            // 
            // sendingLoginCmb
            // 
            this.sendingLoginCmb.FormattingEnabled = true;
            this.sendingLoginCmb.Location = new System.Drawing.Point(10, 123);
            this.sendingLoginCmb.Name = "sendingLoginCmb";
            this.sendingLoginCmb.Size = new System.Drawing.Size(344, 21);
            this.sendingLoginCmb.TabIndex = 18;
            // 
            // sendingLoginLbl
            // 
            this.sendingLoginLbl.AutoSize = true;
            this.sendingLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendingLoginLbl.Location = new System.Drawing.Point(7, 107);
            this.sendingLoginLbl.Name = "sendingLoginLbl";
            this.sendingLoginLbl.Size = new System.Drawing.Size(221, 13);
            this.sendingLoginLbl.TabIndex = 17;
            this.sendingLoginLbl.Text = "Користувач (логін) або адреса email";
            // 
            // sendingConnProtectionCmb
            // 
            this.sendingConnProtectionCmb.FormattingEnabled = true;
            this.sendingConnProtectionCmb.Location = new System.Drawing.Point(145, 74);
            this.sendingConnProtectionCmb.Name = "sendingConnProtectionCmb";
            this.sendingConnProtectionCmb.Size = new System.Drawing.Size(209, 21);
            this.sendingConnProtectionCmb.TabIndex = 16;
            // 
            // sendingConnProtectionLbl
            // 
            this.sendingConnProtectionLbl.AutoSize = true;
            this.sendingConnProtectionLbl.Location = new System.Drawing.Point(142, 58);
            this.sendingConnProtectionLbl.Name = "sendingConnProtectionLbl";
            this.sendingConnProtectionLbl.Size = new System.Drawing.Size(95, 13);
            this.sendingConnProtectionLbl.TabIndex = 15;
            this.sendingConnProtectionLbl.Text = "Захист з\'єднання";
            // 
            // sendingPortNum
            // 
            this.sendingPortNum.Location = new System.Drawing.Point(10, 74);
            this.sendingPortNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sendingPortNum.Name = "sendingPortNum";
            this.sendingPortNum.Size = new System.Drawing.Size(56, 20);
            this.sendingPortNum.TabIndex = 14;
            // 
            // sendingPortLbl
            // 
            this.sendingPortLbl.AutoSize = true;
            this.sendingPortLbl.Location = new System.Drawing.Point(7, 58);
            this.sendingPortLbl.Name = "sendingPortLbl";
            this.sendingPortLbl.Size = new System.Drawing.Size(32, 13);
            this.sendingPortLbl.TabIndex = 13;
            this.sendingPortLbl.Text = "Порт";
            // 
            // sendingMailTxb
            // 
            this.sendingMailTxb.Location = new System.Drawing.Point(10, 25);
            this.sendingMailTxb.Name = "sendingMailTxb";
            this.sendingMailTxb.Size = new System.Drawing.Size(344, 20);
            this.sendingMailTxb.TabIndex = 12;
            // 
            // sendingMailLbl
            // 
            this.sendingMailLbl.AutoSize = true;
            this.sendingMailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendingMailLbl.Location = new System.Drawing.Point(7, 9);
            this.sendingMailLbl.Name = "sendingMailLbl";
            this.sendingMailLbl.Size = new System.Drawing.Size(244, 13);
            this.sendingMailLbl.TabIndex = 0;
            this.sendingMailLbl.Text = "Адреса сервера відправки пошти SMTP";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(432, 286);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Скасувати";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(351, 286);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // trySettingBtn
            // 
            this.trySettingBtn.Location = new System.Drawing.Point(12, 286);
            this.trySettingBtn.Name = "trySettingBtn";
            this.trySettingBtn.Size = new System.Drawing.Size(156, 23);
            this.trySettingBtn.TabIndex = 6;
            this.trySettingBtn.Text = "Спробувати налаштування";
            this.trySettingBtn.UseVisualStyleBackColor = true;
            this.trySettingBtn.Click += new System.EventHandler(this.trySettingBtn_Click);
            // 
            // fieldsRequiredLbl
            // 
            this.fieldsRequiredLbl.AutoSize = true;
            this.fieldsRequiredLbl.Location = new System.Drawing.Point(9, 259);
            this.fieldsRequiredLbl.Name = "fieldsRequiredLbl";
            this.fieldsRequiredLbl.Size = new System.Drawing.Size(249, 13);
            this.fieldsRequiredLbl.TabIndex = 5;
            this.fieldsRequiredLbl.Text = "Поля з жирними заголовками є обов\'язковими";
            // 
            // SettingsMale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 319);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.trySettingBtn);
            this.Controls.Add(this.fieldsRequiredLbl);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(538, 358);
            this.MinimumSize = new System.Drawing.Size(538, 358);
            this.Name = "SettingsMale";
            this.Text = "SettingsMale";
            this.Load += new System.EventHandler(this.SettingsMale_Load);
            this.tabControl1.ResumeLayout(false);
            this.GeneralInformation.ResumeLayout(false);
            this.GeneralInformation.PerformLayout();
            this.ReceivingMail.ResumeLayout(false);
            this.ReceivingMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivingPortNum)).EndInit();
            this.SendingMail.ResumeLayout(false);
            this.SendingMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumRecipientsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendingPortNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralInformation;
        private System.Windows.Forms.Button storageLocationBtn;
        private System.Windows.Forms.TextBox storageLocationTxb;
        private System.Windows.Forms.Label storageLocationLbl;
        private System.Windows.Forms.TextBox organizationTxb;
        private System.Windows.Forms.Label organizationLbl;
        private System.Windows.Forms.ComboBox senderNameCmb;
        private System.Windows.Forms.Label senderNameLbl;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TabPage ReceivingMail;
        private System.Windows.Forms.CheckBox deleteEmailsChb;
        private System.Windows.Forms.CheckBox showReceivingPasswordChb;
        private System.Windows.Forms.TextBox receivingPasswordTxb;
        private System.Windows.Forms.Label receivingPasswordLbl;
        private System.Windows.Forms.ComboBox receivingLoginCmb;
        private System.Windows.Forms.Label receivingLoginLbl;
        private System.Windows.Forms.ComboBox receivingConnProtectionCmb;
        private System.Windows.Forms.Label receivingConnProtectionLbl;
        private System.Windows.Forms.NumericUpDown receivingPortNum;
        private System.Windows.Forms.Label receivingPortLbl;
        private System.Windows.Forms.TextBox receivingMailTxb;
        private System.Windows.Forms.Label receivingMailLbl;
        private System.Windows.Forms.TabPage SendingMail;
        private System.Windows.Forms.NumericUpDown maxNumRecipientsNum;
        private System.Windows.Forms.Label maxNumRecipientsLbl;
        private System.Windows.Forms.CheckBox showSendingPasswordChb;
        private System.Windows.Forms.TextBox sendingPasswordTxb;
        private System.Windows.Forms.Label sendingPasswordLbl;
        private System.Windows.Forms.ComboBox sendingLoginCmb;
        private System.Windows.Forms.Label sendingLoginLbl;
        private System.Windows.Forms.ComboBox sendingConnProtectionCmb;
        private System.Windows.Forms.Label sendingConnProtectionLbl;
        private System.Windows.Forms.NumericUpDown sendingPortNum;
        private System.Windows.Forms.Label sendingPortLbl;
        private System.Windows.Forms.TextBox sendingMailTxb;
        private System.Windows.Forms.Label sendingMailLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button trySettingBtn;
        private System.Windows.Forms.Label fieldsRequiredLbl;
        private System.Windows.Forms.FolderBrowserDialog storageLocationFolderDialog;
    }
}