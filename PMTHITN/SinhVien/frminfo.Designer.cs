namespace PMTHITN
{
    partial class frminfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_header = new System.Windows.Forms.Panel();
            this.table_title = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.table_info = new System.Windows.Forms.TableLayoutPanel();
            this.grbtt = new System.Windows.Forms.GroupBox();
            this.table_thongtin = new System.Windows.Forms.TableLayoutPanel();
            this.lblthoigian = new System.Windows.Forms.Label();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lblsocau = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmonthi = new System.Windows.Forms.Label();
            this.lbl_socau = new System.Windows.Forms.Label();
            this.lbl_mssv = new System.Windows.Forms.Label();
            this.lblmsv = new System.Windows.Forms.Label();
            this.lbl_monthi = new System.Windows.Forms.Label();
            this.table_vaothi = new System.Windows.Forms.TableLayoutPanel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btnvaothi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.table_title.SuspendLayout();
            this.pn_content.SuspendLayout();
            this.table_info.SuspendLayout();
            this.grbtt.SuspendLayout();
            this.table_thongtin.SuspendLayout();
            this.table_vaothi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.pn_header);
            this.panel1.Controls.Add(this.pn_content);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 504);
            this.panel1.TabIndex = 0;
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.pn_header.Controls.Add(this.table_title);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(698, 82);
            this.pn_header.TabIndex = 2;
            // 
            // table_title
            // 
            this.table_title.ColumnCount = 1;
            this.table_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_title.Controls.Add(this.lbl_title, 0, 0);
            this.table_title.Location = new System.Drawing.Point(12, 13);
            this.table_title.Name = "table_title";
            this.table_title.RowCount = 1;
            this.table_title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_title.Size = new System.Drawing.Size(674, 53);
            this.table_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(162, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(349, 53);
            this.lbl_title.TabIndex = 32;
            this.lbl_title.Text = "TÊN BÀI KIỂM TRA";
            // 
            // pn_content
            // 
            this.pn_content.Controls.Add(this.table_info);
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 0);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(698, 504);
            this.pn_content.TabIndex = 3;
            // 
            // table_info
            // 
            this.table_info.ColumnCount = 1;
            this.table_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_info.Controls.Add(this.grbtt, 0, 0);
            this.table_info.Controls.Add(this.table_vaothi, 0, 1);
            this.table_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table_info.Location = new System.Drawing.Point(0, 88);
            this.table_info.Name = "table_info";
            this.table_info.RowCount = 2;
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_info.Size = new System.Drawing.Size(698, 416);
            this.table_info.TabIndex = 2;
            // 
            // grbtt
            // 
            this.grbtt.Controls.Add(this.table_thongtin);
            this.grbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtt.ForeColor = System.Drawing.Color.DarkSalmon;
            this.grbtt.Location = new System.Drawing.Point(3, 2);
            this.grbtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbtt.Name = "grbtt";
            this.grbtt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbtt.Size = new System.Drawing.Size(692, 306);
            this.grbtt.TabIndex = 30;
            this.grbtt.TabStop = false;
            this.grbtt.Text = "Thông tin:";
            // 
            // table_thongtin
            // 
            this.table_thongtin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.table_thongtin.ColumnCount = 2;
            this.table_thongtin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_thongtin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_thongtin.Controls.Add(this.lblthoigian, 1, 4);
            this.table_thongtin.Controls.Add(this.lbl_hoten, 0, 0);
            this.table_thongtin.Controls.Add(this.lbl_time, 0, 4);
            this.table_thongtin.Controls.Add(this.lblsocau, 1, 3);
            this.table_thongtin.Controls.Add(this.lblhoten, 1, 0);
            this.table_thongtin.Controls.Add(this.lblmonthi, 1, 2);
            this.table_thongtin.Controls.Add(this.lbl_socau, 0, 3);
            this.table_thongtin.Controls.Add(this.lbl_mssv, 0, 1);
            this.table_thongtin.Controls.Add(this.lblmsv, 1, 1);
            this.table_thongtin.Controls.Add(this.lbl_monthi, 0, 2);
            this.table_thongtin.Location = new System.Drawing.Point(43, 36);
            this.table_thongtin.Name = "table_thongtin";
            this.table_thongtin.RowCount = 5;
            this.table_thongtin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_thongtin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_thongtin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_thongtin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_thongtin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_thongtin.Size = new System.Drawing.Size(602, 261);
            this.table_thongtin.TabIndex = 1;
            // 
            // lblthoigian
            // 
            this.lblthoigian.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblthoigian.AutoSize = true;
            this.lblthoigian.BackColor = System.Drawing.Color.Transparent;
            this.lblthoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoigian.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblthoigian.Location = new System.Drawing.Point(399, 232);
            this.lblthoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(105, 29);
            this.lblthoigian.TabIndex = 29;
            this.lblthoigian.Text = "tglambai";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hoten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_hoten.Location = new System.Drawing.Point(106, 23);
            this.lbl_hoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(89, 29);
            this.lbl_hoten.TabIndex = 20;
            this.lbl_hoten.Text = "Họ tên:";
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_time.Location = new System.Drawing.Point(48, 232);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(204, 29);
            this.lbl_time.TabIndex = 24;
            this.lbl_time.Text = "Thời gian làm bài:";
            // 
            // lblsocau
            // 
            this.lblsocau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblsocau.AutoSize = true;
            this.lblsocau.BackColor = System.Drawing.Color.Transparent;
            this.lblsocau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsocau.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblsocau.Location = new System.Drawing.Point(413, 179);
            this.lblsocau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsocau.Name = "lblsocau";
            this.lblsocau.Size = new System.Drawing.Size(77, 29);
            this.lblsocau.TabIndex = 28;
            this.lblsocau.Text = "socau";
            // 
            // lblhoten
            // 
            this.lblhoten.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblhoten.AutoSize = true;
            this.lblhoten.BackColor = System.Drawing.Color.Transparent;
            this.lblhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblhoten.Location = new System.Drawing.Point(405, 23);
            this.lblhoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(93, 29);
            this.lblhoten.TabIndex = 25;
            this.lblhoten.Text = "Tên SV";
            // 
            // lblmonthi
            // 
            this.lblmonthi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblmonthi.AutoSize = true;
            this.lblmonthi.BackColor = System.Drawing.Color.Transparent;
            this.lblmonthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthi.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblmonthi.Location = new System.Drawing.Point(400, 127);
            this.lblmonthi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmonthi.Name = "lblmonthi";
            this.lblmonthi.Size = new System.Drawing.Size(103, 29);
            this.lblmonthi.TabIndex = 27;
            this.lblmonthi.Text = "Tenmon";
            // 
            // lbl_socau
            // 
            this.lbl_socau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_socau.AutoSize = true;
            this.lbl_socau.BackColor = System.Drawing.Color.Transparent;
            this.lbl_socau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_socau.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_socau.Location = new System.Drawing.Point(104, 179);
            this.lbl_socau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_socau.Name = "lbl_socau";
            this.lbl_socau.Size = new System.Drawing.Size(93, 29);
            this.lbl_socau.TabIndex = 23;
            this.lbl_socau.Text = "Số câu:";
            // 
            // lbl_mssv
            // 
            this.lbl_mssv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_mssv.AutoSize = true;
            this.lbl_mssv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mssv.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_mssv.Location = new System.Drawing.Point(74, 75);
            this.lbl_mssv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mssv.Name = "lbl_mssv";
            this.lbl_mssv.Size = new System.Drawing.Size(152, 29);
            this.lbl_mssv.TabIndex = 21;
            this.lbl_mssv.Text = "Mã sinh viên:";
            // 
            // lblmsv
            // 
            this.lblmsv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblmsv.AutoSize = true;
            this.lblmsv.BackColor = System.Drawing.Color.Transparent;
            this.lblmsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsv.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblmsv.Location = new System.Drawing.Point(413, 75);
            this.lblmsv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmsv.Name = "lblmsv";
            this.lblmsv.Size = new System.Drawing.Size(77, 29);
            this.lblmsv.TabIndex = 26;
            this.lblmsv.Text = "MaSV";
            // 
            // lbl_monthi
            // 
            this.lbl_monthi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_monthi.AutoSize = true;
            this.lbl_monthi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_monthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthi.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_monthi.Location = new System.Drawing.Point(102, 127);
            this.lbl_monthi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_monthi.Name = "lbl_monthi";
            this.lbl_monthi.Size = new System.Drawing.Size(97, 29);
            this.lbl_monthi.TabIndex = 22;
            this.lbl_monthi.Text = "Môn thi:";
            // 
            // table_vaothi
            // 
            this.table_vaothi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.table_vaothi.ColumnCount = 2;
            this.table_vaothi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_vaothi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_vaothi.Controls.Add(this.btn_thoat, 0, 0);
            this.table_vaothi.Controls.Add(this.btnvaothi, 0, 0);
            this.table_vaothi.Location = new System.Drawing.Point(124, 333);
            this.table_vaothi.Name = "table_vaothi";
            this.table_vaothi.RowCount = 1;
            this.table_vaothi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_vaothi.Size = new System.Drawing.Size(449, 80);
            this.table_vaothi.TabIndex = 31;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_thoat.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(242, 2);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(188, 62);
            this.btn_thoat.TabIndex = 33;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btnvaothi
            // 
            this.btnvaothi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnvaothi.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnvaothi.FlatAppearance.BorderSize = 0;
            this.btnvaothi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvaothi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvaothi.ForeColor = System.Drawing.Color.White;
            this.btnvaothi.Location = new System.Drawing.Point(18, 2);
            this.btnvaothi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvaothi.Name = "btnvaothi";
            this.btnvaothi.Size = new System.Drawing.Size(188, 62);
            this.btnvaothi.TabIndex = 32;
            this.btnvaothi.Text = "Vào thi";
            this.btnvaothi.UseVisualStyleBackColor = false;
            this.btnvaothi.Click += new System.EventHandler(this.btnvaothi_Click);
            // 
            // frminfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(728, 534);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frminfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frminfo";
            this.Load += new System.EventHandler(this.frminfo_Load);
            this.panel1.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            this.table_title.ResumeLayout(false);
            this.table_title.PerformLayout();
            this.pn_content.ResumeLayout(false);
            this.table_info.ResumeLayout(false);
            this.grbtt.ResumeLayout(false);
            this.table_thongtin.ResumeLayout(false);
            this.table_thongtin.PerformLayout();
            this.table_vaothi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.TableLayoutPanel table_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel table_info;
        private System.Windows.Forms.GroupBox grbtt;
        private System.Windows.Forms.TableLayoutPanel table_thongtin;
        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lblsocau;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmonthi;
        private System.Windows.Forms.Label lbl_socau;
        private System.Windows.Forms.Label lbl_mssv;
        private System.Windows.Forms.Label lblmsv;
        private System.Windows.Forms.Label lbl_monthi;
        private System.Windows.Forms.TableLayoutPanel table_vaothi;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btnvaothi;
    }
}