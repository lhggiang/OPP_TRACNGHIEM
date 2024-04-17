using PMTHITN.Models;
using PMTHITN.SinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PMTHITN
{
    public class datatest // Hiển thị formcauhoi và tải data lên đó, bên cạnh đó có button
    {
        Panel _panel;
        Panel _flow;
        int thutu;
        string _cauhoi;
        Button button;
        BaiLam dachon;
        private Form currentFormChild;
        public void OpenChildForm(Form childForm, Panel panel)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public datatest(Panel panel, FlowLayoutPanel _fowPanel, string cauhoi, int thutu, BaiLam dachon)
        {
            button = new Button();
            _panel = panel;
            _flow = _fowPanel;
            _cauhoi = cauhoi;
            this.dachon = dachon;
            this.thutu = thutu;
            button.Size = new System.Drawing.Size(40, 40);
            button.Text = this.thutu.ToString();
            _flow.Controls.Add(button);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmcauhoi(_cauhoi, this.thutu, dachon), _panel);
        }
    }
}
