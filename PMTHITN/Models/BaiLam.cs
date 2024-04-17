using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PMTHITN.Models
{
    [Serializable]
    public class BaiLam : ISerializable
    {
        private CauHoi cauhoi;
        private string traloi;
        public CauHoi CauHoi { get { return cauhoi; } set { cauhoi = value; } }
        public string Traloi { get { return traloi; } set { traloi = value; } }
        public BaiLam() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CauHoi", JsonConvert.SerializeObject(cauhoi));
            info.AddValue("TraLoi", traloi);
        }
        public BaiLam(SerializationInfo info, StreamingContext context)
        {
            cauhoi = (CauHoi)info.GetValue("CauHoi", typeof(CauHoi));
            traloi = info.GetString("TraLoi");
        }

        public float TinhDiemBaiLam()
        {
            if(traloi != null)
            {
                if (traloi.Equals(cauhoi.DapAn, StringComparison.OrdinalIgnoreCase)) return 1.0f;
                else return 0.0f;
            }
            else return 0.0f;
        }
    }
}
