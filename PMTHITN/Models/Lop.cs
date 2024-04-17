using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    [Serializable]
    public class Lop : LopBase, ISerializable
    {
        private string maLop;
        private string tenLop;
        private string maGV;
        private List<string> danhSachSinhVien;
        private List<string> danhSachDeThi;

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        public List<string> DanhSachSinhVien
        {
            get { return danhSachSinhVien; }
            set { danhSachSinhVien = value; }
        }
        public List<string> DanhSachDeThi
        {
            get { return danhSachDeThi; }
            set { danhSachDeThi = value; }
        }

        public Lop()
        {
            DanhSachSinhVien = new List<string>();
            DanhSachDeThi = new List<string>();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaLop", MaLop);
            info.AddValue("TenLop", TenLop);
            info.AddValue("MaGV", MaGV);
            info.AddValue("DanhSachSinhVien", JsonConvert.SerializeObject(DanhSachSinhVien));
            info.AddValue("DanhSachDeThi", JsonConvert.SerializeObject(DanhSachDeThi));
        }

        public Lop(SerializationInfo info, StreamingContext context)
        {
            MaLop = info.GetString("MaLop");
            TenLop = info.GetString("TenLop");
            MaGV = info.GetString("MaGV");
            DanhSachSinhVien = JsonConvert.DeserializeObject<List<string>>(info.GetString("DanhSachSinhVien"));
            DanhSachDeThi = JsonConvert.DeserializeObject<List<string>>(info.GetString("DanhSachDeThi"));
        }

        public override void ThemDeThi(string deThi)
        {
            DanhSachDeThi.Add(deThi);
        }

        public override List<string> getDanhSachDeThi(string MaLop)
        {
            return DanhSachDeThi;
        }
    }
}
