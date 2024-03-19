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
    }
}
