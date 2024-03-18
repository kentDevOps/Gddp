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
            ((System.ComponentModel.ISupportInitialize)(this.picChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // picChiTiet
            // 
            this.picChiTiet.Location = new System.Drawing.Point(260, 31);
            this.picChiTiet.Name = "picChiTiet";
            this.picChiTiet.Size = new System.Drawing.Size(983, 618);
            this.picChiTiet.TabIndex = 0;
            this.picChiTiet.TabStop = false;
            // 
            // lvChiTiet
            // 
            this.lvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listImg});
            this.lvChiTiet.HideSelection = false;
            this.lvChiTiet.Location = new System.Drawing.Point(22, 31);
            this.lvChiTiet.Name = "lvChiTiet";
            this.lvChiTiet.Size = new System.Drawing.Size(232, 618);
            this.lvChiTiet.TabIndex = 1;
            this.lvChiTiet.UseCompatibleStateImageBehavior = false;
            this.lvChiTiet.View = System.Windows.Forms.View.Details;
            this.lvChiTiet.SelectedIndexChanged += new System.EventHandler(this.lvChiTiet_SelectedIndexChanged);
            // 
            // listImg
            // 
            this.listImg.Text = "List Ảnh Chi Tiết";
            this.listImg.Width = 200;
            // 
            // showImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.lvChiTiet);
            this.Controls.Add(this.picChiTiet);
            this.Name = "showImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ảnh Chi Tiết ";
            ((System.ComponentModel.ISupportInitialize)(this.picChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picChiTiet;
        private System.Windows.Forms.ListView lvChiTiet;
        private System.Windows.Forms.ColumnHeader listImg;
    }
}