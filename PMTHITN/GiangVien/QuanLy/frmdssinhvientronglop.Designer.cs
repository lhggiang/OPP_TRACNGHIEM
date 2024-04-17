namespace PMTHITN.GiangVien.Quanly
{
    partial class frmdssinhvientronglop
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
            this.table_subheader = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_dssinhvien = new System.Windows.Forms.Label();
            this.pn_subheader = new System.Windows.Forms.Panel();
            this.grb_dssinhvien = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_malop = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.lb_tenlop = new System.Windows.Forms.Label();
            this.dgv_dssinhvien = new System.Windows.Forms.DataGridView();
            this.pn_dssinhvien = new System.Windows.Forms.Panel();
            this.pn_addsinhvien = new System.Windows.Forms.Panel();
            this.grb_themsinhvien = new System.Windows.Forms.GroupBox();
            this.table_themsinhvien = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_mssv = new System.Windows.Forms.Label();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.table_subheader.SuspendLayout();
            this.pn_subheader.SuspendLayout();
            this.grb_dssinhvien.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssinhvien)).BeginInit();
            this.pn_dssinhvien.SuspendLayout();
            this.pn_addsinhvien.SuspendLayout();
            this.grb_themsinhvien.SuspendLayout();
            this.table_themsinhvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_subheader
            // 
            this.table_subheader.ColumnCount = 2;
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.table_subheader.Controls.Add(this.lbl_back, 0, 0);
            this.table_subheader.Controls.Add(this.lbl_dssinhvien, 1, 0);
            this.table_subheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_subheader.Location = new System.Drawing.Point(12, 12);
            this.table_subheader.Name = "table_subheader";
            this.table_subheader.RowCount = 1;
            this.table_subheader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.Size = new System.Drawing.Size(448, 39);
            this.table_subheader.TabIndex = 1;
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
            // lbl_dssinhvien
            // 
            this.lbl_dssinhvien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dssinhvien.AutoSize = true;
            this.lbl_dssinhvien.Location = new System.Drawing.Point(24, 5);
            this.lbl_dssinhvien.Name = "lbl_dssinhvien";
            this.lbl_dssinhvien.Size = new System.Drawing.Size(244, 29);
            this.lbl_dssinhvien.TabIndex = 1;
            this.lbl_dssinhvien.Text = "Danh sách sinh viên";
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
            // grb_dssinhvien
            // 
            this.grb_dssinhvien.Controls.Add(this.tableLayoutPanel1);
            this.grb_dssinhvien.Controls.Add(this.dgv_dssinhvien);
            this.grb_dssinhvien.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb_dssinhvien.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_dssinhvien.Location = new System.Drawing.Point(0, 0);
            this.grb_dssinhvien.Name = "grb_dssinhvien";
            this.grb_dssinhvien.Size = new System.Drawing.Size(541, 620);
            this.grb_dssinhvien.TabIndex = 2;
            this.grb_dssinhvien.TabStop = false;
            this.grb_dssinhvien.Text = "Danh sách sinh viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_malop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_malop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_tenlop, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_tenlop, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 63);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_malop
            // 
            this.lbl_malop.AutoSize = true;
            this.lbl_malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_malop.Location = new System.Drawing.Point(3, 0);
            this.lbl_malop.Name = "lbl_malop";
            this.lbl_malop.Size = new System.Drawing.Size(92, 29);
            this.lbl_malop.TabIndex = 17;
            this.lbl_malop.Text = "Mã lớp:";
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(105, 3);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(95, 36);
            this.txt_malop.TabIndex = 19;
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Location = new System.Drawing.Point(318, 3);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(177, 36);
            this.txt_tenlop.TabIndex = 20;
            // 
            // lb_tenlop
            // 
            this.lb_tenlop.AutoSize = true;
            this.lb_tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenlop.Location = new System.Drawing.Point(208, 0);
            this.lb_tenlop.Name = "lb_tenlop";
            this.lb_tenlop.Size = new System.Drawing.Size(102, 29);
            this.lb_tenlop.TabIndex = 18;
            this.lb_tenlop.Text = "Tên lớp:";
            // 
            // dgv_dssinhvien
            // 
            this.dgv_dssinhvien.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_dssinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dssinhvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dssinhvien.Location = new System.Drawing.Point(3, 95);
            this.dgv_dssinhvien.Name = "dgv_dssinhvien";
            this.dgv_dssinhvien.RowHeadersWidth = 51;
            this.dgv_dssinhvien.RowTemplate.Height = 24;
            this.dgv_dssinhvien.Size = new System.Drawing.Size(535, 522);
            this.dgv_dssinhvien.TabIndex = 1;
            // 
            // pn_dssinhvien
            // 
            this.pn_dssinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_dssinhvien.Controls.Add(this.pn_addsinhvien);
            this.pn_dssinhvien.Controls.Add(this.grb_dssinhvien);
            this.pn_dssinhvien.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_dssinhvien.Location = new System.Drawing.Point(0, 62);
            this.pn_dssinhvien.Name = "pn_dssinhvien";
            this.pn_dssinhvien.Size = new System.Drawing.Size(951, 622);
            this.pn_dssinhvien.TabIndex = 3;
            // 
            // pn_addsinhvien
            // 
            this.pn_addsinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_addsinhvien.Controls.Add(this.grb_themsinhvien);
            this.pn_addsinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_addsinhvien.Location = new System.Drawing.Point(541, 0);
            this.pn_addsinhvien.Name = "pn_addsinhvien";
            this.pn_addsinhvien.Size = new System.Drawing.Size(408, 620);
            this.pn_addsinhvien.TabIndex = 3;
            // 
            // grb_themsinhvien
            // 
            this.grb_themsinhvien.Controls.Add(this.table_themsinhvien);
            this.grb_themsinhvien.Dock = System.Windows.Forms.DockStyle.Right;
            this.grb_themsinhvien.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_themsinhvien.Location = new System.Drawing.Point(7, 0);
            this.grb_themsinhvien.Name = "grb_themsinhvien";
            this.grb_themsinhvien.Size = new System.Drawing.Size(399, 618);
            this.grb_themsinhvien.TabIndex = 2;
            this.grb_themsinhvien.TabStop = false;
            this.grb_themsinhvien.Text = "Thêm sinh viên";
            // 
            // table_themsinhvien
            // 
            this.table_themsinhvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.table_themsinhvien.ColumnCount = 2;
            this.table_themsinhvien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_themsinhvien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_themsinhvien.Controls.Add(this.lbl_mssv, 0, 0);
            this.table_themsinhvien.Controls.Add(this.txt_mssv, 1, 0);
            this.table_themsinhvien.Controls.Add(this.btn_them, 0, 2);
            this.table_themsinhvien.Controls.Add(this.btn_xoa, 1, 2);
            this.table_themsinhvien.Location = new System.Drawing.Point(6, 32);
            this.table_themsinhvien.Name = "table_themsinhvien";
            this.table_themsinhvien.RowCount = 8;
            this.table_themsinhvien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.78487F));
            this.table_themsinhvien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434F));
            this.table_themsinhvien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.85849F));
            this.table_themsinhvien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.17251F));
            this.table_themsinhvien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.19677F));
            this.table_themsinhvien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.table_themsinhvien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.table_themsinhvien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.table_themsinhvien.Size = new System.Drawing.Size(390, 576);
            this.table_themsinhvien.TabIndex = 2;
            // 
            // lbl_mssv
            // 
            this.lbl_mssv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_mssv.AutoSize = true;
            this.lbl_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mssv.Location = new System.Drawing.Point(3, 16);
            this.lbl_mssv.Name = "lbl_mssv";
            this.lbl_mssv.Size = new System.Drawing.Size(152, 29);
            this.lbl_mssv.TabIndex = 12;
            this.lbl_mssv.Text = "Mã sinh viên:";
            // 
            // txt_mssv
            // 
            this.txt_mssv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mssv.Location = new System.Drawing.Point(198, 14);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(186, 34);
            this.txt_mssv.TabIndex = 17;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(198, 122);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(186, 46);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(3, 122);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(186, 46);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // frmdssinhvientronglop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(951, 684);
            this.Controls.Add(this.pn_dssinhvien);
            this.Controls.Add(this.pn_subheader);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdssinhvientronglop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmdssinhvientronglop";
            this.table_subheader.ResumeLayout(false);
            this.table_subheader.PerformLayout();
            this.pn_subheader.ResumeLayout(false);
            this.grb_dssinhvien.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssinhvien)).EndInit();
            this.pn_dssinhvien.ResumeLayout(false);
            this.pn_addsinhvien.ResumeLayout(false);
            this.grb_themsinhvien.ResumeLayout(false);
            this.table_themsinhvien.ResumeLayout(false);
            this.table_themsinhvien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel table_subheader;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_dssinhvien;
        private System.Windows.Forms.Panel pn_subheader;
        private System.Windows.Forms.GroupBox grb_dssinhvien;
        private System.Windows.Forms.DataGridView dgv_dssinhvien;
        private System.Windows.Forms.Panel pn_dssinhvien;
        private System.Windows.Forms.Panel pn_addsinhvien;
        private System.Windows.Forms.GroupBox grb_themsinhvien;
        private System.Windows.Forms.TableLayoutPanel table_themsinhvien;
        private System.Windows.Forms.Label lbl_mssv;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_malop;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.Label lb_tenlop;
    }
}