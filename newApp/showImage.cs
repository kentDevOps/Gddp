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
    }
}
