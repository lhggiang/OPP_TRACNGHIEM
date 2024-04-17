using PMTHITN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN.SinhVien
{
    public partial class frmcauhoi : Form
    {
        int thutu;
        string cauhoi;
        BaiLam dachon;
        public frmcauhoi(string cauhoi, int thutu, BaiLam dachon)
        {
            InitializeComponent();
            this.dachon = dachon;
            SetCauHoi(cauhoi, thutu);
        }
        // Phương thức để thiết lập dữ liệu câu hỏi
        public void SetCauHoi(string cauhoi, int thutuBaiLam)
        {
            this.cauhoi = cauhoi;
            this.thutu = thutuBaiLam;
            lbl_debai.Text = this.cauhoi;
            lb_socau.Text = $"Câu: {this.thutu}";
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if(btn.Checked && btn != null)
            {
                dachon.Traloi = btn.Text.Substring(btn.Text.Length -1);
            }
        }
    }
}
