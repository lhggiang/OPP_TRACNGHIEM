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
    public partial class frmqlnhcauhoi : Form
    {
        Panel _panel;
        Form _parent;
        public frmqlnhcauhoi(Panel panel, Form parent)
        {
            InitializeComponent();
            _panel = panel;
            _parent = parent;
            if (_parent.GetType() == typeof(frmgv))
            {
                grb_themcauhoi.Visible = true;
                btn_themvaobaikiemtra.Visible = false;
                pn_timkiem.Visible = true;
            }
            else if (_parent.GetType() == typeof(frmtaocauhoi))
            {
                grb_themcauhoi.Visible = false;
                btn_themvaobaikiemtra.Visible = true;
                pn_timkiem.Visible = false;
            }
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            cmb_mon.DataSource = danhSachMonHoc;
            cmb_mon.DisplayMember = "TenMH";
            cmb_mon.ValueMember = "MaMH";
        }
        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Close();
            if (_parent.GetType() == typeof(frmgv))
            {
                _panel.BackColor = Color.FromArgb(255, 108, 56);
            }
        }
        private List<CauHoi> getDanhSachCauHoi()
        {
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            List<CauHoi> danhSachCauHoi = new List<CauHoi>();
            foreach (var monHoc in danhSachMonHoc)
            {
                if (monHoc.TenMH == txt_monhoc.Text)
                {
                    danhSachCauHoi.AddRange(monHoc.NganHangCauHoi);
                }
            }
            return danhSachCauHoi;
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            dgv_dscauhoi.DataSource = getDanhSachCauHoi();
        }

        private void dgv_dscauhoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_dscauhoi.Rows[e.RowIndex];
                string MaCH = selectedRow.Cells["MaCH"].Value.ToString();
                string NoiDung = selectedRow.Cells["NoiDung"].Value.ToString();
                string DapAn = selectedRow.Cells["DapAn"].Value.ToString();
                txt_mach.Text = MaCH;
                txt_noidung.Text = NoiDung;
                int dapAnIndex = cmb_dapan.FindStringExact(DapAn);
                if (dapAnIndex != -1)
                {
                    cmb_dapan.SelectedIndex = dapAnIndex;
                }
                int monHocIndex = cmb_mon.FindStringExact(txt_monhoc.Text);
                if (monHocIndex != -1)
                {
                    cmb_mon.SelectedIndex = monHocIndex;
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string maCH = txt_mach.Text;
            string noiDung = txt_noidung.Text;
            string dapAn = cmb_dapan.SelectedItem.ToString();

            CauHoi cauHoi = new CauHoi
            {
                MaCH = maCH,
                NoiDung = noiDung,
                DapAn = dapAn
            };

            string maMH = cmb_mon.SelectedValue.ToString();
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            MonHoc monhocConstrucor = new MonHoc();
            MonHoc monhoc = monhocConstrucor.LayMonHocTheoMa(danhSachMonHoc, maMH);
            monhoc.NganHangCauHoi.Add(cauHoi);
            for (int i = 0; i <= danhSachMonHoc.Count - 1; i++)
            {
                if (danhSachMonHoc[i].MaMH == maMH)
                {
                    danhSachMonHoc.RemoveAt(i);
                }
            }
            danhSachMonHoc.Add(monhoc);
            ThaoTacFile.WriteJsonToFile(danhSachMonHoc, "MonHoc.json");
            List<MonHoc> newDanhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            dgv_dscauhoi.DataSource = getDanhSachCauHoi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maCH = txt_mach.Text;
            string noiDung = txt_noidung.Text;
            string dapAn = cmb_dapan.SelectedItem.ToString();

            string maMH = cmb_mon.SelectedValue.ToString();

            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            MonHoc monhocConstrucor = new MonHoc();
            MonHoc monhoc = monhocConstrucor.LayMonHocTheoMa(danhSachMonHoc, maMH);

            foreach (CauHoi ch in monhoc.NganHangCauHoi)
            {
                if (ch.MaCH == maCH)
                {
                    ch.NoiDung = noiDung;
                    ch.DapAn = dapAn;
                    break;
                }
            }
            for (int i = 0; i <= danhSachMonHoc.Count - 1; i++)
            {
                if (danhSachMonHoc[i].MaMH == maMH)
                {
                    danhSachMonHoc.RemoveAt(i);
                }
            }

            danhSachMonHoc.Add(monhoc);
            ThaoTacFile.WriteJsonToFile(danhSachMonHoc, "MonHoc.json");
            List<MonHoc> newDanhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            dgv_dscauhoi.DataSource = getDanhSachCauHoi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            List<MonHoc> danhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            
            string maMH = cmb_mon.SelectedValue.ToString();

            MonHoc monhocConstrucor = new MonHoc();
            MonHoc monhoc = monhocConstrucor.LayMonHocTheoMa(danhSachMonHoc, maMH);

            string maCH = txt_mach.Text;

            foreach (CauHoi ch in monhoc.NganHangCauHoi)
            {
                if (ch.MaCH == maCH)
                {
                    monhoc.NganHangCauHoi.Remove(ch);
                    break;
                }
            }

            for (int i = 0; i <= danhSachMonHoc.Count - 1; i++)
            {
                if (danhSachMonHoc[i].MaMH == maMH)
                {
                    danhSachMonHoc.RemoveAt(i);
                }
            }

            danhSachMonHoc.Add(monhoc);
            ThaoTacFile.WriteJsonToFile(danhSachMonHoc, "MonHoc.json");
            List<MonHoc> newDanhSachMonHoc = ThaoTacFile.ReadJsonFromFile<MonHoc>("MonHoc.json");
            dgv_dscauhoi.DataSource = getDanhSachCauHoi();
        }
    }
}
