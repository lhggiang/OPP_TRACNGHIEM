using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN
{
    public partial class frmHome : Form
    {
        private bool flag = true;
        public frmHome()
        {
            InitializeComponent();
        }

        private void btn_giangvien_Click(object sender, EventArgs e)
        {
            this.flag = true;
            frmlogin frm = new frmlogin(this.flag, this);
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_sinhvien_Click(object sender, EventArgs e)
        {
            this.flag = false;
            frmlogin frm = new frmlogin(this.flag, this);
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
