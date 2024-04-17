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
    public class DeThi : ISerializable
    {
        private string maDT;
        private string tenMH;

        private string thoiGianLamBai;
        private int soLuongCauHoi;
        private int thoiGianThi;
        private List<string> danhSachCauHoi;
        private List<KetQua> danhSachKetQua;

        public string MaDT
        {
            get
            {
                return maDT;
            }
            set
            {
                maDT = value;
            }
        }
        public string TenMH
        {
            get
            {
                return tenMH;
            }
            set
            {
                tenMH = value;
            }
        }

        public string ThoiGianLamBai
        {
            get
            {
                return thoiGianLamBai;
            }
            set
            {
                thoiGianLamBai = value;
            }
        }

        public int SoLuongCauHoi
        {
            get
            {
                return soLuongCauHoi;
            }
            set
            {
                soLuongCauHoi = value;
            }
        }

        public int ThoiGianThi
        {
            get
            {
                return thoiGianThi;
            }
            set
            {
                thoiGianThi = value;
            }
        }

        public List<string> DanhSachCauHoi
        {
            get
            {
                return danhSachCauHoi;
            }
            set
            {
                danhSachCauHoi = value;
            }
        }

        public List<KetQua> DanhSachKetQua
        {
            get
            {
                return danhSachKetQua;
            }
            set
            {
                danhSachKetQua = value;
            }
        }
        public DeThi()
        {
            DanhSachCauHoi = new List<string>();
            DanhSachKetQua = new List<KetQua>();
        }

        public DeThi(string maDeThi, string tenMonHoc, int soCau, int thoiGianThi, string thoiGianLamBai)
        {
            MaDT = maDeThi;
            TenMH = tenMonHoc;
            SoLuongCauHoi = soCau;
            ThoiGianThi = thoiGianThi;
            ThoiGianLamBai = thoiGianLamBai;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaDT", MaDT);
            info.AddValue("TenMH", TenMH);
            info.AddValue("ThoiGianLamBai", ThoiGianLamBai);
            info.AddValue("SoLuongCauHoi", SoLuongCauHoi);
            info.AddValue("ThoiGianThi", ThoiGianThi);
            info.AddValue("DanhSachCauHoi", JsonConvert.SerializeObject(DanhSachCauHoi));
            info.AddValue("DanhSachKetQua", JsonConvert.SerializeObject(DanhSachKetQua));
        }

        public DeThi(SerializationInfo info, StreamingContext context)
        {
            MaDT = info.GetString("MaDT");
            TenMH = info.GetString("TenMH");
            ThoiGianLamBai = info.GetString("ThoiGianLamBai");
            SoLuongCauHoi = info.GetInt32("SoLuongCauHoi");
            ThoiGianThi = info.GetInt32("ThoiGianThi");
            DanhSachCauHoi = JsonConvert.DeserializeObject<List<string>>(info.GetString("DanhSachCauHoi"));
            DanhSachKetQua = (List<KetQua>)info.GetValue("DanhSachKetQua", typeof(List<KetQua>));
        }
    }
}
