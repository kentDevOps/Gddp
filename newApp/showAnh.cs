using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace newApp
{
    public partial class showAnh : Form
    {
        
        public showAnh()
        {
            InitializeComponent();

        }
        public PictureBox MyPictureBox
        {
            get { return picShow; }
            set { picShow = value; }
        }
        public Label myCap
        {
            get { return lbTieuDe; }
            set { lbTieuDe = value; }
        }
        public Label myDes1
        {
            get { return lbDes; }
            set { lbDes = value; }
        }
        private void btShow_Click(object sender, EventArgs e)
        {
            string filePath="";
            //doc ket qua
            if (lbTieuDe.Text == "daBaChong") 
            {
                lbDes.Text = "Danh thắng đá Ba Chồng , huyện Định Quán";
                filePath = iniConfig.RelativeToFullPath(@"...") + @"aud\daBaChong.mp3";
                
            }
            else if (lbTieuDe.Text == "triAn")
            {
                filePath = iniConfig.RelativeToFullPath(@"...") + @"aud\triAn.mp3";
                lbDes.Text = "Thủy Điện Trị An , huyện Vĩnh Cửu";
            }
            else if (lbTieuDe.Text == "chuaChan")
            {
                filePath = iniConfig.RelativeToFullPath(@"...") + @"aud\chuaChan.mp3";
                lbDes.Text = "Núi Chứa Chan , Huyện Xuân Lộc - Đồng Nai";
            }
            else if (lbTieuDe.Text == "suoiMo")
            {
                filePath = iniConfig.RelativeToFullPath(@"...") + @"aud\suoiMo.mp3";
                lbDes.Text = "Khu Du Lịch Suối Mơ , Huyện Tân Phú";
            }
            else if (lbTieuDe.Text == "giangDien")
            {
                filePath = iniConfig.RelativeToFullPath(@"...") + @"aud\giangDien.mp3";
                lbDes.Text = "Khu Du Lịch Sinh Thai Thác Giang Điền, Huyện Trảng Bom";
            }
            else if (lbTieuDe.Text == "cuuLong")
            {
                filePath = iniConfig.RelativeToFullPath(@"...") + @"aud\buuLong.mp3";
                lbDes.Text = "Khu Du Lịch Bửu Long, Thành Phố Biên Hòa";
            }
            else if (lbTieuDe.Text == "tanTrieu")
            {
                filePath = iniConfig.RelativeToFullPath(@"...") + @"aud\vinhCuu.mp3";
                lbDes.Text = "Khu Du Lịch Làng Bưởi Tân Triều, Huyện Vĩnh Cửu";
            }
                

            using (var audioFileReader = new AudioFileReader(filePath))
            {
                // Xử lý audioFileReader ở đây, ví dụ: phát audio
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFileReader);
                    outputDevice.Play();

                    // Đợi cho đến khi phát xong
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
