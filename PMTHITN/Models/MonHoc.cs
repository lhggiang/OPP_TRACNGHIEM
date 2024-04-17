using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PMTHITN.Models
{
    [Serializable]
    public class MonHoc : ISerializable
    {
        private string maMH;
        private string tenMH;
        private List<CauHoi> nganHangCauHoi;
        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        public string TenMH
        {
            get { return tenMH; }
            set { tenMH = value; }
        }
        public List<CauHoi> NganHangCauHoi
        {
            get { return nganHangCauHoi; }
            set { nganHangCauHoi = value; }
        }
        public MonHoc()
        {
            NganHangCauHoi = new List<CauHoi>();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaMH", MaMH);
            info.AddValue("TenMH", TenMH);
            info.AddValue("NganHangCauHoi", JsonConvert.SerializeObject(NganHangCauHoi));
        }

        public MonHoc(SerializationInfo info, StreamingContext context)
        {
            MaMH = info.GetString("MaMH");
            TenMH = info.GetString("TenMH");
            NganHangCauHoi = JsonConvert.DeserializeObject<List<CauHoi>>(info.GetString("NganHangCauHoi"));
        }


        public MonHoc LayMonHocTheoMa(List<MonHoc> danhSachMonHoc, string maMH)
        {
            foreach (MonHoc monHoc in danhSachMonHoc)
            {
                if (monHoc.MaMH == maMH)
                {
                    return monHoc;
                }
            }
            return null;
        }
    }
}
