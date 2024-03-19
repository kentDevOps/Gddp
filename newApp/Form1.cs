using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace newApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strVideoPath = "";
        string IconPath = "";
        string iniPathC = iniConfig.RelativeToFullPath(@"...") + @"config.ini";
        private void btKD_Click(object sender, EventArgs e)
        {
            try
            {
                //string strVideoPath = @"D:\02_Code\03_c#\00_AppGd" + @"\" + "cc.webm";
                string iniPath = iniConfig.RelativeToFullPath(@"...") + @"config.ini";
                string kdIconPath = iniConfig.RelativeToFullPath(@"...") + @"\img\kdIcon.png";
                string strVideoPath1 = "";
                string strAudioPath1 = "";
                picIconKd.Image = Image.FromFile(kdIconPath);
                picIconKd.SizeMode = PictureBoxSizeMode.StretchImage;
                if (lbcap.Text == "Đồng Nai Quê Hương Tươi Đẹp")
                {
                    notBook.SelectedTab = tKhoiDong;
                    strVideoPath1 = iniConfig.readIni(iniPath, "bai1", "videoPath") + @"\" + iniConfig.readIni(iniPath, "bai1", "videoName");
                    strAudioPath1 = iniConfig.readIni(iniPath, "bai1", "AudioPath") + @"\" + iniConfig.readIni(iniPath, "bai1", "AudioName");
                    mediaPlayer.URL = strVideoPath1;
                    mediaPlayer.settings.autoStart = false;
                    audioTool.URL = strAudioPath1;
                    audioTool.settings.autoStart = false;
                }
                else if (lbcap.Text == "Nguyễn Hữu Cảnh")
                {
                    
                    kdLoad("bai2", "videoKhoiDongPath", "Hãy Cùng Xem Một Số Đoạn Phim Về Nguyễn Hữu Cảnh !");
                }
                else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    
                    kdLoad("bai3", "videoKhoiDongPath", "Hãy Cùng Xem Một Số Đoạn Phim Về Nghề Gốm Mĩ Nghệ Biên Hòa !");
                }
                else if (lbcap.Text == "Bưởi Tân Triều")
                {
                    kdLoad("bai4", "videoKhoiDongPath", "Hãy Cùng Xem Một Số Đoạn Phim Về Bưởi Tân Triều !");

                }
                else if (lbcap.Text == "Văn Miếu Trấn Biên")
                {
                    kdLoad("bai5", "videoKhoiDongPath", "Hãy Cùng Xem Một Số Đoạn Phim Về Văn Miếu Trấn Biên !");

                }
                else
                {
                    MessageBox.Show("Hãy Chọn Một Bài Học !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(),"System Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void kdLoad(string baiSo,string sectionVideo,string cap)
        {
            notBook.SelectedTab = tKdCommon;
            mediaKDCm.URL = "";
            //lvVideo.Clear();
            lvVideo.Items.Clear();
            //load anh Icon 
            IconPath = iniConfig.RelativeToFullPath(@"...") + @"\img\kdIcon.png";
            picIconKdCm.Image = Image.FromFile(IconPath);
            picIconKdCm.SizeMode = PictureBoxSizeMode.StretchImage;
            //Load List View
            strVideoPath = iniConfig.readIni(iniPathC, baiSo, sectionVideo);
            
            foreach (string item in Directory.GetFiles(strVideoPath))
            {
                string temp = item.Substring(item.LastIndexOf("\\") + 1);
                string verName = Path.GetFileNameWithoutExtension(temp);
                lvVideo.Items.Add(verName);

            }
            lbKdCmCap.Text = cap;
        }

        private void btB1_Click(object sender, EventArgs e)
        {
            try
            {
                lbcap.Text = "Đồng Nai Quê Hương Tươi Đẹp";
                notBook.SelectedTab = screenT;
                loadAvar("dongNai.jpg");
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                notBook.SelectedTab = screenT;
                lbcap.Text = "Chào Mừng Các Bạn !";
                loadAvar("mainAvar.png");
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void loadAvar(string strName)
        {
            string strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"\img\" + strName;
            screenT.BackgroundImage = Image.FromFile(strVideoPath);
            screenT.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btKP_Click(object sender, EventArgs e)
        {
            try
            {
                clearVdCmAns();
                if (lbcap.Text == "Đồng Nai Quê Hương Tươi Đẹp")
                {
                    notBook.SelectedTab = tKhamPha;
                    //Load tung anh 1 danh thang
                    string strTc1Path = iniConfig.RelativeToFullPath(@"...") + @"\img\du-lich-Da-Ba-Chong.jpg";
                    string strTc2Path = iniConfig.RelativeToFullPath(@"...") + @"\img\TriAn.png";
                    string strTc3Path = iniConfig.RelativeToFullPath(@"...") + @"\img\nuiChuaChan.png";
                    string kpIconPath = iniConfig.RelativeToFullPath(@"...") + @"\img\kpIcon.png";


                    picIconKp.Image = Image.FromFile(kpIconPath);
                    picIconKp.SizeMode = PictureBoxSizeMode.StretchImage;


                    picDanhThang1.Image = Image.FromFile(strTc1Path);
                    picDanhThang1.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDanhThang2.Image = Image.FromFile(strTc2Path);
                    picDanhThang2.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDanhThang3.Image = Image.FromFile(strTc3Path);
                    picDanhThang3.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Load tung anh 1 du lich
                    string strDlPath1 = iniConfig.RelativeToFullPath(@"...") + @"\img\suoiMo.jpg";
                    string strDlPath2 = iniConfig.RelativeToFullPath(@"...") + @"\img\giangDien.jpg";
                    string strDlPath3 = iniConfig.RelativeToFullPath(@"...") + @"\img\khu-du-lich-buu-long.jpg";
                    string strDlPath4 = iniConfig.RelativeToFullPath(@"...") + @"\img\langBuoi.png";

                    picDulich1.Image = Image.FromFile(strDlPath1);
                    picDulich1.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDulich2.Image = Image.FromFile(strDlPath2);
                    picDulich2.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDulich3.Image = Image.FromFile(strDlPath3);
                    picDulich3.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDulich4.Image = Image.FromFile(strDlPath4);
                    picDulich4.SizeMode = PictureBoxSizeMode.StretchImage;
                }else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    notBook.SelectedTab = tKhamPhaCm;
                    //load data vao combobox
                    cbKpCm.Items.Clear();
                    cbKpCm.Items.Add("Hoạt Động 1");
                    cbKpCm.Items.Add("Hoạt Động 2");
                    // load icon
                    string kpIconPath = iniConfig.RelativeToFullPath(@"...") + @"\img\kpIcon.png";


                    picKpCm.Image = Image.FromFile(kpIconPath);
                    picKpCm.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Hãy Chọn Một Bài Học !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void picDanhThang1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                showAnh newF = new showAnh();
                newF.Show();
                string strTc1Path = iniConfig.RelativeToFullPath(@"...") + @"\img\du-lich-Da-Ba-Chong.jpg";
                newF.MyPictureBox.Image = Image.FromFile(strTc1Path);
                newF.MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newF.myCap.Text = "daBaChong";
                newF.myCap.Visible = false;
                //newF.myDes1.Text = "Danh thắng đá Ba Chồng , huyện Định Quán";
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picDanhThang2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                showAnh newF = new showAnh();
                newF.Show();
                string strTc1Path = iniConfig.RelativeToFullPath(@"...") + @"\img\TriAn.png";
                newF.MyPictureBox.Image = Image.FromFile(strTc1Path);
                newF.MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newF.myCap.Text = "triAn";
                newF.myCap.Visible = false;
                // newF.myDes1.Text = "Thủy Điện Trị An , huyện Vĩnh Cửu";
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picDanhThang3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                showAnh newF = new showAnh();
                newF.Show();
                string strTc1Path = iniConfig.RelativeToFullPath(@"...") + @"\img\nuiChuaChan.png";
                newF.MyPictureBox.Image = Image.FromFile(strTc1Path);
                newF.MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newF.myCap.Text = "chuaChan";
                newF.myCap.Visible = false;
                //newF.myDes1.Text = "Núi Chứa Chan , Huyện Xuân Lộc - Đồng Nai";
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picDulich1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                showAnh newF = new showAnh();
                newF.Show();
                string strTc1Path = iniConfig.RelativeToFullPath(@"...") + @"\img\suoiMo.jpg";
                newF.MyPictureBox.Image = Image.FromFile(strTc1Path);
                newF.MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newF.myCap.Text = "suoiMo";
                newF.myCap.Visible = false;
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picDulich2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                showAnh newF = new showAnh();
                newF.Show();
                string strTc1Path = iniConfig.RelativeToFullPath(@"...") + @"\img\giangDien.jpg";
                newF.MyPictureBox.Image = Image.FromFile(strTc1Path);
                newF.MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newF.myCap.Text = "giangDien";
                newF.myCap.Visible = false;
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picDulich3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                showAnh newF = new showAnh();
                newF.Show();
                string strTc1Path = iniConfig.RelativeToFullPath(@"...") + @"\img\khu-du-lich-buu-long.jpg";
                newF.MyPictureBox.Image = Image.FromFile(strTc1Path);
                newF.MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newF.myCap.Text = "cuuLong";
                newF.myCap.Visible = false;
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picDulich4_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                showAnh newF = new showAnh();
                newF.Show();
                string strTc1Path = iniConfig.RelativeToFullPath(@"...") + @"\img\langBuoi.png";
                newF.MyPictureBox.Image = Image.FromFile(strTc1Path);
                newF.MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newF.myCap.Text = "tanTrieu";
                newF.myCap.Visible = false;
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btLT_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbcap.Text == "Đồng Nai Quê Hương Tươi Đẹp")
                {
                    notBook.SelectedTab = tLuyenTap;
                    string kpIconPath = iniConfig.RelativeToFullPath(@"...") + @"\img\ltIcon.png";
                    picIconLt.Image = Image.FromFile(kpIconPath);
                    picIconLt.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Load anh hoi danh thang
                    string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\img\dtQuest.png";
                    picQuestDt.Image = Image.FromFile(dtQuestImg);
                    picQuestDt.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Load anh hoi Du Lich
                    string dlQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\img\dlQuest.jpg";
                    picQuestDl.Image = Image.FromFile(dlQuestImg);
                    picQuestDl.SizeMode = PictureBoxSizeMode.StretchImage;
                }else if (lbcap.Text == "Nguyễn Hữu Cảnh")
                {
                    clearLuyenTapCommon();
                    loadCommonLuyentap("1. Kể lại một số điều em biết về Nguyễn Hữu Cảnh.", "Vì sao Nguyễn Hữu Cảnh được nhân dân Đồng Nai nhớ ơn và tôn thờ?", "Đáp Án Cho Câu Hỏi 1 :", "Đáp Án Cho Câu Hỏi 2 :", "nhcQ1.jpg", "nhcQ2.jpg");
                }else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    clearLuyenTapCommon();
                    loadCommonLuyentap("1. Cùng các bạn giới thiệu về nghề gốm mĩ nghệ Biên Hoà, Đồng Nai.", "2. Em hãy kể tên một số sản phẩm gốm mĩ nghệ Biên Hoà. Cho biết những sản phẩm gốm mà gia đình em đang sử dụng.", "Đáp Án Cho Câu Hỏi 1 :", "Đáp Án Cho Câu Hỏi 2 :", @"gom\luyenTap\gtGom.jpg", @"gom\luyenTap\gtGom.jpg");
                }
                else
                {
                    MessageBox.Show("Hãy Chọn Một Bài Học !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearLuyenTapCommon()
        {
            lbLtACm1.Text = "";
            lbLtACm2.Text = "";
            lbLtACm3.Text = "";
            lbLtACm7.Text = "";
            lbLtACm8.Text = "";
            lbLtACm10.Text = "";
            lbLtACm11.Text = "";
            lbLtACm4.Text = "";
        }

        public void loadCommonLuyentap(string cap1 ,string cap2,string head1,string head2,string imgName1, string imgName2)
        {
            notBook.SelectedTab = tLTCommon;
            string kpIconPath = iniConfig.RelativeToFullPath(@"...") + @"\img\ltIcon.png";
            picIcoLtCm.Image = Image.FromFile(kpIconPath);
            picIcoLtCm.SizeMode = PictureBoxSizeMode.StretchImage;

            // Load anh hoi danh thang
            string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\img\" + imgName1;//nhcQ1.jpg";
            picQ1LtCm.Image = Image.FromFile(dtQuestImg);
            picQ1LtCm.SizeMode = PictureBoxSizeMode.StretchImage;
            // Load anh hoi Du Lich
            string dlQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\img\" + imgName2 ;//nhcQ2.jpg";
            picQ2LtCm.Image = Image.FromFile(dlQuestImg);
            picQ2LtCm.SizeMode = PictureBoxSizeMode.StretchImage;

            //tieu de
            lbLtCap1Cm.Text = cap1;
            lbLtCap2Cm.Text = cap2;
            lbLtHead1Cm.Text = head1;
            lbLtHead2Cm.Text = head2;
        }

        private void picQuestDt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\keDt.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picQuestDl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\keDl.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDtDa1_Click(object sender, EventArgs e)
        {
            try
            {
                lbDtRs1.Text = "Danh thắng đá Ba Chồng , huyện Định Quán";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\daBaChongRs.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDtDa2_Click(object sender, EventArgs e)
        {
            try
            {
                lbDtRs2.Text = "Thủy điện Trị An, huyện Vĩnh Cửu";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\triAnRs.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDtDa3_Click(object sender, EventArgs e)
        {
            try
            {
                lbDtRs3.Text = "Rừng Sác Nhơn Trạch, huyện Nhơn Trạch";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\sacRs.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDtDa4_Click(object sender, EventArgs e)
        {
            try
            {
                lbDtRs4.Text = "Vườn quốc gia Cát Tiên";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\catTienRs.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDtDa5_Click(object sender, EventArgs e)
        {
            try
            {
                /*lbDtRs5.Text = "Thác Mai - Bàu nước sôi, huyện Định Quán";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\thacMaiRs.mp3";
                common.phatAudio(dtQuestImg);*/
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDtDa6_Click(object sender, EventArgs e)
        {
            try
            {
                /*lbDtRs6.Text = "Đảo Ó - Đồng Trường, huyện Vĩnh Cửu";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\daoORs.mp3";
                common.phatAudio(dtQuestImg);*/
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDlDa1_Click(object sender, EventArgs e)
        {
            try
            {
                lbDlRs1.Text = "Khu Du Lịch Suối Mơ, huyện Tân Phú";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\suoiMoRs.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDlDa2_Click(object sender, EventArgs e)
        {
            try
            {
                lbDlRs2.Text = "Khu Du Lịch Sinh Thái Thác Giang Điền, huyện Trảng Bom";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\giangDienRs.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDlDa3_Click(object sender, EventArgs e)
        {
            try
            {
                lbDlRs3.Text = "Khu Du Lịch Bửu Long, Thành Phố Biên Hòa";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\buuLongRs.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDlDa4_Click(object sender, EventArgs e)
        {
            try
            {
                lbDlRs4.Text = "Khu Du Lịch Sinh Thái Làng Bưởi Tân Triều , Huyện Vĩnh Cửu";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\buoiRs.mp3";
                common.phatAudio(dtQuestImg);
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDlDa5_Click(object sender, EventArgs e)
        {
            try
            {
                /*lbDlRs5.Text = "Làng du lịch Tre Việt , Huyện Nhơn Trạch";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\treRs.mp3";
                common.phatAudio(dtQuestImg);*/
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDlDa6_Click(object sender, EventArgs e)
        {
            try
            {
                /*lbDlRs6.Text = "Khu du lịch Vườn Xoài , Thành Phố Biên Hòa";
                string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\xoaiRs.mp3";
                common.phatAudio(dtQuestImg);*/
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btVD_Click(object sender, EventArgs e)
        {
            try
            {
                string iniPath = iniConfig.RelativeToFullPath(@"...") + @"config.ini";
                string kdIconPath = iniConfig.RelativeToFullPath(@"...") + @"\img\vdIcon.png";
                string strVideoPath1 = "";

                if (lbcap.Text == "Đồng Nai Quê Hương Tươi Đẹp")
                {
                    //load video
                    notBook.SelectedTab = tVanDung;
                    picIconVd.Image = Image.FromFile(kdIconPath);
                    picIconVd.SizeMode = PictureBoxSizeMode.StretchImage;
                    strVideoPath1 = iniConfig.readIni(iniPath, "bai1", "videoVanDungPath") + @"\" + iniConfig.readIni(iniPath, "bai1", "videoVanDungName");
                    mediaVanDungB1.URL = strVideoPath1;
                    mediaVanDungB1.settings.autoStart = false;
                    //load anhr
                    string dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\img\vanDungB1.jpg";
                    picVanDungB1.Image = Image.FromFile(dtQuestImg);
                    picVanDungB1.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                }
                else if (lbcap.Text == "Nguyễn Hữu Cảnh")
                {
                    
                    notBook.SelectedTab = tVanDungCm;
                    picIconVDcm.Image = Image.FromFile(kdIconPath);
                    picIconVDcm.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Load Question
                    loadQuesVanDung();
                }else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    notBook.SelectedTab = tVanDungCm;
                    picIconVDcm.Image = Image.FromFile(kdIconPath);
                    picIconVDcm.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Load Question
                    loadQuesVanDung();
                }
                else
                {
                    MessageBox.Show("Hãy Chọn Một Bài Học !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadQuesVanDung()
        {
           // lvVanDungQuesCm.Clear();
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                lvVanDungQuesCm.Items.Clear();
                lvVanDungQuesCm.Items.Add(new ListViewItem("Để ghi nhớ công lao của Nguyễn Hữu Cảnh, học sinh chúng ta nên làm gì?"));
                lvVanDungQuesCm.Items.Add(new ListViewItem("Hãy chia sẻ với các bạn về một nhân vật lịch sử – văn hoá ở địa phương em đang sinh sống."));
            }else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                lvVanDungQuesCm.Items.Clear();
                lvVanDungQuesCm.Items.Add(new ListViewItem("Hãy cùng thầy (cô) hoặc ba (mẹ) đi thăm một cơ sở làm gốm mĩ nghệ Biên Hoà"));
                lvVanDungQuesCm.Items.Add(new ListViewItem("Hãy trải nghiệm các bước để làm ra một sản phẩm gốm và kể lại nhé ."));
            }
        }

        private void btB2_Click(object sender, EventArgs e)
        {
            try
            {
                lbcap.Text = "Nguyễn Hữu Cảnh";
                notBook.SelectedTab = screenT;
                loadAvar("NHC.jpg");
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvVideo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string strVideoPath = ""; ;
                if (lbcap.Text == "Nguyễn Hữu Cảnh")
                {
                    strVideoPath = iniConfig.readIni(iniPathC, "bai2", "videoKhoiDongPath");
                }
                else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    strVideoPath = iniConfig.readIni(iniPathC, "bai3", "videoKhoiDongPath");
                }

                for (int i = 0; i <= lvVideo.SelectedItems.Count - 1; i++)
                {
                    string VideoName = strVideoPath + @"\" + lvVideo.SelectedItems[i].Text + ".mp4";
                    mediaKDCm.URL = VideoName;
                }
            }
            catch(Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btB3_Click(object sender, EventArgs e)
        {
            try
            {
                lbcap.Text = "Nghề Gốm Mĩ Nghệ Biên Hoà";
                notBook.SelectedTab = screenT;
                loadAvar("gbh.jpg");
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btB4_Click(object sender, EventArgs e)
        {
            try
            {
                lbcap.Text = "Bưởi Tân Triều";
                notBook.SelectedTab = screenT;
                loadAvar("buoiTanTrieu.jpg");
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btB5_Click(object sender, EventArgs e)
        {
            try
            {
                lbcap.Text = "Văn Miếu Trấn Biên";
                notBook.SelectedTab = screenT;
                loadAvar("vanMieu.jpg");
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDanhThang1_Click(object sender, EventArgs e)
        {

        }

        private void picQ2LtCm_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string dtQuestImg = "";
                if (lbcap.Text == "Nguyễn Hữu Cảnh")
                {
                    dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\nhcNhoOnKe.mp3";
                    common.phatAudio(dtQuestImg);
                    showImage newf = new showImage();
                    newf.Show();
                    string strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\nhc\tonTho\";

                    foreach (string item in Directory.GetFiles(strVideoPath))
                    {
                        //string temp = item.Substring(item.LastIndexOf("\\") + 1);
                        string verName = Path.GetFileName(item);
                        newf.myList.Items.Add(verName);
                        newf.lbCapMoi.Text = lbcap.Text;
                        //lvVideo.Items.Add(verName);

                    }
                }else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    //gomKeTen.mp3
                    dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\gomKeTen.mp3";
                    common.phatAudio(dtQuestImg);
                }



            }
            catch(Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picQuestDt_Click(object sender, EventArgs e)
        {

        }

        private void picQ1LtCm_Click(object sender, EventArgs e)
        {

        }

        private void picQ1LtCm_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string dtQuestImg = "";
                if (lbcap.Text == "Nguyễn Hữu Cảnh")
                {
                    dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\nhcKe.mp3";
                    common.phatAudio(dtQuestImg);
                }else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    dtQuestImg = iniConfig.RelativeToFullPath(@"...") + @"\aud\gtGom.mp3";
                    common.phatAudio(dtQuestImg);
                }
                
                
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void picQ2LtCm_Click(object sender, EventArgs e)
        {

        }
        string strfeature = "";
        private void btLtcm1_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDacDiem1");
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai3", "gomCh1As1");
            }
            
            lbLtACm1.Text = strfeature;
        }

        private void btLtCm2_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDacDiem2");
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai3", "gomCh1As2");
            }
            lbLtACm2.Text = strfeature;
        }

        private void btLtCm3_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDacDiem3");
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai3", "gomCh1As3");
            }
            lbLtACm3.Text = strfeature;
        }

        private void btLtCm4_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDacDiem4");
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai3", "gomCh1As4");
            }
            lbLtACm4.Text = strfeature;
        }

        private void btLtCm5_Click(object sender, EventArgs e)
        {
            /*strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDacDiem5");
            lbLtACm5.Text = strfeature;*/
        }

        private void btLtCm6_Click(object sender, EventArgs e)
        {
            /*strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDacDiem6");
            lbLtACm6.Text = strfeature;*/
        }

        private void btLtCm7_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhNhoOn1");
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai3", "gomCh2As1");
            }
            lbLtACm7.Text = strfeature;
        }

        private void btLtCm8_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhNhoOn2");
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai3", "gomCh2As2");
            }
            lbLtACm8.Text = strfeature;
        }

        private void btLtCm9_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhNhoOn3");
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai3", "gomCh2As3");
            }
            lbLtACm10.Text = strfeature;
        }

        private void btLtCm10_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhNhoOn4");
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                strfeature = iniConfig.readIni(iniPathC, "bai3", "gomCh2As4");
            }
            lbLtACm11.Text = strfeature;
        }

        private void btLtCm11_Click(object sender, EventArgs e)
        {
            /*strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDacDiem1");
            lbLtACm12.Text = strfeature;*/
        }

        private void btLtCm12_Click(object sender, EventArgs e)
        {
            /*strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDacDiem1");
            lbLtACm13.Text = strfeature;*/
        }

        private void btAdQues_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbcap.Text == "Nguyễn Hữu Cảnh")
                {
                    List<string> cauHoi = new List<string> {"Tại sao lại có đền thờ Nguyễn Hữu Cảnh ?",
                    "Hiện tại đền thờ Nguyễn Hữu Cảnh tọa lạc ở địa phương nào?",
                    "Tại sao lại có những con đường, ngôi trường mang tên Nguyễn Hữu Cảnh?" };

                    loadAdQuesCommon(cauHoi);
                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void loadAdQuesCommon(List<string> listQues)
        {
            addQues newF = new addQues();
            newF.Show();
            foreach (string item in listQues)
            {
                newF.addQuestionList.Items.Add(item);
            }
        }

        private void picDulich3_Click(object sender, EventArgs e)
        {

        }

        private void lvVideo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvVanDungQuesCm_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                
                for (int i = 0; i < lvVanDungQuesCm.SelectedItems.Count; i++)
                {
                    //clearAnswer();
                    clearVanDungcm();
                    string sltItem = lvVanDungQuesCm.SelectedItems[i].Text;
                    int selectedIndex = lvVanDungQuesCm.SelectedIndices[i];
                    if (lbcap.Text == "Nguyễn Hữu Cảnh")
                    {
                        //string VideoName = strVideoPath + @"\" + lvVideo.SelectedItems[i].Text + ".mp4";
                        if (sltItem == "Để ghi nhớ công lao của Nguyễn Hữu Cảnh, học sinh chúng ta nên làm gì?")
                        {
                            lbVanDungCmHead.Text = sltItem;
                            addImgVanDungCm("congLao.jpg");
                            lbVanDungAnsCm.Text = "Đáp Án Cho Câu Hỏi : ";

                        }
                        else if (sltItem == "Hãy chia sẻ với các bạn về một nhân vật lịch sử – văn hoá ở địa phương em đang sinh sống.")
                        {
                            lbVanDungCmHead.Text = sltItem;
                            addImgVanDungCm("nvLs.jpg");
                            lbVanDungAnsCm.Text = "Đáp Án Cho Câu Hỏi : ";
                        }
                    }
                    else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                    {
                        lbVanDungCmHead.Text = sltItem;
                        addImgVanDungCm("vanDungCh" + (selectedIndex + 1).ToString() + ".jpg");
                        lbVanDungAnsCm.Text = "Đáp Án Cho Câu Hỏi : ";
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addImgVanDungCm(string StrNameImg)
        {
            string strVideoPath = "";
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                 strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\nhc\" + StrNameImg;
            }
            else if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
            {
                 strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\gom\vanDung\" + StrNameImg;
            }
            
            picVanDungCm.Image = Image.FromFile(strVideoPath);
            picVanDungCm.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btVanDungCmA1_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                if (lbVanDungCmHead.Text == "Để ghi nhớ công lao của Nguyễn Hữu Cảnh, học sinh chúng ta nên làm gì?")
                {
                    strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhCongLao1");
                    lbVanDungCmAns1.Text = strfeature;
                }
                else if (lbVanDungCmHead.Text == "Hãy chia sẻ với các bạn về một nhân vật lịch sử – văn hoá ở địa phương em đang sinh sống.")
                {
                    strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDanhNhan1");
                    lbVanDungCmAns1.Text = strfeature;
                }
            }
        }

        private void btVanDungCmA2_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                if (lbVanDungCmHead.Text == "Để ghi nhớ công lao của Nguyễn Hữu Cảnh, học sinh chúng ta nên làm gì?")
                {
                    strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhCongLao2");
                    lbVanDungCmAns2.Text = strfeature;
                }
                else if (lbVanDungCmHead.Text == "Hãy chia sẻ với các bạn về một nhân vật lịch sử – văn hoá ở địa phương em đang sinh sống.")
                {
                    strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDanhNhan2");
                    lbVanDungCmAns2.Text = strfeature;
                }
            }
        }

        private void btVanDungCmA3_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                if (lbVanDungCmHead.Text == "Để ghi nhớ công lao của Nguyễn Hữu Cảnh, học sinh chúng ta nên làm gì?")
                {
                    strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhCongLao3");
                    lbVanDungCmAns3.Text= strfeature;
                }
                else if (lbVanDungCmHead.Text == "Hãy chia sẻ với các bạn về một nhân vật lịch sử – văn hoá ở địa phương em đang sinh sống.")
                {
                    strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDanhNhan3");
                    lbVanDungCmAns3.Text = strfeature;
                }
            }
        }

        private void btVanDungCmA4_Click(object sender, EventArgs e)
        {
            if (lbcap.Text == "Nguyễn Hữu Cảnh")
            {
                if (lbVanDungCmHead.Text == "Để ghi nhớ công lao của Nguyễn Hữu Cảnh, học sinh chúng ta nên làm gì?")
                {
                    strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhCongLao4");
                    lbVanDungCmAns4.Text = strfeature;
                }
                else if (lbVanDungCmHead.Text == "Hãy chia sẻ với các bạn về một nhân vật lịch sử – văn hoá ở địa phương em đang sinh sống.")
                {
                    strfeature = iniConfig.readIni(iniPathC, "bai2", "nguyenHuuCanhDanhNhan4");
                    lbVanDungCmAns4.Text = strfeature;
                }
            }
        }
        public void clearVanDungcm()
        {
            lbVanDungCmAns1.Text = "";
            lbVanDungCmAns2.Text = "";
            lbVanDungCmAns3.Text = "";
            lbVanDungCmAns4.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btVanDungCmVid_Click(object sender, EventArgs e)
        {
            try
            {
                commonVideoPlayer newF = new commonVideoPlayer();
                newF.Show();
                string strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\nhc\danhNhanVid";

                foreach (string item in Directory.GetFiles(strVideoPath))
                {
                    string temp = item.Substring(item.LastIndexOf("\\") + 1);
                    string verName = Path.GetFileName(item);
                    newF.listVideoCommon.Items.Add(verName);
                    //lvVideo.Items.Add(verName);

                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btVanDungCmImg_Click(object sender, EventArgs e)
        {
            try
            {
                showImage newF = new showImage();
                newF.Show();
                newF.lbCapMoi.Text = lbcap.Text;
                newF.lbCap.Text = "danhNhan";
                string strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\nhc\danhNhan";

                foreach (string item in Directory.GetFiles(strVideoPath))
                {
                    string temp = item.Substring(item.LastIndexOf("\\") + 1);
                    string verName = Path.GetFileName(item);
                    newF.myList.Items.Add(verName);
                    //lvVideo.Items.Add(verName);

                }
            }
            catch(Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbKpCm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbKpCm.Text == "Hoạt Động 1")
                {
                    lvKpCm.Items.Clear();
                    lvKpCm.Items.Add("Nghề gốm mĩ nghệ Biên Hoà được hình thành từ khi nào ? Ở đâu?");
                    lvKpCm.Items.Add("Kể tên các sản phẩm của nghề gốm mĩ nghệ Biên Hoà.");
                }
                else if (cbKpCm.Text == "Hoạt Động 2")
                {
                    //Em hãy cho biết các bước cơ bản để làm nên một
                    //sản phẩm gốm Biên Hoà
                    lvKpCm.Items.Clear();
                    lvKpCm.Items.Add("Em hãy cho biết các bước cơ bản để làm nên một sản phẩm gốm Biên Hoà");
                }
            }
            catch(Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lvKpCm_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                
                for (int i = 0; i < lvKpCm.SelectedItems.Count; i++)
                {
                    clearVdCmAns();
                    //clearAnswer();
                    //clearVanDungcm();
                    string sltItem = lvKpCm.SelectedItems[i].Text;
                    lbKpCmHd.Text = sltItem;
                    string StrFolder = "";
                    string strName = "";
                    string strSubFolder = "";
                    if (cbKpCm.Text == "Hoạt Động 1")
                    {
                        StrFolder = "hd1";
                        if (lbKpCmHd.Text == "Nghề gốm mĩ nghệ Biên Hoà được hình thành từ khi nào ? Ở đâu?")
                        {
                            strSubFolder = "ch1";
                            strName = "hd1G" + (i + 1).ToString();
                        }
                        else
                        {
                            strSubFolder = "ch2";
                            strName = "hd1C2G" + (i + 1).ToString();
                        }

                    }
                    else if (cbKpCm.Text == "Hoạt Động 2")
                    {
                        StrFolder = "hd2";
                        strName = "quiTrinh";
                    }
                    addImgKpCm(strName, StrFolder + @"\" + strSubFolder + @"\");
                    lbKpCmHd2.Text = "Đáp Án Cho Câu Hỏi : ";
                }
            }
            catch(Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void addImgKpCm(string StrNameImg,string strFolder)
        {
            string strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\gom\" + strFolder + @"\" + StrNameImg + ".jpg";
            picKpCmShow.Image = Image.FromFile(strVideoPath);
            picKpCmShow.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void picKpCmShow_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                showImage newF = new showImage();
                newF.Show();
                string StrFolder = "";
                string strSubFolder = "";
                string strVideoPath = "";

                if (cbKpCm.Text == "Hoạt Động 1")
                {
                    StrFolder = "hd1";
                    if (lbKpCmHd.Text == "Nghề gốm mĩ nghệ Biên Hoà được hình thành từ khi nào ? Ở đâu?")
                    {
                        strSubFolder = "ch1";
                    }
                    else
                    {
                        strSubFolder = "ch2";

                    }
                    strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\gom\" + StrFolder + @"\" + strSubFolder + @"\";
                }
                else
                {
                    StrFolder = "hd2";
                    strVideoPath = iniConfig.RelativeToFullPath(@"...") + @"img\gom\" + StrFolder + @"\step";
                }


                foreach (string item in Directory.GetFiles(strVideoPath))
                {
                    string temp = item.Substring(item.LastIndexOf("\\") + 1);
                    string verName = Path.GetFileName(item);
                    newF.myList.Items.Add(verName);
                    newF.lbCap.Text = cbKpCm.Text;
                    newF.lbques.Text = lbKpCmHd.Text;
                    newF.lbCapMoi.Text = lbcap.Text;
                    //lvVideo.Items.Add(verName);

                }
            }
            catch(Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btKpCm1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    if (cbKpCm.Text == "Hoạt Động 2")
                    {
                        lbKpCmA1.Text = iniConfig.readIni(iniPathC, "bai3", "gomChHd2As1");
                    }else if (cbKpCm.Text == "Hoạt Động 1" && lbKpCmHd.Text == "Nghề gốm mĩ nghệ Biên Hoà được hình thành từ khi nào ? Ở đâu?")
                    {
                        lbKpCmA1.Text = iniConfig.readIni(iniPathC, "bai3", "gomCh1Hd1As1");
                    }
                    else
                    {
                        lbKpCmA1.Text = iniConfig.readIni(iniPathC, "bai3", "gomCh2Hd1As1");
                    }
                }
            }catch(Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKpCm2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    if (cbKpCm.Text == "Hoạt Động 2")
                    {
                        lbKpCmA2.Text = iniConfig.readIni(iniPathC, "bai3", "gomChHd2As2");
                    }
                    else if (cbKpCm.Text == "Hoạt Động 1" && lbKpCmHd.Text == "Nghề gốm mĩ nghệ Biên Hoà được hình thành từ khi nào ? Ở đâu?")
                    {
                        lbKpCmA2.Text = iniConfig.readIni(iniPathC, "bai3", "gomCh1Hd1As2");
                    }
                    else
                    {
                        lbKpCmA2.Text = iniConfig.readIni(iniPathC, "bai3", "gomCh2Hd1As2");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbKpCm3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    if (cbKpCm.Text == "Hoạt Động 2")
                    {
                        lbKpCmA3.Text = iniConfig.readIni(iniPathC, "bai3", "gomChHd2As3");
                    }
                    else if (cbKpCm.Text == "Hoạt Động 1" && lbKpCmHd.Text == "Nghề gốm mĩ nghệ Biên Hoà được hình thành từ khi nào ? Ở đâu?")
                    {
                        lbKpCmA3.Text = iniConfig.readIni(iniPathC, "bai3", "gomCh1Hd1As3");
                    }
                    else
                    {
                        lbKpCmA3.Text = iniConfig.readIni(iniPathC, "bai3", "gomCh2Hd1As3");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbKpCm4_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbcap.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    if (cbKpCm.Text == "Hoạt Động 2")
                    {
                        lbKpCmA4.Text = iniConfig.readIni(iniPathC, "bai3", "gomChHd2As4");
                    }
                    else if (cbKpCm.Text == "Hoạt Động 1" && lbKpCmHd.Text == "Nghề gốm mĩ nghệ Biên Hoà được hình thành từ khi nào ? Ở đâu?")
                    {
                        lbKpCmA4.Text = iniConfig.readIni(iniPathC, "bai3", "gomCh1Hd1As4");
                    }
                    else
                    {
                        lbKpCmA4.Text = iniConfig.readIni(iniPathC, "bai3", "gomCh2Hd1As4");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearVdCmAns()
        {
            lbKpCmA1.Text = "";
            lbKpCmA2.Text = "";
            lbKpCmA3.Text = "";
            lbKpCmA4.Text = "";
        }
    }
}
