namespace SendMail
{
    partial class GetMale
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
            this.maleGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.maleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // maleGrid
            // 
            this.maleGrid.AllowUserToAddRows = false;
            this.maleGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.maleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maleGrid.ColumnHeadersVisible = false;
            this.maleGrid.Location = new System.Drawing.Point(1, 2);
            this.maleGrid.Name = "maleGrid";
            this.maleGrid.RowHeadersVisible = false;
            this.maleGrid.Size = new System.Drawing.Size(812, 218);
            this.maleGrid.TabIndex = 0;
            // 
            // GetMale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 221);
            this.Controls.Add(this.maleGrid);
            this.Name = "GetMale";
            this.Text = "GetMale";
            ((System.ComponentModel.ISupportInitialize)(this.maleGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView maleGrid;
    }
}