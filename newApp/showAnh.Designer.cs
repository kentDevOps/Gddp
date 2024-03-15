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
            this.btShow.Location = new System.Drawing.Point(-1, -1);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(177, 55);
            this.btShow.TabIndex = 1;
            this.btShow.Text = "Kết Quả";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Location = new System.Drawing.Point(202, 9);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(127, 35);
            this.lbTieuDe.TabIndex = 2;
            this.lbTieuDe.Text = "label1";
            // 
            // lbDes
            // 
            this.lbDes.Location = new System.Drawing.Point(437, 9);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(127, 35);
            this.lbDes.TabIndex = 2;
            // 
            // showAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 789);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.picShow);
            this.Name = "showAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showAnh";
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbDes;
    }
}