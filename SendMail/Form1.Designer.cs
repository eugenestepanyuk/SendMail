namespace SendMail
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsMaleBtn = new System.Windows.Forms.Button();
            this.createMaleBtn = new System.Windows.Forms.Button();
            this.getMaleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsMaleBtn
            // 
            this.settingsMaleBtn.Location = new System.Drawing.Point(12, 12);
            this.settingsMaleBtn.Name = "settingsMaleBtn";
            this.settingsMaleBtn.Size = new System.Drawing.Size(85, 36);
            this.settingsMaleBtn.TabIndex = 0;
            this.settingsMaleBtn.Text = "Налаштувати пошту";
            this.settingsMaleBtn.UseVisualStyleBackColor = true;
            this.settingsMaleBtn.Click += new System.EventHandler(this.settingsMaleBtn_Click);
            // 
            // createMaleBtn
            // 
            this.createMaleBtn.Location = new System.Drawing.Point(116, 12);
            this.createMaleBtn.Name = "createMaleBtn";
            this.createMaleBtn.Size = new System.Drawing.Size(85, 36);
            this.createMaleBtn.TabIndex = 1;
            this.createMaleBtn.Text = "Відправити пошту";
            this.createMaleBtn.UseVisualStyleBackColor = true;
            this.createMaleBtn.Click += new System.EventHandler(this.createMaleBtn_Click);
            // 
            // getMaleBtn
            // 
            this.getMaleBtn.Location = new System.Drawing.Point(221, 12);
            this.getMaleBtn.Name = "getMaleBtn";
            this.getMaleBtn.Size = new System.Drawing.Size(85, 36);
            this.getMaleBtn.TabIndex = 2;
            this.getMaleBtn.Text = "Отримати пошту";
            this.getMaleBtn.UseVisualStyleBackColor = true;
            this.getMaleBtn.Click += new System.EventHandler(this.getMaleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 61);
            this.Controls.Add(this.getMaleBtn);
            this.Controls.Add(this.createMaleBtn);
            this.Controls.Add(this.settingsMaleBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsMaleBtn;
        private System.Windows.Forms.Button createMaleBtn;
        private System.Windows.Forms.Button getMaleBtn;
    }
}

