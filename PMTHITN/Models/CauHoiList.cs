using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    public delegate bool KiemTraDieuKien(string MaCH);

    public class CauHoiList : ICauHoiList
    {
        private List<string> danhSachCauHoi;
        public List<string> DanhSachCauHoi
        {
            get { return danhSachCauHoi; }
            set { danhSachCauHoi = value; }
        }
        public CauHoiList(string MaDT)
        {
            danhSachCauHoi = new List<string>();
            List<DeThi> danhSachDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            foreach (DeThi dethi in danhSachDeThi)
            {
                if (dethi.MaDT == MaDT)
                {
                    danhSachCauHoi.AddRange(dethi.DanhSachCauHoi);
                    break;
                }
            }
        }

        //Thêm câu hỏi vào list
        public static CauHoiList operator +(CauHoiList lhs, string MaCH)
        {
            lhs.DanhSachCauHoi.Add(MaCH);
            return lhs;
        }

        // Xóa câu hỏi dựa trên một điều kiện
        public void XoaCauHoi(KiemTraDieuKien dieuKien)
        {
            for (int i = danhSachCauHoi.Count - 1; i >= 0; i--)
            {
                if (dieuKien(danhSachCauHoi[i]))
                {
                    danhSachCauHoi.RemoveAt(i);
                }
            }
        }
    }
}
