namespace SendMail
{
    partial class CreateMale
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
            this.whomLbl = new System.Windows.Forms.Label();
            this.whomTxb = new System.Windows.Forms.TextBox();
            this.themeLbl = new System.Windows.Forms.Label();
            this.themeTxb = new System.Windows.Forms.TextBox();
            this.contentTxb = new System.Windows.Forms.TextBox();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.attachFilesBtn = new System.Windows.Forms.Button();
            this.attachFilesGrid = new System.Windows.Forms.DataGridView();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.attachFilesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // whomLbl
            // 
            this.whomLbl.AutoSize = true;
            this.whomLbl.Location = new System.Drawing.Point(12, 9);
            this.whomLbl.Name = "whomLbl";
            this.whomLbl.Size = new System.Drawing.Size(33, 13);
            this.whomLbl.TabIndex = 0;
            this.whomLbl.Text = "Кому";
            // 
            // whomTxb
            // 
            this.whomTxb.Location = new System.Drawing.Point(51, 6);
            this.whomTxb.Name = "whomTxb";
            this.whomTxb.Size = new System.Drawing.Size(278, 20);
            this.whomTxb.TabIndex = 1;
            // 
            // themeLbl
            // 
            this.themeLbl.AutoSize = true;
            this.themeLbl.Location = new System.Drawing.Point(12, 35);
            this.themeLbl.Name = "themeLbl";
            this.themeLbl.Size = new System.Drawing.Size(34, 13);
            this.themeLbl.TabIndex = 2;
            this.themeLbl.Text = "Тема";
            // 
            // themeTxb
            // 
            this.themeTxb.Location = new System.Drawing.Point(51, 32);
            this.themeTxb.Name = "themeTxb";
            this.themeTxb.Size = new System.Drawing.Size(278, 20);
            this.themeTxb.TabIndex = 3;
            // 
            // contentTxb
            // 
            this.contentTxb.Location = new System.Drawing.Point(15, 58);
            this.contentTxb.Multiline = true;
            this.contentTxb.Name = "contentTxb";
            this.contentTxb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTxb.Size = new System.Drawing.Size(314, 165);
            this.contentTxb.TabIndex = 4;
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.Location = new System.Drawing.Point(12, 308);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(85, 28);
            this.sendMailBtn.TabIndex = 5;
            this.sendMailBtn.Text = "Відправити";
            this.sendMailBtn.UseVisualStyleBackColor = true;
            this.sendMailBtn.Click += new System.EventHandler(this.sendMailBtn_Click);
            // 
            // attachFilesBtn
            // 
            this.attachFilesBtn.BackgroundImage = global::SendMail.Properties.Resources.attach;
            this.attachFilesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.attachFilesBtn.Location = new System.Drawing.Point(103, 308);
            this.attachFilesBtn.Name = "attachFilesBtn";
            this.attachFilesBtn.Size = new System.Drawing.Size(23, 28);
            this.attachFilesBtn.TabIndex = 6;
            this.attachFilesBtn.UseVisualStyleBackColor = true;
            this.attachFilesBtn.Click += new System.EventHandler(this.attachFilesBtn_Click);
            // 
            // attachFilesGrid
            // 
            this.attachFilesGrid.AllowUserToAddRows = false;
            this.attachFilesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.attachFilesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attachFilesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attachFilesGrid.ColumnHeadersVisible = false;
            this.attachFilesGrid.Location = new System.Drawing.Point(15, 229);
            this.attachFilesGrid.Name = "attachFilesGrid";
            this.attachFilesGrid.RowHeadersVisible = false;
            this.attachFilesGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attachFilesGrid.Size = new System.Drawing.Size(314, 73);
            this.attachFilesGrid.TabIndex = 7;
            this.attachFilesGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.attachFilesGrid_CellMouseDown);
            // 
            // fileDialog
            // 
            this.fileDialog.Multiselect = true;
            // 
            // CreateMale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 346);
            this.Controls.Add(this.attachFilesGrid);
            this.Controls.Add(this.whomTxb);
            this.Controls.Add(this.attachFilesBtn);
            this.Controls.Add(this.sendMailBtn);
            this.Controls.Add(this.contentTxb);
            this.Controls.Add(this.themeTxb);
            this.Controls.Add(this.themeLbl);
            this.Controls.Add(this.whomLbl);
            this.MaximumSize = new System.Drawing.Size(358, 385);
            this.MinimumSize = new System.Drawing.Size(358, 385);
            this.Name = "CreateMale";
            this.Text = "Нове повідомлення";
            ((System.ComponentModel.ISupportInitialize)(this.attachFilesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whomLbl;
        private System.Windows.Forms.TextBox whomTxb;
        private System.Windows.Forms.Label themeLbl;
        private System.Windows.Forms.TextBox themeTxb;
        private System.Windows.Forms.TextBox contentTxb;
        private System.Windows.Forms.Button sendMailBtn;
        private System.Windows.Forms.Button attachFilesBtn;
        private System.Windows.Forms.DataGridView attachFilesGrid;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}