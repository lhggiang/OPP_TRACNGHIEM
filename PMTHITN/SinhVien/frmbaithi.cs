using PMTHITN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN.SinhVien
{
    public partial class frmbaithi : Form
    {
        Form _parent;
        List<datatest> baithi = new List<datatest>();
        string MaSV = "";
        string TenSV = "";
        string TenMH = "";
        string SoLuongCauHoi = "";
        string ThoiGianThi = "";
        string MaDT = "";
        KetQua ketqua;
        private int remainingMinutes;
        private int remainingSeconds;
        public frmbaithi(Form parent, string maDT, string maSV, string tenSV, string tenMH, string soLuongCauHoi, string thoiGianThi)
        {
            InitializeComponent();
            _parent = parent;
            MaSV = maSV;
            TenSV = tenSV;
            TenMH = tenMH;
            MaDT = maDT;
            SoLuongCauHoi = soLuongCauHoi;
            ThoiGianThi = thoiGianThi;
            lblmsv.Text = maSV;
            lblhoten.Text = tenSV;
            lblmonthi.Text = tenMH;
            lblsocau.Text = soLuongCauHoi;
            lblthoigian.Text = thoiGianThi + " phút";
            ketqua = new KetQua(maSV, int.Parse(soLuongCauHoi));
            AddData();
        }
        void AddData() // Tải data câu hỏi từ frm này => Sang datatest
        {
            List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            List<string> danhSachCauHoi = new List<string>();
            foreach(DeThi dethi in danhSachDeThi)
            {
                if(dethi.MaDT == MaDT)
                {
                    danhSachCauHoi.AddRange(dethi.DanhSachCauHoi);
                }
            }
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            List<CauHoi> danhSachCauHoiCuaBaiTest = new List<CauHoi>();
            foreach (MonHoc monhoc in danhSachMonHoc)
            {
                if (monhoc.TenMH == TenMH)
                {
                    foreach (CauHoi cauhoi in monhoc.NganHangCauHoi)
                    {
                        if (danhSachCauHoi.Contains(cauhoi.MaCH))
                        {
                            danhSachCauHoiCuaBaiTest.Add(cauhoi);
                }
                    }
                }
            }
            int count = 0;
            foreach (CauHoi cauhoi in danhSachCauHoiCuaBaiTest)
            {
                ketqua.Ketqua[count] = new BaiLam();
                ketqua.Ketqua[count].CauHoi = cauhoi;
                ++count;
                baithi.Add(new datatest(pn_cauhoi, flpn_socau, cauhoi.NoiDung, count, ketqua.Ketqua[count - 1]));
            }
            //baithi.Add(new datatest(pn_cauhoi, flpn_socau, false, false, true, false, "Nội dung cau 1", 1));
            //baithi.Add(new datatest(pn_cauhoi, flpn_socau, false, false, false, true, "Nội dung cau 2", 2));
            //baithi.Add(new datatest(pn_cauhoi, flpn_socau, false, false, false, true, "Nội dung cau 3", 3));
            //baithi.Add(new datatest(pn_cauhoi, flpn_socau, false, false, false, true, "Nội dung cau 4", 4));
            
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;

            if (remainingSeconds < 0)
            {
                remainingMinutes--;
                remainingSeconds = 59; 
            }

            if (remainingMinutes < 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết thời gian!");
                return;
            }

            UpdateTimeDisplay();
        }
        private void frmbaithi_Load(object sender, EventArgs e)
        {
            remainingMinutes = int.Parse(ThoiGianThi); 
            remainingSeconds = 0;

            UpdateTimeDisplay();

            timer1.Interval = 2000; 
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

    
        private void UpdateTimeDisplay()
        {
            // Hiển thị thời gian còn lại trên Label hoặc TextBox nào đó trên giao diện
            lblphut.Text = $"{remainingMinutes:00}:{remainingSeconds:00}";
        }

        private void btn_nopbai_Click(object sender, EventArgs e)
        {
            ketqua.ThoiGianNop = DateTime.Now.ToString();
            ketqua.TinhDiem();
            ThaoTacFile.WriteJsonToConstantFile<KetQua>(ketqua, "KetQua.json");
            List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            foreach (DeThi dethi in danhSachDeThi)
            {
                if (dethi.MaDT == MaDT)
                {
                    dethi.DanhSachKetQua.Add(ketqua);
                    break;
                }
            }
            ThaoTacFile.WriteJsonToFile<DeThi>(danhSachDeThi, "DeThi.json");
            this.Close();
            _parent.Show();
        }
    }
}
