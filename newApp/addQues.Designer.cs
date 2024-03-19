namespace newApp
{
    partial class addQues
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
            this.lvAddQues = new System.Windows.Forms.ListView();
            this.addQuestion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbAddQuesDetail = new System.Windows.Forms.Label();
            this.picAdQues = new System.Windows.Forms.PictureBox();
            this.btAdQ1 = new System.Windows.Forms.Button();
            this.lbAdQuesA1 = new System.Windows.Forms.Label();
            this.lbAdQuesHead = new System.Windows.Forms.Label();
            this.lbAdQuesA2 = new System.Windows.Forms.Label();
            this.btAdQ2 = new System.Windows.Forms.Button();
            this.lbAdQuesA3 = new System.Windows.Forms.Label();
            this.btAdQ3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAdQues)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAddQues
            // 
            this.lvAddQues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addQuestion});
            this.lvAddQues.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAddQues.ForeColor = System.Drawing.Color.Brown;
            this.lvAddQues.HideSelection = false;
            this.lvAddQues.Location = new System.Drawing.Point(20, 19);
            this.lvAddQues.Name = "lvAddQues";
            this.lvAddQues.Size = new System.Drawing.Size(317, 566);
            this.lvAddQues.TabIndex = 0;
            this.lvAddQues.UseCompatibleStateImageBehavior = false;
            this.lvAddQues.View = System.Windows.Forms.View.Details;
            this.lvAddQues.SelectedIndexChanged += new System.EventHandler(this.lvAddQues_SelectedIndexChanged);
            this.lvAddQues.DoubleClick += new System.EventHandler(this.lvAddQues_DoubleClick);
            // 
            // addQuestion
            // 
            this.addQuestion.Text = "Câu Hỏi Bổ Sung";
            this.addQuestion.Width = 500;
            // 
            // lbAddQuesDetail
            // 
            this.lbAddQuesDetail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddQuesDetail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAddQuesDetail.Location = new System.Drawing.Point(358, 19);
            this.lbAddQuesDetail.Name = "lbAddQuesDetail";
            this.lbAddQuesDetail.Size = new System.Drawing.Size(574, 35);
            this.lbAddQuesDetail.TabIndex = 3;
            this.lbAddQuesDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picAdQues
            // 
            this.picAdQues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAdQues.Location = new System.Drawing.Point(359, 57);
            this.picAdQues.Name = "picAdQues";
            this.picAdQues.Size = new System.Drawing.Size(583, 279);
            this.picAdQues.TabIndex = 4;
            this.picAdQues.TabStop = false;
            // 
            // btAdQ1
            // 
            this.btAdQ1.BackColor = System.Drawing.Color.IndianRed;
            this.btAdQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdQ1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAdQ1.Location = new System.Drawing.Point(879, 407);
            this.btAdQ1.Name = "btAdQ1";
            this.btAdQ1.Size = new System.Drawing.Size(63, 34);
            this.btAdQ1.TabIndex = 24;
            this.btAdQ1.Text = "Đáp Án";
            this.btAdQ1.UseVisualStyleBackColor = false;
            this.btAdQ1.Click += new System.EventHandler(this.btAdQ1_Click);
            // 
            // lbAdQuesA1
            // 
            this.lbAdQuesA1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAdQuesA1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdQuesA1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAdQuesA1.Location = new System.Drawing.Point(361, 407);
            this.lbAdQuesA1.Name = "lbAdQuesA1";
            this.lbAdQuesA1.Size = new System.Drawing.Size(511, 34);
            this.lbAdQuesA1.TabIndex = 25;
            this.lbAdQuesA1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAdQuesHead
            // 
            this.lbAdQuesHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAdQuesHead.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdQuesHead.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAdQuesHead.Location = new System.Drawing.Point(359, 339);
            this.lbAdQuesHead.Name = "lbAdQuesHead";
            this.lbAdQuesHead.Size = new System.Drawing.Size(583, 55);
            this.lbAdQuesHead.TabIndex = 23;
            this.lbAdQuesHead.Text = "Đáp Án Về Các Cảnh Đẹp Ở Đồng Nai !";
            this.lbAdQuesHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAdQuesA2
            // 
            this.lbAdQuesA2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAdQuesA2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdQuesA2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAdQuesA2.Location = new System.Drawing.Point(361, 475);
            this.lbAdQuesA2.Name = "lbAdQuesA2";
            this.lbAdQuesA2.Size = new System.Drawing.Size(511, 34);
            this.lbAdQuesA2.TabIndex = 25;
            this.lbAdQuesA2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAdQ2
            // 
            this.btAdQ2.BackColor = System.Drawing.Color.IndianRed;
            this.btAdQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdQ2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAdQ2.Location = new System.Drawing.Point(879, 475);
            this.btAdQ2.Name = "btAdQ2";
            this.btAdQ2.Size = new System.Drawing.Size(63, 34);
            this.btAdQ2.TabIndex = 24;
            this.btAdQ2.Text = "Đáp Án";
            this.btAdQ2.UseVisualStyleBackColor = false;
            this.btAdQ2.Click += new System.EventHandler(this.btAdQ2_Click);
            // 
            // lbAdQuesA3
            // 
            this.lbAdQuesA3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAdQuesA3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdQuesA3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAdQuesA3.Location = new System.Drawing.Point(361, 543);
            this.lbAdQuesA3.Name = "lbAdQuesA3";
            this.lbAdQuesA3.Size = new System.Drawing.Size(511, 34);
            this.lbAdQuesA3.TabIndex = 25;
            this.lbAdQuesA3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAdQ3
            // 
            this.btAdQ3.BackColor = System.Drawing.Color.IndianRed;
            this.btAdQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdQ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAdQ3.Location = new System.Drawing.Point(879, 543);
            this.btAdQ3.Name = "btAdQ3";
            this.btAdQ3.Size = new System.Drawing.Size(63, 34);
            this.btAdQ3.TabIndex = 24;
            this.btAdQ3.Text = "Đáp Án";
            this.btAdQ3.UseVisualStyleBackColor = false;
            this.btAdQ3.Click += new System.EventHandler(this.btAdQ3_Click);
            // 
            // addQues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(964, 600);
            this.Controls.Add(this.btAdQ3);
            this.Controls.Add(this.btAdQ2);
            this.Controls.Add(this.btAdQ1);
            this.Controls.Add(this.lbAdQuesA3);
            this.Controls.Add(this.lbAdQuesA2);
            this.Controls.Add(this.lbAdQuesA1);
            this.Controls.Add(this.lbAdQuesHead);
            this.Controls.Add(this.picAdQues);
            this.Controls.Add(this.lbAddQuesDetail);
            this.Controls.Add(this.lvAddQues);
            this.Name = "addQues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Câu Hỏi Bổ Sung";
            this.Load += new System.EventHandler(this.addQues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdQues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAddQues;
        private System.Windows.Forms.ColumnHeader addQuestion;
        private System.Windows.Forms.Label lbAddQuesDetail;
        private System.Windows.Forms.PictureBox picAdQues;
        private System.Windows.Forms.Button btAdQ1;
        private System.Windows.Forms.Label lbAdQuesA1;
        private System.Windows.Forms.Label lbAdQuesHead;
        private System.Windows.Forms.Label lbAdQuesA2;
        private System.Windows.Forms.Button btAdQ2;
        private System.Windows.Forms.Label lbAdQuesA3;
        private System.Windows.Forms.Button btAdQ3;
    }
}