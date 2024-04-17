namespace PMTHITN
{
    partial class frmgv
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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_quanly = new System.Windows.Forms.TabPage();
            this.pn_exitquanly = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pn_contentquanly = new System.Windows.Forms.Panel();
            this.pn_navquanly = new System.Windows.Forms.Panel();
            this.table_nav = new System.Windows.Forms.TableLayoutPanel();
            this.pn_nhcauhoi = new System.Windows.Forms.Panel();
            this.pic_nhcauhoi = new System.Windows.Forms.PictureBox();
            this.pn_kiemtra = new System.Windows.Forms.Panel();
            this.pic_kiemtra = new System.Windows.Forms.PictureBox();
            this.pn_lophoc = new System.Windows.Forms.Panel();
            this.pic_lophoc = new System.Windows.Forms.PictureBox();
            this.pn_monhoc = new System.Windows.Forms.Panel();
            this.pic_monhoc = new System.Windows.Forms.PictureBox();
            this.tab_lskiemtra = new System.Windows.Forms.TabPage();
            this.pn_exitlskiemtra = new System.Windows.Forms.Panel();
            this.btn_exitlskiemtra = new System.Windows.Forms.Button();
            this.pn_contentlskiemtra = new System.Windows.Forms.Panel();
            this.dgv_lskiemtra = new System.Windows.Forms.DataGridView();
            this.pn_navlskiemtra = new System.Windows.Forms.Panel();
            this.table_title = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tab_thongtin = new System.Windows.Forms.TabPage();
            this.pn_doimatkhau = new System.Windows.Forms.Panel();
            this.btn_exitinfogv = new System.Windows.Forms.Button();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.lbl_doimatkhau = new System.Windows.Forms.Label();
            this.table_doimatkhau = new System.Windows.Forms.TableLayoutPanel();
            this.txt_matkhaumoi = new System.Windows.Forms.TextBox();
            this.lbl_matkhaucu = new System.Windows.Forms.Label();
            this.txt_matkhaucu = new System.Windows.Forms.TextBox();
            this.lbl_matkhaumoi = new System.Windows.Forms.Label();
            this.pn_detailinfo = new System.Windows.Forms.Panel();
            this.lbl_thongtin = new System.Windows.Forms.Label();
            this.table_user = new System.Windows.Forms.TableLayoutPanel();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.lbl_taikhoan = new System.Windows.Forms.Label();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.table_detailInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_mgv = new System.Windows.Forms.Label();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_mgv = new System.Windows.Forms.TextBox();
            this.pn_infogv = new System.Windows.Forms.Panel();
            this.table_info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_infogv = new System.Windows.Forms.Label();
            this.tab_control.SuspendLayout();
            this.tab_quanly.SuspendLayout();
            this.pn_exitquanly.SuspendLayout();
            this.pn_navquanly.SuspendLayout();
            this.table_nav.SuspendLayout();
            this.pn_nhcauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nhcauhoi)).BeginInit();
            this.pn_kiemtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kiemtra)).BeginInit();
            this.pn_lophoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lophoc)).BeginInit();
            this.pn_monhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_monhoc)).BeginInit();
            this.tab_lskiemtra.SuspendLayout();
            this.pn_exitlskiemtra.SuspendLayout();
            this.pn_contentlskiemtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lskiemtra)).BeginInit();
            this.pn_navlskiemtra.SuspendLayout();
            this.table_title.SuspendLayout();
            this.tab_thongtin.SuspendLayout();
            this.pn_doimatkhau.SuspendLayout();
            this.table_doimatkhau.SuspendLayout();
            this.pn_detailinfo.SuspendLayout();
            this.table_user.SuspendLayout();
            this.table_detailInfo.SuspendLayout();
            this.pn_infogv.SuspendLayout();
            this.table_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_quanly);
            this.tab_control.Controls.Add(this.tab_lskiemtra);
            this.tab_control.Controls.Add(this.tab_thongtin);
            this.tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_control.Location = new System.Drawing.Point(0, 0);
            this.tab_control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_control.Name = "tab_control";
            this.tab_control.Padding = new System.Drawing.Point(20, 3);
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1005, 600);
            this.tab_control.TabIndex = 0;
            this.tab_control.SelectedIndexChanged += new System.EventHandler(this.tab_control_SelectedIndexChanged);
            // 
            // tab_quanly
            // 
            this.tab_quanly.Controls.Add(this.pn_exitquanly);
            this.tab_quanly.Controls.Add(this.pn_contentquanly);
            this.tab_quanly.Controls.Add(this.pn_navquanly);
            this.tab_quanly.Location = new System.Drawing.Point(4, 37);
            this.tab_quanly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_quanly.Name = "tab_quanly";
            this.tab_quanly.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_quanly.Size = new System.Drawing.Size(997, 559);
            this.tab_quanly.TabIndex = 0;
            this.tab_quanly.Text = "Quản lý";
            this.tab_quanly.UseVisualStyleBackColor = true;
            // 
            // pn_exitquanly
            // 
            this.pn_exitquanly.BackColor = System.Drawing.Color.SeaShell;
            this.pn_exitquanly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_exitquanly.Controls.Add(this.btn_exit);
            this.pn_exitquanly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_exitquanly.Location = new System.Drawing.Point(3, 509);
            this.pn_exitquanly.Name = "pn_exitquanly";
            this.pn_exitquanly.Size = new System.Drawing.Size(991, 46);
            this.pn_exitquanly.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_exit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(897, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(90, 40);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pn_contentquanly
            // 
            this.pn_contentquanly.BackColor = System.Drawing.Color.SeaShell;
            this.pn_contentquanly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_contentquanly.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_contentquanly.Location = new System.Drawing.Point(3, 89);
            this.pn_contentquanly.Name = "pn_contentquanly";
            this.pn_contentquanly.Size = new System.Drawing.Size(991, 420);
            this.pn_contentquanly.TabIndex = 1;
            // 
            // pn_navquanly
            // 
            this.pn_navquanly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.pn_navquanly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_navquanly.Controls.Add(this.table_nav);
            this.pn_navquanly.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_navquanly.Location = new System.Drawing.Point(3, 4);
            this.pn_navquanly.Name = "pn_navquanly";
            this.pn_navquanly.Size = new System.Drawing.Size(991, 85);
            this.pn_navquanly.TabIndex = 0;
            // 
            // table_nav
            // 
            this.table_nav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_nav.ColumnCount = 4;
            this.table_nav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_nav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_nav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_nav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_nav.Controls.Add(this.pn_nhcauhoi, 3, 0);
            this.table_nav.Controls.Add(this.pn_kiemtra, 2, 0);
            this.table_nav.Controls.Add(this.pn_lophoc, 1, 0);
            this.table_nav.Controls.Add(this.pn_monhoc, 0, 0);
            this.table_nav.Location = new System.Drawing.Point(4, 7);
            this.table_nav.Name = "table_nav";
            this.table_nav.RowCount = 1;
            this.table_nav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_nav.Size = new System.Drawing.Size(581, 69);
            this.table_nav.TabIndex = 0;
            // 
            // pn_nhcauhoi
            // 
            this.pn_nhcauhoi.Controls.Add(this.pic_nhcauhoi);
            this.pn_nhcauhoi.Location = new System.Drawing.Point(438, 3);
            this.pn_nhcauhoi.Name = "pn_nhcauhoi";
            this.pn_nhcauhoi.Size = new System.Drawing.Size(140, 63);
            this.pn_nhcauhoi.TabIndex = 3;
            // 
            // pic_nhcauhoi
            // 
            this.pic_nhcauhoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_nhcauhoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_nhcauhoi.Image = global::PMTHITN.Properties.Resources.listexam;
            this.pic_nhcauhoi.Location = new System.Drawing.Point(40, 3);
            this.pic_nhcauhoi.Name = "pic_nhcauhoi";
            this.pic_nhcauhoi.Size = new System.Drawing.Size(60, 60);
            this.pic_nhcauhoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nhcauhoi.TabIndex = 3;
            this.pic_nhcauhoi.TabStop = false;
            this.pic_nhcauhoi.Click += new System.EventHandler(this.pic_lskiemtra_Click);
            // 
            // pn_kiemtra
            // 
            this.pn_kiemtra.Controls.Add(this.pic_kiemtra);
            this.pn_kiemtra.Location = new System.Drawing.Point(293, 3);
            this.pn_kiemtra.Name = "pn_kiemtra";
            this.pn_kiemtra.Size = new System.Drawing.Size(139, 63);
            this.pn_kiemtra.TabIndex = 2;
            // 
            // pic_kiemtra
            // 
            this.pic_kiemtra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_kiemtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_kiemtra.Image = global::PMTHITN.Properties.Resources.kiemtra;
            this.pic_kiemtra.Location = new System.Drawing.Point(41, 3);
            this.pic_kiemtra.Name = "pic_kiemtra";
            this.pic_kiemtra.Size = new System.Drawing.Size(60, 60);
            this.pic_kiemtra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_kiemtra.TabIndex = 2;
            this.pic_kiemtra.TabStop = false;
            this.pic_kiemtra.Click += new System.EventHandler(this.pic_kiemtra_Click);
            // 
            // pn_lophoc
            // 
            this.pn_lophoc.Controls.Add(this.pic_lophoc);
            this.pn_lophoc.Location = new System.Drawing.Point(148, 3);
            this.pn_lophoc.Name = "pn_lophoc";
            this.pn_lophoc.Size = new System.Drawing.Size(139, 63);
            this.pn_lophoc.TabIndex = 1;
            // 
            // pic_lophoc
            // 
            this.pic_lophoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_lophoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_lophoc.Image = global::PMTHITN.Properties.Resources.lhoc;
            this.pic_lophoc.Location = new System.Drawing.Point(39, 3);
            this.pic_lophoc.Name = "pic_lophoc";
            this.pic_lophoc.Size = new System.Drawing.Size(60, 60);
            this.pic_lophoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_lophoc.TabIndex = 1;
            this.pic_lophoc.TabStop = false;
            this.pic_lophoc.Click += new System.EventHandler(this.pic_lophoc_Click);
            // 
            // pn_monhoc
            // 
            this.pn_monhoc.Controls.Add(this.pic_monhoc);
            this.pn_monhoc.Location = new System.Drawing.Point(3, 3);
            this.pn_monhoc.Name = "pn_monhoc";
            this.pn_monhoc.Size = new System.Drawing.Size(139, 63);
            this.pn_monhoc.TabIndex = 0;
            // 
            // pic_monhoc
            // 
            this.pic_monhoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_monhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_monhoc.Image = global::PMTHITN.Properties.Resources.monhoc;
            this.pic_monhoc.Location = new System.Drawing.Point(39, 3);
            this.pic_monhoc.Name = "pic_monhoc";
            this.pic_monhoc.Size = new System.Drawing.Size(60, 60);
            this.pic_monhoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_monhoc.TabIndex = 0;
            this.pic_monhoc.TabStop = false;
            this.pic_monhoc.Click += new System.EventHandler(this.pic_monhoc_Click);
            // 
            // tab_lskiemtra
            // 
            this.tab_lskiemtra.BackColor = System.Drawing.Color.SeaShell;
            this.tab_lskiemtra.Controls.Add(this.pn_exitlskiemtra);
            this.tab_lskiemtra.Controls.Add(this.pn_contentlskiemtra);
            this.tab_lskiemtra.Controls.Add(this.pn_navlskiemtra);
            this.tab_lskiemtra.Location = new System.Drawing.Point(4, 37);
            this.tab_lskiemtra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_lskiemtra.Name = "tab_lskiemtra";
            this.tab_lskiemtra.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_lskiemtra.Size = new System.Drawing.Size(997, 559);
            this.tab_lskiemtra.TabIndex = 1;
            this.tab_lskiemtra.Text = "Lịch sử kiểm tra";
            // 
            // pn_exitlskiemtra
            // 
            this.pn_exitlskiemtra.BackColor = System.Drawing.Color.SeaShell;
            this.pn_exitlskiemtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_exitlskiemtra.Controls.Add(this.btn_exitlskiemtra);
            this.pn_exitlskiemtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_exitlskiemtra.Location = new System.Drawing.Point(3, 508);
            this.pn_exitlskiemtra.Name = "pn_exitlskiemtra";
            this.pn_exitlskiemtra.Size = new System.Drawing.Size(991, 47);
            this.pn_exitlskiemtra.TabIndex = 3;
            // 
            // btn_exitlskiemtra
            // 
            this.btn_exitlskiemtra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_exitlskiemtra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_exitlskiemtra.FlatAppearance.BorderSize = 0;
            this.btn_exitlskiemtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitlskiemtra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitlskiemtra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exitlskiemtra.Location = new System.Drawing.Point(897, 2);
            this.btn_exitlskiemtra.Name = "btn_exitlskiemtra";
            this.btn_exitlskiemtra.Size = new System.Drawing.Size(90, 40);
            this.btn_exitlskiemtra.TabIndex = 9;
            this.btn_exitlskiemtra.Text = "Thoát";
            this.btn_exitlskiemtra.UseVisualStyleBackColor = false;
            this.btn_exitlskiemtra.Click += new System.EventHandler(this.btn_exitlskiemtra_Click);
            // 
            // pn_contentlskiemtra
            // 
            this.pn_contentlskiemtra.BackColor = System.Drawing.Color.SeaShell;
            this.pn_contentlskiemtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_contentlskiemtra.Controls.Add(this.dgv_lskiemtra);
            this.pn_contentlskiemtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_contentlskiemtra.Location = new System.Drawing.Point(3, 88);
            this.pn_contentlskiemtra.Name = "pn_contentlskiemtra";
            this.pn_contentlskiemtra.Size = new System.Drawing.Size(991, 420);
            this.pn_contentlskiemtra.TabIndex = 2;
            // 
            // dgv_lskiemtra
            // 
            this.dgv_lskiemtra.AllowUserToAddRows = false;
            this.dgv_lskiemtra.AllowUserToDeleteRows = false;
            this.dgv_lskiemtra.AllowUserToResizeColumns = false;
            this.dgv_lskiemtra.AllowUserToResizeRows = false;
            this.dgv_lskiemtra.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_lskiemtra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_lskiemtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lskiemtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_lskiemtra.Location = new System.Drawing.Point(0, 0);
            this.dgv_lskiemtra.Name = "dgv_lskiemtra";
            this.dgv_lskiemtra.RowHeadersWidth = 51;
            this.dgv_lskiemtra.RowTemplate.Height = 24;
            this.dgv_lskiemtra.Size = new System.Drawing.Size(989, 418);
            this.dgv_lskiemtra.TabIndex = 0;
            this.dgv_lskiemtra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lskiemtra_CellContentClick);
            // 
            // pn_navlskiemtra
            // 
            this.pn_navlskiemtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.pn_navlskiemtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_navlskiemtra.Controls.Add(this.table_title);
            this.pn_navlskiemtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_navlskiemtra.Location = new System.Drawing.Point(3, 4);
            this.pn_navlskiemtra.Name = "pn_navlskiemtra";
            this.pn_navlskiemtra.Size = new System.Drawing.Size(991, 84);
            this.pn_navlskiemtra.TabIndex = 1;
            // 
            // table_title
            // 
            this.table_title.ColumnCount = 1;
            this.table_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_title.Controls.Add(this.lbl_title, 0, 0);
            this.table_title.Location = new System.Drawing.Point(4, 15);
            this.table_title.Name = "table_title";
            this.table_title.RowCount = 1;
            this.table_title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_title.Size = new System.Drawing.Size(981, 53);
            this.table_title.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(315, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(350, 53);
            this.lbl_title.TabIndex = 31;
            this.lbl_title.Text = "CÁC BÀI KIỂM TRA";
            // 
            // tab_thongtin
            // 
            this.tab_thongtin.BackColor = System.Drawing.Color.SeaShell;
            this.tab_thongtin.Controls.Add(this.pn_doimatkhau);
            this.tab_thongtin.Controls.Add(this.pn_detailinfo);
            this.tab_thongtin.Controls.Add(this.pn_infogv);
            this.tab_thongtin.Location = new System.Drawing.Point(4, 37);
            this.tab_thongtin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_thongtin.Name = "tab_thongtin";
            this.tab_thongtin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_thongtin.Size = new System.Drawing.Size(997, 559);
            this.tab_thongtin.TabIndex = 2;
            this.tab_thongtin.Text = "Thông tin cá nhân";
            // 
            // pn_doimatkhau
            // 
            this.pn_doimatkhau.BackColor = System.Drawing.Color.SeaShell;
            this.pn_doimatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_doimatkhau.Controls.Add(this.btn_exitinfogv);
            this.pn_doimatkhau.Controls.Add(this.btn_doimatkhau);
            this.pn_doimatkhau.Controls.Add(this.lbl_doimatkhau);
            this.pn_doimatkhau.Controls.Add(this.table_doimatkhau);
            this.pn_doimatkhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_doimatkhau.Location = new System.Drawing.Point(3, 300);
            this.pn_doimatkhau.Name = "pn_doimatkhau";
            this.pn_doimatkhau.Size = new System.Drawing.Size(991, 255);
            this.pn_doimatkhau.TabIndex = 3;
            // 
            // btn_exitinfogv
            // 
            this.btn_exitinfogv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_exitinfogv.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_exitinfogv.FlatAppearance.BorderSize = 0;
            this.btn_exitinfogv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitinfogv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitinfogv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exitinfogv.Location = new System.Drawing.Point(897, 210);
            this.btn_exitinfogv.Name = "btn_exitinfogv";
            this.btn_exitinfogv.Size = new System.Drawing.Size(90, 40);
            this.btn_exitinfogv.TabIndex = 8;
            this.btn_exitinfogv.Text = "Thoát";
            this.btn_exitinfogv.UseVisualStyleBackColor = false;
            this.btn_exitinfogv.Click += new System.EventHandler(this.btn_exitinfogv_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_doimatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.btn_doimatkhau.FlatAppearance.BorderSize = 0;
            this.btn_doimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doimatkhau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doimatkhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doimatkhau.Location = new System.Drawing.Point(818, 123);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(166, 40);
            this.btn_doimatkhau.TabIndex = 7;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = false;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_giangvien_Click);
            // 
            // lbl_doimatkhau
            // 
            this.lbl_doimatkhau.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_doimatkhau.AutoSize = true;
            this.lbl_doimatkhau.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doimatkhau.Location = new System.Drawing.Point(17, 2);
            this.lbl_doimatkhau.Name = "lbl_doimatkhau";
            this.lbl_doimatkhau.Size = new System.Drawing.Size(183, 37);
            this.lbl_doimatkhau.TabIndex = 6;
            this.lbl_doimatkhau.Text = "Đổi mật khẩu";
            // 
            // table_doimatkhau
            // 
            this.table_doimatkhau.ColumnCount = 4;
            this.table_doimatkhau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.table_doimatkhau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.table_doimatkhau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.table_doimatkhau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.table_doimatkhau.Controls.Add(this.txt_matkhaumoi, 3, 0);
            this.table_doimatkhau.Controls.Add(this.lbl_matkhaucu, 0, 0);
            this.table_doimatkhau.Controls.Add(this.txt_matkhaucu, 1, 0);
            this.table_doimatkhau.Controls.Add(this.lbl_matkhaumoi, 2, 0);
            this.table_doimatkhau.Location = new System.Drawing.Point(4, 50);
            this.table_doimatkhau.Name = "table_doimatkhau";
            this.table_doimatkhau.RowCount = 1;
            this.table_doimatkhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_doimatkhau.Size = new System.Drawing.Size(980, 67);
            this.table_doimatkhau.TabIndex = 5;
            // 
            // txt_matkhaumoi
            // 
            this.txt_matkhaumoi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_matkhaumoi.Location = new System.Drawing.Point(665, 15);
            this.txt_matkhaumoi.Name = "txt_matkhaumoi";
            this.txt_matkhaumoi.PasswordChar = '*';
            this.txt_matkhaumoi.Size = new System.Drawing.Size(281, 36);
            this.txt_matkhaumoi.TabIndex = 4;
            // 
            // lbl_matkhaucu
            // 
            this.lbl_matkhaucu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_matkhaucu.AutoSize = true;
            this.lbl_matkhaucu.Location = new System.Drawing.Point(31, 19);
            this.lbl_matkhaucu.Name = "lbl_matkhaucu";
            this.lbl_matkhaucu.Size = new System.Drawing.Size(128, 28);
            this.lbl_matkhaucu.TabIndex = 1;
            this.lbl_matkhaucu.Text = "Mật khẩu cũ";
            // 
            // txt_matkhaucu
            // 
            this.txt_matkhaucu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_matkhaucu.Location = new System.Drawing.Point(165, 15);
            this.txt_matkhaucu.Name = "txt_matkhaucu";
            this.txt_matkhaucu.PasswordChar = '*';
            this.txt_matkhaucu.Size = new System.Drawing.Size(281, 36);
            this.txt_matkhaucu.TabIndex = 3;
            // 
            // lbl_matkhaumoi
            // 
            this.lbl_matkhaumoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_matkhaumoi.AutoSize = true;
            this.lbl_matkhaumoi.Location = new System.Drawing.Point(500, 5);
            this.lbl_matkhaumoi.Name = "lbl_matkhaumoi";
            this.lbl_matkhaumoi.Size = new System.Drawing.Size(159, 56);
            this.lbl_matkhaumoi.TabIndex = 0;
            this.lbl_matkhaumoi.Text = "Nhập mật khẩu mới";
            // 
            // pn_detailinfo
            // 
            this.pn_detailinfo.BackColor = System.Drawing.Color.SeaShell;
            this.pn_detailinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_detailinfo.Controls.Add(this.lbl_thongtin);
            this.pn_detailinfo.Controls.Add(this.table_user);
            this.pn_detailinfo.Controls.Add(this.table_detailInfo);
            this.pn_detailinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_detailinfo.Location = new System.Drawing.Point(3, 89);
            this.pn_detailinfo.Name = "pn_detailinfo";
            this.pn_detailinfo.Size = new System.Drawing.Size(991, 211);
            this.pn_detailinfo.TabIndex = 2;
            // 
            // lbl_thongtin
            // 
            this.lbl_thongtin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_thongtin.AutoSize = true;
            this.lbl_thongtin.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtin.Location = new System.Drawing.Point(17, 2);
            this.lbl_thongtin.Name = "lbl_thongtin";
            this.lbl_thongtin.Size = new System.Drawing.Size(135, 37);
            this.lbl_thongtin.TabIndex = 5;
            this.lbl_thongtin.Text = "Thông tin";
            // 
            // table_user
            // 
            this.table_user.ColumnCount = 4;
            this.table_user.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.table_user.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.table_user.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.table_user.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.table_user.Controls.Add(this.txt_matkhau, 3, 0);
            this.table_user.Controls.Add(this.lbl_taikhoan, 0, 0);
            this.table_user.Controls.Add(this.lbl_matkhau, 2, 0);
            this.table_user.Controls.Add(this.txt_taikhoan, 1, 0);
            this.table_user.Location = new System.Drawing.Point(4, 101);
            this.table_user.Name = "table_user";
            this.table_user.RowCount = 1;
            this.table_user.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_user.Size = new System.Drawing.Size(980, 67);
            this.table_user.TabIndex = 4;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_matkhau.Location = new System.Drawing.Point(589, 15);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.ReadOnly = true;
            this.txt_matkhau.Size = new System.Drawing.Size(281, 36);
            this.txt_matkhau.TabIndex = 4;
            // 
            // lbl_taikhoan
            // 
            this.lbl_taikhoan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_taikhoan.AutoSize = true;
            this.lbl_taikhoan.Location = new System.Drawing.Point(180, 19);
            this.lbl_taikhoan.Name = "lbl_taikhoan";
            this.lbl_taikhoan.Size = new System.Drawing.Size(99, 28);
            this.lbl_taikhoan.TabIndex = 1;
            this.lbl_taikhoan.Text = "Tài khoản";
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Location = new System.Drawing.Point(482, 19);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(101, 28);
            this.lbl_matkhau.TabIndex = 0;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_taikhoan.Location = new System.Drawing.Point(285, 15);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.ReadOnly = true;
            this.txt_taikhoan.Size = new System.Drawing.Size(100, 36);
            this.txt_taikhoan.TabIndex = 3;
            // 
            // table_detailInfo
            // 
            this.table_detailInfo.ColumnCount = 6;
            this.table_detailInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.table_detailInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.table_detailInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.table_detailInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.table_detailInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.table_detailInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.table_detailInfo.Controls.Add(this.txt_khoa, 5, 0);
            this.table_detailInfo.Controls.Add(this.txt_name, 3, 0);
            this.table_detailInfo.Controls.Add(this.lbl_mgv, 0, 0);
            this.table_detailInfo.Controls.Add(this.lbl_khoa, 4, 0);
            this.table_detailInfo.Controls.Add(this.lbl_name, 2, 0);
            this.table_detailInfo.Controls.Add(this.txt_mgv, 1, 0);
            this.table_detailInfo.Location = new System.Drawing.Point(5, 33);
            this.table_detailInfo.Name = "table_detailInfo";
            this.table_detailInfo.RowCount = 1;
            this.table_detailInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_detailInfo.Size = new System.Drawing.Size(980, 67);
            this.table_detailInfo.TabIndex = 3;
            // 
            // txt_khoa
            // 
            this.txt_khoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_khoa.Location = new System.Drawing.Point(813, 15);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.ReadOnly = true;
            this.txt_khoa.Size = new System.Drawing.Size(136, 36);
            this.txt_khoa.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_name.Location = new System.Drawing.Point(408, 15);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(281, 36);
            this.txt_name.TabIndex = 4;
            // 
            // lbl_mgv
            // 
            this.lbl_mgv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_mgv.AutoSize = true;
            this.lbl_mgv.Location = new System.Drawing.Point(14, 19);
            this.lbl_mgv.Name = "lbl_mgv";
            this.lbl_mgv.Size = new System.Drawing.Size(130, 28);
            this.lbl_mgv.TabIndex = 1;
            this.lbl_mgv.Text = "Mã giáo viên";
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.Location = new System.Drawing.Point(713, 19);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(94, 28);
            this.lbl_khoa.TabIndex = 2;
            this.lbl_khoa.Text = "Tên khoa";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(271, 19);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(131, 28);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Tên giáo viên";
            // 
            // txt_mgv
            // 
            this.txt_mgv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_mgv.Location = new System.Drawing.Point(150, 15);
            this.txt_mgv.Name = "txt_mgv";
            this.txt_mgv.ReadOnly = true;
            this.txt_mgv.Size = new System.Drawing.Size(100, 36);
            this.txt_mgv.TabIndex = 3;
            // 
            // pn_infogv
            // 
            this.pn_infogv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.pn_infogv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_infogv.Controls.Add(this.table_info);
            this.pn_infogv.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_infogv.Location = new System.Drawing.Point(3, 4);
            this.pn_infogv.Name = "pn_infogv";
            this.pn_infogv.Size = new System.Drawing.Size(991, 85);
            this.pn_infogv.TabIndex = 1;
            // 
            // table_info
            // 
            this.table_info.ColumnCount = 1;
            this.table_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_info.Controls.Add(this.lbl_infogv, 0, 0);
            this.table_info.Location = new System.Drawing.Point(5, 3);
            this.table_info.Name = "table_info";
            this.table_info.RowCount = 1;
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_info.Size = new System.Drawing.Size(981, 58);
            this.table_info.TabIndex = 0;
            // 
            // lbl_infogv
            // 
            this.lbl_infogv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_infogv.AutoSize = true;
            this.lbl_infogv.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infogv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_infogv.Location = new System.Drawing.Point(266, 5);
            this.lbl_infogv.Name = "lbl_infogv";
            this.lbl_infogv.Size = new System.Drawing.Size(449, 53);
            this.lbl_infogv.TabIndex = 1;
            this.lbl_infogv.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // frmgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 600);
            this.Controls.Add(this.tab_control);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmgv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng viên";
            this.tab_control.ResumeLayout(false);
            this.tab_quanly.ResumeLayout(false);
            this.pn_exitquanly.ResumeLayout(false);
            this.pn_navquanly.ResumeLayout(false);
            this.table_nav.ResumeLayout(false);
            this.pn_nhcauhoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_nhcauhoi)).EndInit();
            this.pn_kiemtra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_kiemtra)).EndInit();
            this.pn_lophoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_lophoc)).EndInit();
            this.pn_monhoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_monhoc)).EndInit();
            this.tab_lskiemtra.ResumeLayout(false);
            this.pn_exitlskiemtra.ResumeLayout(false);
            this.pn_contentlskiemtra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lskiemtra)).EndInit();
            this.pn_navlskiemtra.ResumeLayout(false);
            this.table_title.ResumeLayout(false);
            this.table_title.PerformLayout();
            this.tab_thongtin.ResumeLayout(false);
            this.pn_doimatkhau.ResumeLayout(false);
            this.pn_doimatkhau.PerformLayout();
            this.table_doimatkhau.ResumeLayout(false);
            this.table_doimatkhau.PerformLayout();
            this.pn_detailinfo.ResumeLayout(false);
            this.pn_detailinfo.PerformLayout();
            this.table_user.ResumeLayout(false);
            this.table_user.PerformLayout();
            this.table_detailInfo.ResumeLayout(false);
            this.table_detailInfo.PerformLayout();
            this.pn_infogv.ResumeLayout(false);
            this.table_info.ResumeLayout(false);
            this.table_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_quanly;
        private System.Windows.Forms.TabPage tab_lskiemtra;
        private System.Windows.Forms.TabPage tab_thongtin;
        private System.Windows.Forms.Panel pn_contentquanly;
        private System.Windows.Forms.Panel pn_navquanly;
        private System.Windows.Forms.TableLayoutPanel table_nav;
        private System.Windows.Forms.PictureBox pic_nhcauhoi;
        private System.Windows.Forms.PictureBox pic_kiemtra;
        private System.Windows.Forms.PictureBox pic_lophoc;
        private System.Windows.Forms.PictureBox pic_monhoc;
        private System.Windows.Forms.Panel pn_navlskiemtra;
        private System.Windows.Forms.Panel pn_doimatkhau;
        private System.Windows.Forms.Panel pn_detailinfo;
        private System.Windows.Forms.TableLayoutPanel table_user;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label lbl_taikhoan;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TableLayoutPanel table_detailInfo;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_mgv;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_mgv;
        private System.Windows.Forms.Panel pn_infogv;
        private System.Windows.Forms.TableLayoutPanel table_info;
        private System.Windows.Forms.Label lbl_infogv;
        private System.Windows.Forms.TableLayoutPanel table_doimatkhau;
        private System.Windows.Forms.TextBox txt_matkhaumoi;
        private System.Windows.Forms.Label lbl_matkhaucu;
        private System.Windows.Forms.Label lbl_matkhaumoi;
        private System.Windows.Forms.TextBox txt_matkhaucu;
        private System.Windows.Forms.Label lbl_doimatkhau;
        private System.Windows.Forms.Label lbl_thongtin;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_exitinfogv;
        private System.Windows.Forms.Button btn_doimatkhau;
        private System.Windows.Forms.Panel pn_contentlskiemtra;
        private System.Windows.Forms.Button btn_exitlskiemtra;
        private System.Windows.Forms.Panel pn_exitquanly;
        private System.Windows.Forms.Panel pn_exitlskiemtra;
        private System.Windows.Forms.Panel pn_nhcauhoi;
        private System.Windows.Forms.Panel pn_kiemtra;
        private System.Windows.Forms.Panel pn_lophoc;
        private System.Windows.Forms.Panel pn_monhoc;
        private System.Windows.Forms.DataGridView dgv_lskiemtra;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel table_title;
    }
}