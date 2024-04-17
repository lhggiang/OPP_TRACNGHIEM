using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    [Serializable]
    public class CauHoi : ISerializable
    {
        private string maCH;
        private string noiDung;
        private string dapAn;

        public string MaCH
        {
            get { return maCH; }
            set { maCH = value; }
        }
        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }
        public string DapAn
        {
            get { return dapAn; }
            set { dapAn = value; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaCH", MaCH);
            info.AddValue("NoiDung", NoiDung);
            info.AddValue("DapAn", DapAn);
        }
        public CauHoi() { }

        public CauHoi(SerializationInfo info, StreamingContext context)
        {
            MaCH = info.GetString("MaCH");
            NoiDung = info.GetString("NoiDung");
            DapAn = info.GetString("DapAn");
        }

        public CauHoi(string _maCH, string _noiDung, string _dapAn)
        {
            maCH = _maCH;
            noiDung = _noiDung;
            dapAn = _dapAn;
        }
    }
}