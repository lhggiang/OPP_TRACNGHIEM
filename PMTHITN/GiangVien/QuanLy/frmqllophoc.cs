using PMTHITN.GiangVien.Quanly;
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

namespace PMTHITN
{
    public partial class frmqllophoc : Form
    {
        Panel _panel;
        Form _parent;
        string MaGV = "";
        public frmqllophoc(Panel panel, Form parent, string maGV)
        {
            InitializeComponent();
            this._panel = panel;
            _parent = parent;
            MaGV = maGV;
            AddDataTest();
        }

        void AddDataTest()
        {
            List<Lop> danhSachLop = ThaoTacFile.ReadJsonFromFile<Lop>("Lop.json");

            List<Lop> danhSachLopGiangDay = new List<Lop>();

            foreach (Lop lop in danhSachLop)
            {
                if (lop.MaGV == MaGV)
                {
                    danhSachLopGiangDay.Add(lop);
                }
            }
            dgv_dslophoc.DataSource = danhSachLopGiangDay;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Close();
            _panel.BackColor = Color.FromArgb(255, 108, 56);
        }

        private void dgv_dslophoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaLop = "";
            string TenLop = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                 MaLop = dgv_dslophoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                 TenLop = dgv_dslophoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            frmdssinhvientronglop frm = new frmdssinhvientronglop(_parent, MaLop, TenLop);
            frm.Show();
            _parent.Hide();
        }

        private void pn_subcontent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
