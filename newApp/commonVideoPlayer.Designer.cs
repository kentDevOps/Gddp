namespace newApp
{
    partial class commonVideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(commonVideoPlayer));
            this.lvVideoCommon = new System.Windows.Forms.ListView();
            this.videoList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mediaPlayerCommon = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerCommon)).BeginInit();
            this.SuspendLayout();
            // 
            // lvVideoCommon
            // 
            this.lvVideoCommon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.videoList});
            this.lvVideoCommon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVideoCommon.ForeColor = System.Drawing.Color.Brown;
            this.lvVideoCommon.GridLines = true;
            this.lvVideoCommon.HideSelection = false;
            this.lvVideoCommon.Location = new System.Drawing.Point(12, 27);
            this.lvVideoCommon.Name = "lvVideoCommon";
            this.lvVideoCommon.Size = new System.Drawing.Size(254, 622);
            this.lvVideoCommon.TabIndex = 1;
            this.lvVideoCommon.UseCompatibleStateImageBehavior = false;
            this.lvVideoCommon.View = System.Windows.Forms.View.Details;
            // 
            // videoList
            // 
            this.videoList.Text = "Danh Sách Video";
            this.videoList.Width = 500;
            // 
            // mediaPlayerCommon
            // 
            this.mediaPlayerCommon.Enabled = true;
            this.mediaPlayerCommon.Location = new System.Drawing.Point(287, 27);
            this.mediaPlayerCommon.Name = "mediaPlayerCommon";
            this.mediaPlayerCommon.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayerCommon.OcxState")));
            this.mediaPlayerCommon.Size = new System.Drawing.Size(965, 622);
            this.mediaPlayerCommon.TabIndex = 2;
            // 
            // commonVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.mediaPlayerCommon);
            this.Controls.Add(this.lvVideoCommon);
            this.Name = "commonVideoPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình Phát Video";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerCommon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVideoCommon;
        private System.Windows.Forms.ColumnHeader videoList;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayerCommon;
    }
}