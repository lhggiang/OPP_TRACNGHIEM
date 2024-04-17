using PMTHITN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PMTHITN
{
    public partial class frmlogin : Form
    {
        bool _flag;
        Form _previous;
        string maGV = "";
        string maSV = "";
        string tenSV = "";

        #region Slide
        private int currentIndex = 0;
        private Timer timer;
        private List<Image> imagePaths = new List<Image>
        {
            Properties.Resources.image1,
            Properties.Resources.image2,
            Properties.Resources.image3,
        };
        private void InitializeSlideshow()
        {
            // Khởi tạo Timer với interval là 4000 milliseconds (4 giây).
            timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += timer_slideanh_Tick; // Gắn sự kiện Tick cho timer.

            // Hiển thị hình ảnh đầu tiên khi form được khởi động.
            DisplayCurrentImage();

            // Bắt đầu slideshow.
            timer.Start();
        }
        private void timer_slideanh_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Count;
            DisplayCurrentImage();
        }

        private void DisplayCurrentImage()
        {

            Image image = imagePaths[currentIndex];
            pic_slideanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_slideanh.Image = image;
        }
        #endregion

        public frmlogin(bool flag, Form previous)
        {
            InitializeComponent();
            InitializeSlideshow();
            _flag = flag;
            _previous = previous;
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            _previous.Show();
            this.Close();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (_flag == true)
            {
                List<GV> danhSachGiangVien = ThaoTacFile.ReadJsonFromFile<GV>("GiangVien.json");
                bool dangNhapThanhCong = false;        
                foreach (GV giangvien in danhSachGiangVien)
                {
                    if (giangvien.Email == txt_taikhoan.Text && giangvien.MatKhau == txt_matkhau.Text)
                    {
                        dangNhapThanhCong = true;
                        maGV = giangvien.Ma;
                        break;
                    }
                }
                if (dangNhapThanhCong)
                {
                    frmgv frm = new frmgv(this,maGV);
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu.");
                }
            }
            else
            {
                List<SV> danhSachSinhVien = ThaoTacFile.ReadJsonFromFile<SV>("SinhVien.json");
                bool dangNhapThanhCong = false;

                foreach (SV sinhvien in danhSachSinhVien)
                {
                    if (sinhvien.Email == txt_taikhoan.Text && sinhvien.MatKhau == txt_matkhau.Text)
                    {
                        dangNhapThanhCong = true;
                        maSV = sinhvien.Ma;
                        tenSV = sinhvien.Ten;
                        break;
                    }
                }
                if (dangNhapThanhCong)
                {
                    frmsv frm = new frmsv(this,maSV, tenSV);
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu.");
                }
            }
        }

        private void linklbl_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_flag == true)
            {
                frmquenmk frm = new frmquenmk(maGV);
                frm.ShowDialog();
            }
            else
            {
                frmquenmk frm = new frmquenmk();
                frm.ShowDialog();
            }
        }
    }
}
