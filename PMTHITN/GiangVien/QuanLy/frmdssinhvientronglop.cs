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

namespace PMTHITN.GiangVien.Quanly
{
    public partial class frmdssinhvientronglop : Form
    {
        Form _parent;
        string MaLop = "";
        public frmdssinhvientronglop(Form parent, string maLop, string tenLop)
        {
            InitializeComponent();
            _parent = parent;
            MaLop = maLop;
            HienThiSinhVienLopHoc();
            txt_malop.Text = maLop;
            txt_tenlop.Text = tenLop;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }
        List<SV> HienThiSinhVienLopHoc()
        {
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");
            List<string> danhSachMaSinhVien = new List<string>();   
            //lấy ra list danh sách MaSV trong lớp
            foreach (Lop lop in danhSachLop)
            {
                if (lop.MaLop == MaLop)
                {
                    danhSachMaSinhVien.AddRange(lop.DanhSachSinhVien);
                }
            }
            //lấy ra tất cả sinh viên
            List<SV> danhSachSinhVien = ThaoTacFile.ReadJsonFromFile<SV>("SinhVien.json");
            List<SV> sinhVienCuaLop = new List<SV>();
            foreach (SV sinhvien in danhSachSinhVien)
            {
                if (danhSachMaSinhVien.Contains(sinhvien.Ma))
                {
                    sinhVienCuaLop.Add(sinhvien);
                }
            }
            dgv_dssinhvien.DataSource = sinhVienCuaLop;
            return sinhVienCuaLop;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            List<SV> danhSachSinhVien = ThaoTacFile.ReadJsonFromFile<SV>("SinhVien.json");
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");
            //List<SV> danhSachSinhVienTrongLop = new List<SV>();

            string MaSV = txt_mssv.Text; 

            foreach (Lop lop in danhSachLop)
            {
                if (lop.MaLop == MaLop)
                {
                    foreach (SV sv in danhSachSinhVien)
                    {
                        if (sv.Ma == MaSV)
                        {
                            lop.DanhSachSinhVien.Add(sv.Ma);
                            ThaoTacFile.WriteJsonToFile(danhSachLop, "Lop.json");
                            break;
                        }
                    }
                }
            }
            foreach (SV sinhvien in danhSachSinhVien)
            {
                if (sinhvien.Ma == MaSV)
                {
                    sinhvien.MaLop.Add(MaLop);
                    ThaoTacFile.WriteJsonToFile(danhSachSinhVien, "SinhVien.json");
                    break;
                }
            }
            dgv_dssinhvien.DataSource = HienThiSinhVienLopHoc();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string MaSV = txt_mssv.Text;
            List<SV> danhSachSinhVien = ThaoTacFile.ReadJsonFromFile<SV>("SinhVien.json");
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");
            foreach (Lop lop in danhSachLop)
            {
                if (lop.MaLop == MaLop)
                {
                    foreach (SV sv in danhSachSinhVien)
                    {
                        if (sv.Ma == MaSV)
                        {
                            lop.DanhSachSinhVien.Remove(sv.Ma);
                            ThaoTacFile.WriteJsonToFile(danhSachLop, "Lop.json");
                            break;
                        }
                    }
                }
            }
            foreach (SV sinhvien in danhSachSinhVien)
            {
                if (sinhvien.Ma == MaSV)
                {
                    sinhvien.MaLop.Remove(MaLop);
                    ThaoTacFile.WriteJsonToFile(danhSachSinhVien, "SinhVien.json");
                    break;
                }
            }
            dgv_dssinhvien.DataSource = HienThiSinhVienLopHoc();
        }
    }
}
