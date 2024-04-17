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
    public partial class frmqlbaikiemtra : Form
    {
        Form _parent;
        Panel _panel;
        //string MaLop = "";
        string MaGV = "";
        public frmqlbaikiemtra(Panel panel, Form parent, string maGV)
        {
            InitializeComponent();
            _panel = panel;
            MaGV = maGV;
            AddDataTest();
            _parent = parent;
        }
        void AddDataTest()
        {
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");
            //mã đề thi của các lớp GV dạy
            List<string> danhSachDeThi = new List<string>();
            foreach (Lop lop in danhSachLop)
            {
                if(lop.MaGV == MaGV)
                {
                    danhSachDeThi.AddRange(lop.DanhSachDeThi);
                }
            }
            List<DeThi> danhSachTatCaDeThi = ThaoTacFile.ReadJsonFromFile<DeThi>("DeThi.json");
            List<DeThi> danhSachDeThiHienThi = new List<DeThi>();
            foreach (DeThi dethi in danhSachTatCaDeThi)
            {
                if (danhSachDeThi.Contains(dethi.MaDT))
                {
                    danhSachDeThiHienThi.Add(dethi);
                }
            }
            dgv_dsbaikiemtra.DataSource = danhSachDeThiHienThi;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.BackColor = Color.FromArgb(255, 108, 56);
        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {  
            frmtaobaikiemtra frm = new frmtaobaikiemtra();
            frm.ShowDialog();
        }

        private void dgv_dsbaikiemtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string MaDT = dgv_dsbaikiemtra.Rows[e.RowIndex].Cells["MaDT"].Value.ToString();
                string TenMH = dgv_dsbaikiemtra.Rows[e.RowIndex].Cells["TenMH"].Value.ToString();
                frmtaocauhoi frm = new frmtaocauhoi(_parent, MaDT, TenMH);
                frm.Show();
                _parent.Hide();
            }
        }
    }
}
