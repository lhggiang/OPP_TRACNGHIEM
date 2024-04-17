using PMTHITN.GiangVien.Quanly;
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
using System.Xml.Linq;

namespace PMTHITN
{
    public partial class frmsv : Form
    {
        Form _previous;
        string MaSV = "";
        string TenSV = "";
        public frmsv(Form previous, string maSV, string tenSV)
        {
            InitializeComponent();
            _previous = previous;
            MaSV = maSV;
            TenSV = tenSV;
            HienThiThongTinSV();
            AddDataTest();
            HienThiLichSuThi();
        }

        void AddDataTest()
        {
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");
            List<string> danhSachMaDeThi = new List<string>();
            foreach(Lop lop in danhSachLop)
            {
                if (lop.DanhSachSinhVien.Contains(MaSV))
                {
                    danhSachMaDeThi.AddRange(lop.DanhSachDeThi);
                }
            }
            List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            List<DeThi> danhSachDeThiHienThi = new List<DeThi>();
            foreach (DeThi dethi in danhSachDeThi)
            {
                if (danhSachMaDeThi.Contains(dethi.MaDT))
                {
                    danhSachDeThiHienThi.Add(dethi);
                }
            }
            dgv_dsbaikiemtra.DataSource = danhSachDeThiHienThi;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
            _previous.Show();
        }

        private void dgv_dsbaikiemtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_dsbaikiemtra.Rows[e.RowIndex];
                string MaDT = row.Cells["MaDT"].Value.ToString(); 
                string TenMH = row.Cells["TenMH"].Value.ToString();
                int ThoiGianThi = int.Parse(row.Cells["ThoiGianThi"].Value.ToString());
                int SoLuongCauHoi = int.Parse(row.Cells["SoLuongCauHoi"].Value.ToString());
                //string ThoiGianLamBai = row.Cells["ThoiGianLamBai"].Value.ToString();
                frminfo frminfo = new frminfo(this,MaDT, MaSV, TenSV, TenMH , SoLuongCauHoi.ToString(), ThoiGianThi.ToString());
                frminfo.Show();
                this.Hide();
            }
        }

        private void dgv_lskiemtra_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_lskiemtra.Rows[e.RowIndex];
                string MaDT = row.Cells["MaDT"].Value.ToString();
                frmbangdiem frmbangdiem = new frmbangdiem(this, MaDT);
                frmbangdiem.Show();
                this.Hide();
            }
        }

        private void btn_exitlskiemtra_Click_1(object sender, EventArgs e)
        {
            this.Close();
            _previous.Show();
        }

        private void btn_exittt_Click(object sender, EventArgs e)
        {
            this.Close();
            _previous.Show();
        }

        private void HienThiLichSuThi()
        {
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");
            List<string> danhSachMaDeThi = new List<string>();
            foreach (Lop lop in danhSachLop)
            {
                if (lop.DanhSachSinhVien.Contains(MaSV))
                {
                    danhSachMaDeThi.AddRange(lop.DanhSachDeThi);
                }
            }
            List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            List<DeThi> danhSachDeThiHienThi = new List<DeThi>();
            foreach (DeThi dethi in danhSachDeThi)
            {
                if (danhSachMaDeThi.Contains(dethi.MaDT))
                {
                    danhSachDeThiHienThi.Add(dethi);
                }
            }
            dgv_lskiemtra.DataSource = danhSachDeThiHienThi;
        }

        private void HienThiThongTinSV()
        {
            List<SV> danhSachSinhVien = ThaoTacFile.ReadJsonFromFile<SV>("SinhVien.json");
            if (danhSachSinhVien != null && danhSachSinhVien.Count > 0)
            {
                foreach (SV sinhVien in danhSachSinhVien)
                {
                    if (sinhVien.Ma == MaSV)
                    {
                        txt_mssv.Text = sinhVien.Ma;
                        txt_ten.Text = sinhVien.Ten;
                        txt_taikhoan.Text = sinhVien.Email;
                        txt_matkhau.Text = sinhVien.MatKhau;
                        return;
                    }
                }
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            List<SV> danhSachSinhVien = ThaoTacFile.ReadJsonFromFile<SV>("SinhVien.json");
            bool check = false;
            foreach (SV sinhVien in danhSachSinhVien)
            {
                if (sinhVien.Ma == MaSV)
                {
                    if (sinhVien.MatKhau == txt_matkhaucu.Text)
                    {
                        sinhVien.MatKhau = txt_nhaplai.Text;
                        ThaoTacFile.WriteJsonToFile(danhSachSinhVien, "SinhVien.json");
                        check = true;
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        break;
                    }
                }
            }
            if (check == false)
            {
                MessageBox.Show("Mật khẩu cũ không hợp lệ");
            }
        }
    }
}
