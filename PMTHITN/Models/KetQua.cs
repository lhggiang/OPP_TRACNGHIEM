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
    public class KetQua : ISerializable
    {
        private int MAKQ;
        private string MASV;
        private BaiLam[] ketqua;
        private float Diem;
        private string ThoiGianNopBai;

        public int MaKQ{
            get { return MAKQ; }
            set {  MAKQ = value; }
        }
        public string MaSV
        {
            get { return MASV; }
            set { MASV = value; }
        }
        public BaiLam[] Ketqua
        {
            get { return ketqua; }
            set { ketqua = value; }
        }
        public float diem
        {
            get { return Diem; }
            set { Diem = value; }
        }

        public string ThoiGianNop { get { return ThoiGianNopBai; } set { ThoiGianNopBai = value; } }


        public KetQua() { }
        public KetQua(string MaSV, int count)
        {
            MAKQ = SinhMaKQ();
            MASV = MaSV;
            ketqua = new BaiLam[count];
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaKQ", MAKQ);
            info.AddValue("MaSV", MASV);
            info.AddValue("KetQua", JsonConvert.SerializeObject(ketqua));
            info.AddValue("Diem", Diem);
            info.AddValue("ThoiGianNopBai", ThoiGianNopBai);
        }
        public KetQua(SerializationInfo info, StreamingContext context)
        {
            MAKQ = info.GetInt32("MaKQ");
            MASV = info.GetString("MaSV");
            ketqua = (BaiLam[])info.GetValue("KetQua", typeof(BaiLam[]));
            Diem = info.GetSingle("Diem");
            ThoiGianNopBai = info.GetString("ThoiGianNopBai");
        }

        int SinhMaKQ()
        {
            List<KetQua> tongKQ = ThaoTacFile.ReadJsonFromFile<KetQua>("KetQua.json");
            if(tongKQ != null) return tongKQ.Count + 1;
            return 1;
        }
        public void TinhDiem()
        {
            if (ketqua != null && ketqua.Length > 0)
            {
                float tongDiem = 0;
                foreach(BaiLam bailam in ketqua)
                {
                    if(bailam!= null)
                    tongDiem += bailam.TinhDiemBaiLam();
                }
                diem = tongDiem/ ketqua.Length * 10;
            }
            else { diem = 0; }
        }
    }
}
