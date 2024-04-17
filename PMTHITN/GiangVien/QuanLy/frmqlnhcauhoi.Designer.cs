namespace PMTHITN.GiangVien.Quanly
{
    partial class frmqlnhcauhoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_subcontent = new System.Windows.Forms.Panel();
            this.grb_dscauhoi = new System.Windows.Forms.GroupBox();
            this.dgv_dscauhoi = new System.Windows.Forms.DataGridView();
            this.pn_timkiem = new System.Windows.Forms.Panel();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_monhoc = new System.Windows.Forms.TextBox();
            this.lbl_monhoc = new System.Windows.Forms.Label();
            this.grb_themcauhoi = new System.Windows.Forms.GroupBox();
            this.cmb_dapan = new System.Windows.Forms.ComboBox();
            this.lbl_dapan = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.lbl_noidungch = new System.Windows.Forms.Label();
            this.lbl_monthi = new System.Windows.Forms.Label();
            this.cmb_mon = new System.Windows.Forms.ComboBox();
            this.txt_mach = new System.Windows.Forms.TextBox();
            this.lbl_mach = new System.Windows.Forms.Label();
            this.pn_subheader = new System.Windows.Forms.Panel();
            this.btn_themvaobaikiemtra = new System.Windows.Forms.Button();
            this.table_subheader = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_nhcauhoi = new System.Windows.Forms.Label();
            this.pn_subcontent.SuspendLayout();
            this.grb_dscauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dscauhoi)).BeginInit();
            this.pn_timkiem.SuspendLayout();
            this.grb_themcauhoi.SuspendLayout();
            this.pn_subheader.SuspendLayout();
            this.table_subheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_subcontent
            // 
            this.pn_subcontent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_subcontent.Controls.Add(this.grb_dscauhoi);
            this.pn_subcontent.Controls.Add(this.grb_themcauhoi);
            this.pn_subcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_subcontent.Location = new System.Drawing.Point(0, 58);
            this.pn_subcontent.Name = "pn_subcontent";
            this.pn_subcontent.Size = new System.Drawing.Size(991, 362);
            this.pn_subcontent.TabIndex = 3;
            // 
            // grb_dscauhoi
            // 
            this.grb_dscauhoi.Controls.Add(this.dgv_dscauhoi);
            this.grb_dscauhoi.Controls.Add(this.pn_timkiem);
            this.grb_dscauhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_dscauhoi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_dscauhoi.Location = new System.Drawing.Point(0, 0);
            this.grb_dscauhoi.Name = "grb_dscauhoi";
            this.grb_dscauhoi.Size = new System.Drawing.Size(492, 360);
            this.grb_dscauhoi.TabIndex = 2;
            this.grb_dscauhoi.TabStop = false;
            this.grb_dscauhoi.Text = "Danh sách câu hỏi";
            // 
            // dgv_dscauhoi
            // 
            this.dgv_dscauhoi.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_dscauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dscauhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dscauhoi.Location = new System.Drawing.Point(3, 64);
            this.dgv_dscauhoi.Name = "dgv_dscauhoi";
            this.dgv_dscauhoi.RowHeadersWidth = 51;
            this.dgv_dscauhoi.RowTemplate.Height = 24;
            this.dgv_dscauhoi.Size = new System.Drawing.Size(486, 293);
            this.dgv_dscauhoi.TabIndex = 3;
            this.dgv_dscauhoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dscauhoi_CellContentClick);
            // 
            // pn_timkiem
            // 
            this.pn_timkiem.Controls.Add(this.btn_tim);
            this.pn_timkiem.Controls.Add(this.txt_monhoc);
            this.pn_timkiem.Controls.Add(this.lbl_monhoc);
            this.pn_timkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_timkiem.Location = new System.Drawing.Point(3, 32);
            this.pn_timkiem.Name = "pn_timkiem";
            this.pn_timkiem.Size = new System.Drawing.Size(486, 32);
            this.pn_timkiem.TabIndex = 2;
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.White;
            this.btn_tim.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tim.Location = new System.Drawing.Point(347, 2);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(67, 29);
            this.btn_tim.TabIndex = 83;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_monhoc
            // 
            this.txt_monhoc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monhoc.Location = new System.Drawing.Point(183, 3);
            this.txt_monhoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_monhoc.Name = "txt_monhoc";
            this.txt_monhoc.Size = new System.Drawing.Size(132, 28);
            this.txt_monhoc.TabIndex = 82;
            // 
            // lbl_monhoc
            // 
            this.lbl_monhoc.AutoSize = true;
            this.lbl_monhoc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monhoc.Location = new System.Drawing.Point(72, 6);
            this.lbl_monhoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_monhoc.Name = "lbl_monhoc";
            this.lbl_monhoc.Size = new System.Drawing.Size(103, 21);
            this.lbl_monhoc.TabIndex = 81;
            this.lbl_monhoc.Text = "Tên môn học:";
            // 
            // grb_themcauhoi
            // 
            this.grb_themcauhoi.Controls.Add(this.cmb_dapan);
            this.grb_themcauhoi.Controls.Add(this.lbl_dapan);
            this.grb_themcauhoi.Controls.Add(this.btn_sua);
            this.grb_themcauhoi.Controls.Add(this.btn_xoa);
            this.grb_themcauhoi.Controls.Add(this.btn_them);
            this.grb_themcauhoi.Controls.Add(this.txt_noidung);
            this.grb_themcauhoi.Controls.Add(this.lbl_noidungch);
            this.grb_themcauhoi.Controls.Add(this.lbl_monthi);
            this.grb_themcauhoi.Controls.Add(this.cmb_mon);
            this.grb_themcauhoi.Controls.Add(this.txt_mach);
            this.grb_themcauhoi.Controls.Add(this.lbl_mach);
            this.grb_themcauhoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.grb_themcauhoi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_themcauhoi.Location = new System.Drawing.Point(492, 0);
            this.grb_themcauhoi.Name = "grb_themcauhoi";
            this.grb_themcauhoi.Size = new System.Drawing.Size(497, 360);
            this.grb_themcauhoi.TabIndex = 1;
            this.grb_themcauhoi.TabStop = false;
            this.grb_themcauhoi.Text = "Thêm câu hỏi";
            // 
            // cmb_dapan
            // 
            this.cmb_dapan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dapan.FormattingEnabled = true;
            this.cmb_dapan.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmb_dapan.Location = new System.Drawing.Point(337, 30);
            this.cmb_dapan.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_dapan.Name = "cmb_dapan";
            this.cmb_dapan.Size = new System.Drawing.Size(142, 29);
            this.cmb_dapan.TabIndex = 85;
            // 
            // lbl_dapan
            // 
            this.lbl_dapan.AutoSize = true;
            this.lbl_dapan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dapan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_dapan.Location = new System.Drawing.Point(266, 33);
            this.lbl_dapan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dapan.Name = "lbl_dapan";
            this.lbl_dapan.Size = new System.Drawing.Size(64, 21);
            this.lbl_dapan.TabIndex = 84;
            this.lbl_dapan.Text = "Đáp án:";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.White;
            this.btn_sua.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Location = new System.Drawing.Point(412, 67);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(67, 41);
            this.btn_sua.TabIndex = 80;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Location = new System.Drawing.Point(341, 67);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(67, 41);
            this.btn_xoa.TabIndex = 81;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Location = new System.Drawing.Point(270, 67);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(67, 41);
            this.btn_them.TabIndex = 79;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_noidung
            // 
            this.txt_noidung.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noidung.Location = new System.Drawing.Point(12, 134);
            this.txt_noidung.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(467, 219);
            this.txt_noidung.TabIndex = 78;
            // 
            // lbl_noidungch
            // 
            this.lbl_noidungch.AutoSize = true;
            this.lbl_noidungch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noidungch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_noidungch.Location = new System.Drawing.Point(8, 100);
            this.lbl_noidungch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_noidungch.Name = "lbl_noidungch";
            this.lbl_noidungch.Size = new System.Drawing.Size(132, 21);
            this.lbl_noidungch.TabIndex = 77;
            this.lbl_noidungch.Text = "Nội dung câu hỏi:";
            // 
            // lbl_monthi
            // 
            this.lbl_monthi.AutoSize = true;
            this.lbl_monthi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthi.Location = new System.Drawing.Point(8, 67);
            this.lbl_monthi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_monthi.Name = "lbl_monthi";
            this.lbl_monthi.Size = new System.Drawing.Size(74, 21);
            this.lbl_monthi.TabIndex = 76;
            this.lbl_monthi.Text = "Tên môn:";
            // 
            // cmb_mon
            // 
            this.cmb_mon.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mon.FormattingEnabled = true;
            this.cmb_mon.Location = new System.Drawing.Point(103, 64);
            this.cmb_mon.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_mon.Name = "cmb_mon";
            this.cmb_mon.Size = new System.Drawing.Size(132, 29);
            this.cmb_mon.TabIndex = 75;
            // 
            // txt_mach
            // 
            this.txt_mach.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mach.Location = new System.Drawing.Point(103, 30);
            this.txt_mach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mach.Name = "txt_mach";
            this.txt_mach.Size = new System.Drawing.Size(132, 28);
            this.txt_mach.TabIndex = 74;
            // 
            // lbl_mach
            // 
            this.lbl_mach.AutoSize = true;
            this.lbl_mach.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mach.Location = new System.Drawing.Point(8, 34);
            this.lbl_mach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mach.Name = "lbl_mach";
            this.lbl_mach.Size = new System.Drawing.Size(92, 21);
            this.lbl_mach.TabIndex = 73;
            this.lbl_mach.Text = "Mã câu hỏi:";
            // 
            // pn_subheader
            // 
            this.pn_subheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_subheader.Controls.Add(this.btn_themvaobaikiemtra);
            this.pn_subheader.Controls.Add(this.table_subheader);
            this.pn_subheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_subheader.Location = new System.Drawing.Point(0, 0);
            this.pn_subheader.Name = "pn_subheader";
            this.pn_subheader.Size = new System.Drawing.Size(991, 58);
            this.pn_subheader.TabIndex = 2;
            // 
            // btn_themvaobaikiemtra
            // 
            this.btn_themvaobaikiemtra.BackColor = System.Drawing.Color.White;
            this.btn_themvaobaikiemtra.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themvaobaikiemtra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_themvaobaikiemtra.Location = new System.Drawing.Point(762, 7);
            this.btn_themvaobaikiemtra.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themvaobaikiemtra.Name = "btn_themvaobaikiemtra";
            this.btn_themvaobaikiemtra.Size = new System.Drawing.Size(209, 41);
            this.btn_themvaobaikiemtra.TabIndex = 80;
            this.btn_themvaobaikiemtra.Text = "Thêm vào bài kiểm tra";
            this.btn_themvaobaikiemtra.UseVisualStyleBackColor = false;
            // 
            // table_subheader
            // 
            this.table_subheader.ColumnCount = 2;
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.table_subheader.Controls.Add(this.lbl_back, 0, 0);
            this.table_subheader.Controls.Add(this.lbl_nhcauhoi, 1, 0);
            this.table_subheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_subheader.Location = new System.Drawing.Point(12, 8);
            this.table_subheader.Name = "table_subheader";
            this.table_subheader.RowCount = 1;
            this.table_subheader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.Size = new System.Drawing.Size(448, 39);
            this.table_subheader.TabIndex = 0;
            // 
            // lbl_back
            // 
            this.lbl_back.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_back.AutoSize = true;
            this.lbl_back.Location = new System.Drawing.Point(3, 5);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(15, 29);
            this.lbl_back.TabIndex = 0;
            this.lbl_back.Text = "<";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // lbl_nhcauhoi
            // 
            this.lbl_nhcauhoi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nhcauhoi.AutoSize = true;
            this.lbl_nhcauhoi.Location = new System.Drawing.Point(24, 5);
            this.lbl_nhcauhoi.Name = "lbl_nhcauhoi";
            this.lbl_nhcauhoi.Size = new System.Drawing.Size(230, 29);
            this.lbl_nhcauhoi.TabIndex = 1;
            this.lbl_nhcauhoi.Text = "Ngân hàng câu hỏi";
            // 
            // frmqlnhcauhoi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(991, 420);
            this.Controls.Add(this.pn_subcontent);
            this.Controls.Add(this.pn_subheader);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmqlnhcauhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qllskiemtra";
            this.pn_subcontent.ResumeLayout(false);
            this.grb_dscauhoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dscauhoi)).EndInit();
            this.pn_timkiem.ResumeLayout(false);
            this.pn_timkiem.PerformLayout();
            this.grb_themcauhoi.ResumeLayout(false);
            this.grb_themcauhoi.PerformLayout();
            this.pn_subheader.ResumeLayout(false);
            this.table_subheader.ResumeLayout(false);
            this.table_subheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_subcontent;
        private System.Windows.Forms.Panel pn_subheader;
        private System.Windows.Forms.TableLayoutPanel table_subheader;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_nhcauhoi;
        private System.Windows.Forms.GroupBox grb_themcauhoi;
        private System.Windows.Forms.Label lbl_monthi;
        private System.Windows.Forms.ComboBox cmb_mon;
        private System.Windows.Forms.TextBox txt_mach;
        private System.Windows.Forms.Label lbl_mach;
        private System.Windows.Forms.TextBox txt_noidung;
        private System.Windows.Forms.Label lbl_noidungch;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cmb_dapan;
        private System.Windows.Forms.Label lbl_dapan;
        private System.Windows.Forms.Button btn_themvaobaikiemtra;
        private System.Windows.Forms.GroupBox grb_dscauhoi;
        private System.Windows.Forms.Panel pn_timkiem;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_monhoc;
        private System.Windows.Forms.Label lbl_monhoc;
        private System.Windows.Forms.DataGridView dgv_dscauhoi;
    }
}