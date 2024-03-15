using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newApp
{
    public partial class addQues : Form
    {
        public addQues()
        {
            InitializeComponent();
        }
        public ListView addQuestionList
        {
            get { return lvAddQues; }
            set { lvAddQues = value; }
        }
        public Label quesDetail
        {
            get { return lbAddQuesDetail; }
            set { lbAddQuesDetail = value; }
        }
        public Label addQuestionHead
        {
            get { return lbAdQuesHead; }
            set { lbAdQuesHead = value; }
        }

        private void lvAddQues_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lvAddQues.SelectedItems.Count; i++)
                {
                    string sltItem = lvAddQues.SelectedItems[i].Text;
                    //string VideoName = strVideoPath + @"\" + lvVideo.SelectedItems[i].Text + ".mp4";
                    if (sltItem == "Tại sao lại có đền thờ Nguyễn Hữu Cảnh ?")
                    {
                        lbAddQuesDetail.Text = sltItem;
                        addImg("q1.jpg");
                        lbAdQuesHead.Text = "Đáp Án Cho Câu Hỏi : " + sltItem;

                    }
                    else if (sltItem == "Hiện tại đền thờ Nguyễn Hữu Cảnh tọa lạc ở địa phương nào?")
                    {
                        lbAddQuesDetail.Text = sltItem;
                        addImg("q2.jpg");
                        lbAdQuesHead.Text = "Đáp Án Cho Câu Hỏi : " + sltItem;
                    }
                    else if (sltItem == "Tại sao lại có những con đường, ngôi trường mang tên Nguyễn Hữu Cảnh?")
                    {
                        lbAddQuesDetail.Text = sltItem;
                        addImg("q3.jpg");
                        lbAdQuesHead.Text = "Đáp Án Cho Câu Hỏi : " + sltItem;
                    }
                }
            } catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void addImg(string imgName)
        {
            string kdIconPath = iniConfig.RelativeToFullPath(@"...") + @"\img\nhc\" + imgName;
            picAdQues.Image = Image.FromFile(kdIconPath);
            picAdQues.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
