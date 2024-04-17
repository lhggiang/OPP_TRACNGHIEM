using Newtonsoft.Json;
using PMTHITN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace PMTHITN.GiangVien.Quanly
{
    public partial class frmbangdiem : Form
    {
        Form _parent;
        string _maDT;
        public frmbangdiem(Form parent, string maDT)
        {
            InitializeComponent();
            _maDT = maDT;
            _parent = parent;
            HienThiDiem();
        }

        private void HienThiDiem()
        {
            if (_maDT != null) 
            {
                List<DeThi> dsDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
                foreach(DeThi dethi in dsDeThi)
                {
                    if(dethi.MaDT == _maDT)
                    {
                        dgv_bangdiem.DataSource = dethi.DanhSachKetQua;
                    }
                }
            }
        }
        private void lbl_backnd_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            string excelFilePath = "BangDiem" +_maDT + ".xlsx";

            List<DeThi> danhsachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            DeThi dethi = new DeThi();
            foreach(DeThi dt in danhsachDeThi)
            {
                if(dt.MaDT == _maDT)
                {
                    dethi = dt;
                    break;
                }
            }
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            // Tạo một file Excel mới
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một sheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Data");

                // Tiêu đề cột
                worksheet.Cells[1, 1].Value = "MaKQ";
                worksheet.Cells[1, 2].Value = "MaSV";
                worksheet.Cells[1, 3].Value = "Diem";
                worksheet.Cells[1, 4].Value = "ThoiGianNop";

                // Dữ liệu từ JSON
                int row = 2;
                foreach (var ketQua in dethi.DanhSachKetQua)
                {
                    worksheet.Cells[row, 1].Value = ketQua.MaKQ;
                    worksheet.Cells[row, 2].Value = ketQua.MaSV;
                    worksheet.Cells[row, 3].Value = ketQua.diem;
                    worksheet.Cells[row, 4].Value = ketQua.ThoiGianNop;
                    row++;
                }

                // Lưu file Excel
                FileInfo excelFile = new FileInfo(excelFilePath);
                excelPackage.SaveAs(excelFile);
            }

            MessageBox.Show("Xuất file Excel thành công!");
        }

        public class JsonData
        {
            public int MaKQ { get; set; }
            public string MaSV { get; set; }
            public List<KetQua> Ketqua { get; set; }
            public int Diem { get; set; }
            public string ThoiGianNop { get; set; }
        }
    }
}
