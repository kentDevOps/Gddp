namespace newApp
{
    partial class showAnh
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
            this.picShow = new System.Windows.Forms.PictureBox();
            this.btShow = new System.Windows.Forms.Button();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // picShow
            // 
            this.picShow.Location = new System.Drawing.Point(-1, -1);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(1537, 789);
            this.picShow.TabIndex = 0;
            this.picShow.TabStop = false;
            // 
            // btShow
            // 
            this.btShow.BackColor = System.Drawing.Color.IndianRed;
            this.btShow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShow.Location = new System.Drawing.Point(-1, -1);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(177, 55);
            this.btShow.TabIndex = 1;
            this.btShow.Text = "Kết Quả";
            this.btShow.UseVisualStyleBackColor = false;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.IndianRed;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.White;
            this.lbTieuDe.Location = new System.Drawing.Point(202, 9);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(0, 21);
            this.lbTieuDe.TabIndex = 2;
            // 
            // lbDes
            // 
            this.lbDes.BackColor = System.Drawing.Color.IndianRed;
            this.lbDes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDes.Location = new System.Drawing.Point(235, 9);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(597, 35);
            this.lbDes.TabIndex = 2;
            // 
            // showAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.picShow);
            this.Name = "showAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showAnh";
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbDes;
    }
}