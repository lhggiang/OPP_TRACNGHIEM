using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    [Serializable]
    public class Khoa : ISerializable
    {
        private string makhoa;
        private string tenkhoa;
        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }

        public string TenKhoa
        {
            get { return tenkhoa; }
            set { tenkhoa = value; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaKhoa", MaKhoa);
            info.AddValue("TenKhoa", TenKhoa);
        }
        public Khoa() { }

        public Khoa(SerializationInfo info, StreamingContext context)
        {
            MaKhoa = info.GetString("MaKhoa");
            TenKhoa = info.GetString("TenKhoa");
        }

    }
}
