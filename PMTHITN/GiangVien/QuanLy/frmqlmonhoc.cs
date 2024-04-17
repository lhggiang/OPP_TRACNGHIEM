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
    public partial class frmqlmonhoc : Form
    {
        Form _parent;
        Panel _panel;
        public frmqlmonhoc(Panel panel, Form parent)
        {
            InitializeComponent();
            _panel = panel;
            _parent = parent;
            AddDataTest();
        }
        void AddDataTest()
        {
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            dgv_dsmonhoc.DataSource = danhSachMonHoc;
        }
        private void dgv_dsmonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //chuyển qua frmqlcauhoi ngân hàng câu hỏi, chọn luôn môn học
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
             this.Close();
             if (_parent.GetType() == typeof(frmgv))
             {
                  _panel.BackColor = Color.FromArgb(255, 108, 56);
             }
        }
    }
}
