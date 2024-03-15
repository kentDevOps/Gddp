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
    }
}
