namespace PMTHITN.GiangVien.Quanly
{
    partial class frmtaocauhoi
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
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_taobaikiemtra = new System.Windows.Forms.Label();
            this.pn_bangdiem = new System.Windows.Forms.Panel();
            this.grb_themcauhoi = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_themngaunhien = new System.Windows.Forms.Button();
            this.txt_themngaunhien = new System.Windows.Forms.TextBox();
            this.dgv_nhcauhoi = new System.Windows.Forms.DataGridView();
            this.btn_themtunhcauhoi = new System.Windows.Forms.Button();
            this.grb_dscauhoi = new System.Windows.Forms.GroupBox();
            this.dgv_dscauhoi = new System.Windows.Forms.DataGridView();
            this.pn_subheader = new System.Windows.Forms.Panel();
            this.table_subheader = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_socau = new System.Windows.Forms.Label();
            this.pn_bangdiem.SuspendLayout();
            this.grb_themcauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhcauhoi)).BeginInit();
            this.grb_dscauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dscauhoi)).BeginInit();
            this.pn_subheader.SuspendLayout();
            this.table_subheader.SuspendLayout();
            this.SuspendLayout();
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
            // lbl_taobaikiemtra
            // 
            this.lbl_taobaikiemtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_taobaikiemtra.AutoSize = true;
            this.lbl_taobaikiemtra.Location = new System.Drawing.Point(24, 5);
            this.lbl_taobaikiemtra.Name = "lbl_taobaikiemtra";
            this.lbl_taobaikiemtra.Size = new System.Drawing.Size(202, 29);
            this.lbl_taobaikiemtra.TabIndex = 1;
            this.lbl_taobaikiemtra.Text = "Tạo bài kiểm tra";
            // 
            // pn_bangdiem
            // 
            this.pn_bangdiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_bangdiem.Controls.Add(this.grb_themcauhoi);
            this.pn_bangdiem.Controls.Add(this.grb_dscauhoi);
            this.pn_bangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_bangdiem.Location = new System.Drawing.Point(0, 62);
            this.pn_bangdiem.Name = "pn_bangdiem";
            this.pn_bangdiem.Size = new System.Drawing.Size(951, 622);
            this.pn_bangdiem.TabIndex = 3;
            // 
            // grb_themcauhoi
            // 
            this.grb_themcauhoi.Controls.Add(this.lbl_socau);
            this.grb_themcauhoi.Controls.Add(this.btn_xoa);
            this.grb_themcauhoi.Controls.Add(this.btn_themngaunhien);
            this.grb_themcauhoi.Controls.Add(this.txt_themngaunhien);
            this.grb_themcauhoi.Controls.Add(this.dgv_nhcauhoi);
            this.grb_themcauhoi.Controls.Add(this.btn_themtunhcauhoi);
            this.grb_themcauhoi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_themcauhoi.Location = new System.Drawing.Point(489, 17);
            this.grb_themcauhoi.Name = "grb_themcauhoi";
            this.grb_themcauhoi.Size = new System.Drawing.Size(431, 578);
            this.grb_themcauhoi.TabIndex = 3;
            this.grb_themcauhoi.TabStop = false;
            this.grb_themcauhoi.Text = "Thêm câu hỏi";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_xoa.Location = new System.Drawing.Point(254, 532);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(173, 38);
            this.btn_xoa.TabIndex = 79;
            this.btn_xoa.Text = "Xóa câu hỏi";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_themngaunhien
            // 
            this.btn_themngaunhien.BackColor = System.Drawing.Color.White;
            this.btn_themngaunhien.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_themngaunhien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_themngaunhien.Location = new System.Drawing.Point(254, 477);
            this.btn_themngaunhien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themngaunhien.Name = "btn_themngaunhien";
            this.btn_themngaunhien.Size = new System.Drawing.Size(174, 32);
            this.btn_themngaunhien.TabIndex = 78;
            this.btn_themngaunhien.Text = "Thêm ngẫu nhiên";
            this.btn_themngaunhien.UseVisualStyleBackColor = false;
            this.btn_themngaunhien.Click += new System.EventHandler(this.btn_themngaunhien_Click);
            // 
            // txt_themngaunhien
            // 
            this.txt_themngaunhien.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_themngaunhien.Location = new System.Drawing.Point(108, 480);
            this.txt_themngaunhien.Name = "txt_themngaunhien";
            this.txt_themngaunhien.Size = new System.Drawing.Size(139, 32);
            this.txt_themngaunhien.TabIndex = 77;
            // 
            // dgv_nhcauhoi
            // 
            this.dgv_nhcauhoi.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_nhcauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhcauhoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_nhcauhoi.Location = new System.Drawing.Point(3, 32);
            this.dgv_nhcauhoi.Name = "dgv_nhcauhoi";
            this.dgv_nhcauhoi.RowHeadersWidth = 51;
            this.dgv_nhcauhoi.RowTemplate.Height = 24;
            this.dgv_nhcauhoi.Size = new System.Drawing.Size(425, 438);
            this.dgv_nhcauhoi.TabIndex = 74;
            // 
            // btn_themtunhcauhoi
            // 
            this.btn_themtunhcauhoi.BackColor = System.Drawing.Color.White;
            this.btn_themtunhcauhoi.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_themtunhcauhoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_themtunhcauhoi.Location = new System.Drawing.Point(3, 530);
            this.btn_themtunhcauhoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themtunhcauhoi.Name = "btn_themtunhcauhoi";
            this.btn_themtunhcauhoi.Size = new System.Drawing.Size(244, 41);
            this.btn_themtunhcauhoi.TabIndex = 73;
            this.btn_themtunhcauhoi.Text = "Thêm từ ngân hàng câu hỏi";
            this.btn_themtunhcauhoi.UseVisualStyleBackColor = false;
            this.btn_themtunhcauhoi.Click += new System.EventHandler(this.btn_themtunhcauhoi_Click);
            // 
            // grb_dscauhoi
            // 
            this.grb_dscauhoi.Controls.Add(this.dgv_dscauhoi);
            this.grb_dscauhoi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_dscauhoi.Location = new System.Drawing.Point(23, 17);
            this.grb_dscauhoi.Name = "grb_dscauhoi";
            this.grb_dscauhoi.Size = new System.Drawing.Size(431, 578);
            this.grb_dscauhoi.TabIndex = 2;
            this.grb_dscauhoi.TabStop = false;
            this.grb_dscauhoi.Text = "Danh sách câu hỏi";
            // 
            // dgv_dscauhoi
            // 
            this.dgv_dscauhoi.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_dscauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dscauhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dscauhoi.Location = new System.Drawing.Point(3, 32);
            this.dgv_dscauhoi.Name = "dgv_dscauhoi";
            this.dgv_dscauhoi.RowHeadersWidth = 51;
            this.dgv_dscauhoi.RowTemplate.Height = 24;
            this.dgv_dscauhoi.Size = new System.Drawing.Size(425, 543);
            this.dgv_dscauhoi.TabIndex = 0;
            // 
            // pn_subheader
            // 
            this.pn_subheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_subheader.Controls.Add(this.table_subheader);
            this.pn_subheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_subheader.Location = new System.Drawing.Point(0, 0);
            this.pn_subheader.Name = "pn_subheader";
            this.pn_subheader.Size = new System.Drawing.Size(951, 62);
            this.pn_subheader.TabIndex = 2;
            // 
            // table_subheader
            // 
            this.table_subheader.ColumnCount = 2;
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.table_subheader.Controls.Add(this.lbl_back, 0, 0);
            this.table_subheader.Controls.Add(this.lbl_taobaikiemtra, 1, 0);
            this.table_subheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_subheader.Location = new System.Drawing.Point(12, 12);
            this.table_subheader.Name = "table_subheader";
            this.table_subheader.RowCount = 1;
            this.table_subheader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.Size = new System.Drawing.Size(448, 39);
            this.table_subheader.TabIndex = 1;
            // 
            // lbl_socau
            // 
            this.lbl_socau.AutoSize = true;
            this.lbl_socau.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_socau.Location = new System.Drawing.Point(6, 483);
            this.lbl_socau.Name = "lbl_socau";
            this.lbl_socau.Size = new System.Drawing.Size(96, 24);
            this.lbl_socau.TabIndex = 80;
            this.lbl_socau.Text = "Số câu hỏi";
            // 
            // frmtaocauhoi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(951, 684);
            this.Controls.Add(this.pn_bangdiem);
            this.Controls.Add(this.pn_subheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtaocauhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtaobaikiemtra";
            this.pn_bangdiem.ResumeLayout(false);
            this.grb_themcauhoi.ResumeLayout(false);
            this.grb_themcauhoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhcauhoi)).EndInit();
            this.grb_dscauhoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dscauhoi)).EndInit();
            this.pn_subheader.ResumeLayout(false);
            this.table_subheader.ResumeLayout(false);
            this.table_subheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_taobaikiemtra;
        private System.Windows.Forms.Panel pn_bangdiem;
        private System.Windows.Forms.Panel pn_subheader;
        private System.Windows.Forms.TableLayoutPanel table_subheader;
        private System.Windows.Forms.GroupBox grb_themcauhoi;
        private System.Windows.Forms.GroupBox grb_dscauhoi;
        private System.Windows.Forms.DataGridView dgv_dscauhoi;
        private System.Windows.Forms.DataGridView dgv_nhcauhoi;
        private System.Windows.Forms.Button btn_themtunhcauhoi;
        private System.Windows.Forms.Button btn_themngaunhien;
        private System.Windows.Forms.TextBox txt_themngaunhien;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label lbl_socau;
    }
}