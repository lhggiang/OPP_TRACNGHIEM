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

namespace PMTHITN
{
    public partial class frmquenmk : Form
    {
        bool check = true;
        public frmquenmk(string maGV)
        {
            InitializeComponent();
        }
        public frmquenmk()
        {
            InitializeComponent();
            check = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tieptheo_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                List<GV> danhSachGiangVien = ThaoTacFile.ReadJsonFromFile<GV>("GiangVien.json");
                bool emailMatched = false;

                foreach (GV giangvien in danhSachGiangVien)
                {
                    if (giangvien.Email == txt_email.Text)
                    {
                        emailMatched = true;
                        if (txt_mkmoi.Text == txt_confirm.Text)
                        {
                            giangvien.MatKhau = txt_mkmoi.Text;
                            ThaoTacFile.WriteJsonToFile(danhSachGiangVien, "GiangVien.json");
                            this.Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu nhập lại không khớp!");
                            return; 
                        }
                    }
                }
                if (!emailMatched)
                {
                    MessageBox.Show("Email không chính xác!");
                }
            } 
            else
            {
                    List<SV> danhSachSinhVien = ThaoTacFile.ReadJsonFromFile<SV>("SinhVien.json");
                    bool emailMatched = false;

                    foreach (SV sinhvien in danhSachSinhVien)
                    {
                        if (sinhvien.Email == txt_email.Text)
                        {
                            emailMatched = true;
                            if (txt_mkmoi.Text == txt_confirm.Text)
                            {
                                sinhvien.MatKhau = txt_mkmoi.Text;
                                ThaoTacFile.WriteJsonToFile(danhSachSinhVien, "SinhVien.json");
                                this.Close();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                                return; 
                            }
                        }
                    }
                    if (!emailMatched)
                    {
                        MessageBox.Show("Email không chính xác!");
                    }
            }
        }
    }
}
