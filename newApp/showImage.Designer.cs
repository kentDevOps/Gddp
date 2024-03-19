namespace newApp
{
    partial class showImage
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
            this.picChiTiet = new System.Windows.Forms.PictureBox();
            this.lvChiTiet = new System.Windows.Forms.ListView();
            this.listImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbHd = new System.Windows.Forms.Label();
            this.lbCh = new System.Windows.Forms.Label();
            this.lbCap1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // picChiTiet
            // 
            this.picChiTiet.Location = new System.Drawing.Point(273, 31);
            this.picChiTiet.Name = "picChiTiet";
            this.picChiTiet.Size = new System.Drawing.Size(970, 618);
            this.picChiTiet.TabIndex = 0;
            this.picChiTiet.TabStop = false;
            // 
            // lvChiTiet
            // 
            this.lvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listImg});
            this.lvChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvChiTiet.ForeColor = System.Drawing.Color.OrangeRed;
            this.lvChiTiet.GridLines = true;
            this.lvChiTiet.HideSelection = false;
            this.lvChiTiet.Location = new System.Drawing.Point(22, 31);
            this.lvChiTiet.Name = "lvChiTiet";
            this.lvChiTiet.Size = new System.Drawing.Size(232, 618);
            this.lvChiTiet.TabIndex = 1;
            this.lvChiTiet.UseCompatibleStateImageBehavior = false;
            this.lvChiTiet.View = System.Windows.Forms.View.Details;
            this.lvChiTiet.SelectedIndexChanged += new System.EventHandler(this.lvChiTiet_SelectedIndexChanged);
            this.lvChiTiet.DoubleClick += new System.EventHandler(this.lvChiTiet_DoubleClick);
            // 
            // listImg
            // 
            this.listImg.Text = "List Ảnh Chi Tiết";
            this.listImg.Width = 300;
            // 
            // lbHd
            // 
            this.lbHd.AutoSize = true;
            this.lbHd.ForeColor = System.Drawing.Color.IndianRed;
            this.lbHd.Location = new System.Drawing.Point(321, 5);
            this.lbHd.Name = "lbHd";
            this.lbHd.Size = new System.Drawing.Size(0, 13);
            this.lbHd.TabIndex = 3;
            // 
            // lbCh
            // 
            this.lbCh.AutoSize = true;
            this.lbCh.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCh.Location = new System.Drawing.Point(346, 9);
            this.lbCh.Name = "lbCh";
            this.lbCh.Size = new System.Drawing.Size(0, 13);
            this.lbCh.TabIndex = 3;
            // 
            // lbCap1
            // 
            this.lbCap1.AutoSize = true;
            this.lbCap1.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCap1.Location = new System.Drawing.Point(386, 15);
            this.lbCap1.Name = "lbCap1";
            this.lbCap1.Size = new System.Drawing.Size(0, 13);
            this.lbCap1.TabIndex = 3;
            // 
            // showImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.lbCap1);
            this.Controls.Add(this.lbCh);
            this.Controls.Add(this.lbHd);
            this.Controls.Add(this.lvChiTiet);
            this.Controls.Add(this.picChiTiet);
            this.Name = "showImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ảnh Chi Tiết ";
            ((System.ComponentModel.ISupportInitialize)(this.picChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picChiTiet;
        private System.Windows.Forms.ListView lvChiTiet;
        private System.Windows.Forms.ColumnHeader listImg;
        private System.Windows.Forms.Label lbHd;
        private System.Windows.Forms.Label lbCh;
        private System.Windows.Forms.Label lbCap1;
    }
}