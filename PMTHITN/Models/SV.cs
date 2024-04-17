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
    public class SV : User, ISerializable
    {
        private List<string> malop;

        public List<string> MaLop
        {
            get { return malop; }
            set { malop = value; }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Ma", Ma);
            info.AddValue("Ten", Ten);
            info.AddValue("Email", Email);
            info.AddValue("MatKhau", MatKhau);
            info.AddValue("MaLop", JsonConvert.SerializeObject(MaLop));
        }
        public SV() { }

        public SV(SerializationInfo info, StreamingContext context)
        {
            Ma = info.GetString("Ma");
            Ten = info.GetString("Ten");
            Email = info.GetString("Email");
            MatKhau = info.GetString("MatKhau");
            MaLop = JsonConvert.DeserializeObject<List<string>>(info.GetString("MaLop"));
        }
    }
}
