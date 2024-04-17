using PMTHITN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN.GiangVien.Quanly
{
    public partial class frmtaobaikiemtra : Form
    {
        public frmtaobaikiemtra()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tao_Click(object sender, EventArgs e)
        {
            string MaLop = txtmalophoc.Text;
            string MaDT = txtmadethi.Text;
            string TenMH = txttenmon.Text;
            int SoCau = int.Parse(txtsocau.Text);
            int ThoiGianThi = int.Parse(txtthoigian.Text);
            string ThoiGianLamBai = dtptgthi.Value.ToString("dd/MM/yyyy");
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");
            DeThi deThi = new DeThi(MaDT, TenMH, SoCau, ThoiGianThi, ThoiGianLamBai);
            deThi.DanhSachCauHoi = new List<string>();
            ThaoTacFile.WriteJsonToConstantFile(deThi, "DeThi.json");
            foreach (Lop lop in danhSachLop)
            {
                if (lop.MaLop == MaLop)
                {
                    lop.ThemDeThi(deThi.MaDT);                
                    ThaoTacFile.WriteJsonToFile(danhSachLop, "Lop.json");
                    break;
                }
            }
            this.Close();
        }
    }
}
