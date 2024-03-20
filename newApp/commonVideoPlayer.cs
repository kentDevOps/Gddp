using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace newApp
{
    public partial class commonVideoPlayer : Form
    {
        public commonVideoPlayer()
        {
            InitializeComponent();
        }
        public ListView listVideoCommon
        {
            get { return lvVideoCommon; }
            set { lvVideoCommon = value; }
        }
        public AxWindowsMediaPlayer mediaCommon
        {
            get { return mediaPlayerCommon; }
            set { mediaPlayerCommon = value; }
        }
        public Label lbCap
        {
            get { return lbCapMedia; }
            set { lbCapMedia = value; }
        }
        string iniPathC = iniConfig.RelativeToFullPath(@"...") + @"config.ini";
        private void lvVideoCommon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strVideoPath = "";
                if (lbCapMedia.Text== "Nguyễn Hữu Cảnh")
                {
                    strVideoPath = iniConfig.readIni(iniPathC, "bai2", "videoVanDungPath");
                }
                else if (lbCapMedia.Text == "Nghề Gốm Mĩ Nghệ Biên Hoà")
                {
                    strVideoPath = iniConfig.readIni(iniPathC, "bai3", "videoVanDungPath");
                }
                else if (lbCapMedia.Text == "Bưởi Tân Triều")
                {
                    strVideoPath = iniConfig.readIni(iniPathC, "bai4", "videoVanDungPath");
                }

                    int crrIndex = lvVideoCommon.SelectedIndices[0];
                string sltName = lvVideoCommon.SelectedItems[crrIndex].Text;
                mediaPlayerCommon.URL = strVideoPath + @"\" + sltName;
            }
            catch(Exception ex)
            {
                ErrorLog.LogExport(ex.ToString());
                MessageBox.Show(ex.ToString(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }
    }
}
