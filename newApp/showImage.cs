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
    public partial class showImage : Form
    {
        public showImage()
        {
            InitializeComponent();
        }
        public PictureBox MyPictureBox
        {
            get { return picChiTiet; }
            set { picChiTiet = value; }
        }
        public ListView myList
        {
            get { return lvChiTiet; }
            set { lvChiTiet = value; }
        }
        public Label lbCap
        {
            get { return lbHd; }
            set { lbHd = value; }
        }
        public Label lbCapMoi
        {
            get { return lbCap1; }
            set { lbCap1 = value; }
        }
        public Label lbques
        {
            get { return lbCh; }
            set { lbCh = value; }
        }
        private void lvChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\nhc\danhNhan\";
        private void lvChiTiet_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lbCap1.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    string strVideoPath1 = iniConfig.RelativeToFullPath(@"...") + @"img\gom\";
                    for (int i = 0; i < lvChiTiet.Items.Count - 1; i++)
                    {
                        string sltItem = lvChiTiet.SelectedItems[i].Text;
                        string StrFolder = "";
                        string subFolder = "";
                        if (lbHd.Text == "Hoạt Động 1")
                        {
                            StrFolder = "hd1";
                            if (lbques.Text == "Nghề gốm mĩ nghệ Biên Hoà được hình thành từ khi nào ? Ở đâu?")
                            {
                                subFolder = "ch1";
                            }
                            else
                            {
                                subFolder = "ch2";
                            }
                        }
                        else
                        {
                            StrFolder = "hd2";
                            subFolder = "step";
                        }
                        picChiTiet.Image = Image.FromFile(strVideoPath1 + StrFolder + @"\" + subFolder + @"\" + sltItem);
                        picChiTiet.SizeMode = PictureBoxSizeMode.StretchImage;
                        return;
                    }
                }else if (lbCap1.Text == "Nguyễn Hữu Cảnh")
                {
                    if (lbHd.Text == "danhNhan")
                    {
                        string strVideoPath1 = iniConfig.RelativeToFullPath(@"...") + @"img\nhc\danhNhan";
                        for (int i = 0; i < lvChiTiet.Items.Count - 1; i++)
                        {
                            string sltItem = lvChiTiet.SelectedItems[i].Text;
                            string StrFolder = "";
                            picChiTiet.Image = Image.FromFile(strVideoPath1 + StrFolder + @"\" + sltItem);
                            picChiTiet.SizeMode = PictureBoxSizeMode.StretchImage;
                            return;
                        }

                    }
                    else
                    {
                        string strVideoPath1 = iniConfig.RelativeToFullPath(@"...") + @"img\nhc\tonTho";
                        for (int i = 0; i < lvChiTiet.Items.Count - 1; i++)
                        {
                            string sltItem = lvChiTiet.SelectedItems[i].Text;
                            string StrFolder = "";
                            picChiTiet.Image = Image.FromFile(strVideoPath1 + StrFolder + @"\" + sltItem);
                            picChiTiet.SizeMode = PictureBoxSizeMode.StretchImage;
                            return;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
