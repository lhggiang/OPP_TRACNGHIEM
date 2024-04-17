using PMTHITN.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN.GiangVien.Quanly
{
    public partial class frmtaocauhoi : Form
    {
        Form _parent;
        string MaDT = "";
        string TenMH = "";
        public frmtaocauhoi(Form parent, string maDT, string tenMH)
        {
            InitializeComponent();
            _parent = parent;
            MaDT = maDT;
            TenMH = tenMH;
            AddDataTest();
            AddDataForNHCH();
        }
        void AddDataTest()
        {
            List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            List<string> danhSachCauHoi = new List<string>();
            foreach (DeThi dethi in danhSachDeThi)
            {
                if (dethi.MaDT == MaDT)
                {
                    danhSachCauHoi.AddRange(dethi.DanhSachCauHoi);
                }
            }
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            List<CauHoi> danhSachTatCaCauHoi = new List<CauHoi>();
            List<CauHoi> danhSachCauHoiHienThi = new List<CauHoi>();
            foreach(MonHoc monhoc in danhSachMonHoc)
            {
                if(monhoc.TenMH == TenMH)
                {
                    danhSachTatCaCauHoi.AddRange(monhoc.NganHangCauHoi);
                }
            }       
            foreach (CauHoi cauhoi in danhSachTatCaCauHoi)
            {
                if (danhSachCauHoi.Contains(cauhoi.MaCH))
                {
                    danhSachCauHoiHienThi.Add(cauhoi);
                }
            }
            dgv_dscauhoi.DataSource = danhSachCauHoiHienThi;
        }
        void AddDataForNHCH()
        {
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            List<CauHoi> danhSachTatCaCauHoi = new List<CauHoi>();
            foreach (MonHoc monhoc in danhSachMonHoc)
            {
                if (monhoc.TenMH == TenMH)
                {
                    danhSachTatCaCauHoi.AddRange(monhoc.NganHangCauHoi);
                }
            }
            dgv_nhcauhoi.DataSource = danhSachTatCaCauHoi;
        }
        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btn_themtunhcauhoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgv_nhcauhoi.SelectedCells.Count > 0)
            {
                // Lấy ra chỉ số của hàng được chọn
                int rowIndex = dgv_nhcauhoi.SelectedCells[0].RowIndex;

                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dgv_nhcauhoi.Rows[rowIndex];

                // Lấy dữ liệu từ các ô trong hàng
                string MaCH = selectedRow.Cells["MaCH"].Value.ToString(); 
                string NoiDung = selectedRow.Cells["NoiDung"].Value.ToString();
                string DapAn = selectedRow.Cells["DapAn"].Value.ToString();
                CauHoi cauHoi = new CauHoi(MaCH, NoiDung, DapAn);
                List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
                foreach (DeThi dethi in danhSachDeThi)
                {
                    if (dethi.MaDT == MaDT)
                    {
                        dethi.DanhSachCauHoi.Add(cauHoi.MaCH);
                        ThaoTacFile.WriteJsonToFile(danhSachDeThi, "DeThi.json");
                        break;
                    }
                }
                AddDataTest();
            }
            else
            {
                MessageBox.Show("Không có hàng nào được chọn.");
            }
        }

        string MaCHXoa = "";

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_dscauhoi.SelectedCells.Count > 0)
            {
                // Lấy ra chỉ số của hàng được chọn
                int rowIndex = dgv_dscauhoi.SelectedCells[0].RowIndex;

                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dgv_dscauhoi.Rows[rowIndex];

                // Lấy dữ liệu từ các ô trong hàng
                string MaCH = selectedRow.Cells["MaCH"].Value.ToString();
                MaCHXoa = MaCH;
                //string NoiDung = selectedRow.Cells["NoiDung"].Value.ToString();
                //string DapAn = selectedRow.Cells["DapAn"].Value.ToString();
                //CauHoi cauHoi = new CauHoi(MaCH, NoiDung, DapAn);
                CauHoiList list = new CauHoiList(MaDT);
                list.XoaCauHoi(KiemTraGiaTri);

                List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
                foreach (DeThi dethi in danhSachDeThi)
                {
                    if (dethi.MaDT == MaDT)
                    {
                        dethi.DanhSachCauHoi.Clear();
                        dethi.DanhSachCauHoi.AddRange(list.DanhSachCauHoi);
                        ThaoTacFile.WriteJsonToFile(danhSachDeThi, "DeThi.json");
                        break;
                    }
                }
                AddDataTest();
            }
            else
            {
                MessageBox.Show("Không có hàng nào được chọn.");
            }
        }
        bool KiemTraGiaTri(string MaCH)
        {
            return MaCH.Contains(MaCHXoa);
        }

        private void btn_themngaunhien_Click(object sender, EventArgs e)
        {
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            List<CauHoi> danhSachCauHoi = new List<CauHoi>();
            foreach (MonHoc monhoc in danhSachMonHoc)
            {
                if (monhoc.TenMH == TenMH)
                {
                    danhSachCauHoi.AddRange(monhoc.NganHangCauHoi);
                    break;
                }
            }
            int socau = int.Parse(txt_themngaunhien.Text);
            List<int> selectedIndices = new List<int>();
            Random random = new Random();

            while (selectedIndices.Count < socau)
            {
                int index = random.Next(0, danhSachCauHoi.Count);
                if (!selectedIndices.Contains(index))
                {
                    selectedIndices.Add(index);
                }
            }

            // Thêm các câu hỏi được chọn vào danh sách câu hỏi của bạn hoặc làm điều gì đó với chúng

            List<CauHoi> cauHoiDuocChon = new List<CauHoi>();
            foreach (int index in selectedIndices)
            {
                cauHoiDuocChon.Add(danhSachCauHoi[index]);
            }
            dgv_dscauhoi.DataSource = cauHoiDuocChon;

            List<string> maCauHoiDuocChon = new List<string>();

            foreach (CauHoi cauhoi in cauHoiDuocChon)
            {
                maCauHoiDuocChon.Add(cauhoi.MaCH);
            }

            List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            foreach (DeThi dethi in danhSachDeThi)
            {
                if (dethi.MaDT == MaDT)
                {
                    dethi.DanhSachCauHoi.Clear();
                    dethi.DanhSachCauHoi.AddRange(maCauHoiDuocChon);
                    ThaoTacFile.WriteJsonToFile(danhSachDeThi, "DeThi.json");
                    break;
                }
            }
        }
    }
}
