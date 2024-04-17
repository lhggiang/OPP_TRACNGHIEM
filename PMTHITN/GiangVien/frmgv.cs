using PMTHITN.GiangVien.Quanly;
using PMTHITN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN
{
    public partial class frmgv : Form
    {
        Form _previous;
        private Form currentFormChild;
        string MaGV = "";
   
        public frmgv(Form previous,string maGV)
        {
            InitializeComponent();
            _previous = previous;
            MaGV = maGV;
            HienThiThongTinGV();
            HienThiLichSuThi();
        }
        public void OpenChildForm(Form childForm, Panel panel)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_control.SelectedTab != null && tab_control.SelectedTab.Controls.Count > 0)
            {
                // Kiểm tra xem Control đầu tiên trong tab có phải là TabControl không
                if (tab_control.SelectedTab.Controls[0] is TabControl)
                {
                    // Tắt chế độ toàn màn hình của Form chứa TabControl
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void pic_monhoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmqlmonhoc(pn_monhoc, this), pn_contentquanly);
            pn_monhoc.BackColor = Color.Gray;
            pn_lophoc.BackColor = Color.FromArgb(255, 108, 56);
            pn_kiemtra.BackColor = Color.FromArgb(255, 108, 56);
            pn_nhcauhoi.BackColor = Color.FromArgb(255, 108, 56);
        }

        private void pic_lophoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmqllophoc(pn_lophoc, this, MaGV), pn_contentquanly);
            pn_lophoc.BackColor = Color.Gray;
            pn_monhoc.BackColor = Color.FromArgb(255, 108, 56);
            pn_kiemtra.BackColor = Color.FromArgb(255, 108, 56);
            pn_nhcauhoi.BackColor = Color.FromArgb(255, 108, 56);
        }

        private void pic_kiemtra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmqlbaikiemtra(pn_kiemtra, this, MaGV), pn_contentquanly);
            pn_kiemtra.BackColor = Color.Gray;
            pn_monhoc.BackColor = Color.FromArgb(255, 108, 56);
            pn_lophoc.BackColor = Color.FromArgb(255, 108, 56);
            pn_nhcauhoi.BackColor = Color.FromArgb(255, 108, 56);
        }

        private void pic_lskiemtra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmqlnhcauhoi(pn_nhcauhoi, this), pn_contentquanly);
            pn_nhcauhoi.BackColor = Color.Gray;
            pn_monhoc.BackColor = Color.FromArgb(255, 108, 56);
            pn_lophoc.BackColor = Color.FromArgb(255, 108, 56);
            pn_kiemtra.BackColor = Color.FromArgb(255, 108, 56);
        }

        private void btn_giangvien_Click(object sender, EventArgs e)
        {
            List<GV> danhSachGiangVien = ThaoTacFile.ReadJsonFromFile<GV>("GiangVien.json");
            bool check = false;
            foreach(GV giangvien in danhSachGiangVien)
            {
                if(giangvien.Ma == MaGV)
                {
                    if(giangvien.MatKhau == txt_matkhaucu.Text)
                    {
                        giangvien.MatKhau = txt_matkhaumoi.Text;
                        ThaoTacFile.WriteJsonToFile(danhSachGiangVien, "GiangVien.json");
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            _previous.Show();
        }

        private void btn_exitlskiemtra_Click(object sender, EventArgs e)
        {
            this.Close();
            _previous.Show();
        }

        private void btn_exitinfogv_Click(object sender, EventArgs e)
        {
            this.Close();
            _previous.Show();
        }

        private void dgv_lskiemtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void HienThiLichSuThi()
        {
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");
            //mã đề thi của các lớp GV dạy
            List<string> danhSachDeThi = new List<string>();
            foreach (Lop lop in danhSachLop)
            {
                if (lop.MaGV == MaGV)
                {
                    danhSachDeThi.AddRange(lop.DanhSachDeThi);
                }
            }
            List<DeThi> danhSachTatCaDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            List<DeThi> danhSachDeThiHienThi = new List<DeThi>();
            foreach (DeThi dethi in danhSachTatCaDeThi)
            {
                if (danhSachDeThi.Contains(dethi.MaDT))
                {
                    danhSachDeThiHienThi.Add(dethi);
                }
            }
            dgv_lskiemtra.DataSource = danhSachDeThiHienThi;
        }
        private void HienThiThongTinGV()
        {
            List<GV> danhSachGiangVien = ThaoTacFile.ReadJsonFromFile<GV>("GiangVien.json");
            if (danhSachGiangVien != null && danhSachGiangVien.Count > 0)
            {
                foreach (GV giangVien in danhSachGiangVien)
                {
                    if (giangVien.Ma==MaGV)
                    {
                        txt_mgv.Text = giangVien.Ma;
                        txt_name.Text = giangVien.Ten;
                        txt_taikhoan.Text = giangVien.Email;
                        txt_matkhau.Text = giangVien.MatKhau;
                        txt_khoa.Text = giangVien.Khoa.TenKhoa;
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
    }

}
