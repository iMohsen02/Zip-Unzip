using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeZip
{
    public partial class frmInfo : Form
    {

        public string spath { get; set; }

        public string dpath { get; set; }

        public string ptxt { get; set; }

        public string TypeDo { get; set; }

        public frmInfo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTimeDate.Text = DateTime.Now.ToString("yyyy/mm/dd    hh:mm:ss");

            lblSourceTxt.Text = spath;
            lblDestinationtxt.Text = dpath;
            lblPasstxt.Text = ptxt;
            lblTypetxt.Text = TypeDo;
            lbltime.Text ="Modified: "+ DateTime.Now.ToString("yyyy/mm/dd    hh:mm:ss");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = DateTime.Now.ToString("yyyy/mm/dd    hh:mm:ss");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }
    }
}
