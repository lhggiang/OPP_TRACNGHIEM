using PMTHITN.Models;
using PMTHITN.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN
{
    public partial class frminfo : Form
    {
        Form _parent;
        string MaSV = "";
        string TenSV = "";
        string TenMH = "";
        string SoLuongCauHoi = "";
        string ThoiGianThi = "";
        string MaDT = "";
        public frminfo(Form parent, string maDT, string maSV, string tenSV, string tenMH , string soLuongCauHoi, string thoiGianThi)
        {
            InitializeComponent();
            _parent = parent;
            MaSV = maSV;
            TenSV = tenSV;
            TenMH = tenMH;
            SoLuongCauHoi = soLuongCauHoi;
            MaDT = maDT;
            ThoiGianThi = thoiGianThi;
            lblhoten.Text = tenSV;
            lblmsv.Text = maSV;
            lblmonthi.Text = tenMH;
            lblsocau.Text = soLuongCauHoi;
            lblthoigian.Text = thoiGianThi;
        }

        private void frminfo_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btnvaothi_Click(object sender, EventArgs e)
        {
            frmbaithi frm = new frmbaithi(this, MaDT,MaSV,TenSV,TenMH,SoLuongCauHoi,ThoiGianThi);
            frm.Show();
            this.Hide();
        }
    }
}
