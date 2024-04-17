namespace PMTHITN
{
    partial class frmlogin
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
            this.components = new System.ComponentModel.Container();
            this.pn_dangnhap = new System.Windows.Forms.Panel();
            this.pic_UEH = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.pn_taikhoan = new System.Windows.Forms.Panel();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.pic_taikhoan = new System.Windows.Forms.PictureBox();
            this.linklbl_quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.lbl_tendangnhap = new System.Windows.Forms.Label();
            this.lbl_makhau = new System.Windows.Forms.Label();
            this.pn_matkhau = new System.Windows.Forms.Panel();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.pic_matkhau = new System.Windows.Forms.PictureBox();
            this.pn_slide = new System.Windows.Forms.Panel();
            this.pic_slideanh = new System.Windows.Forms.PictureBox();
            this.timer_slideanh = new System.Windows.Forms.Timer(this.components);
            this.pn_dangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UEH)).BeginInit();
            this.pn_taikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_taikhoan)).BeginInit();
            this.pn_matkhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_matkhau)).BeginInit();
            this.pn_slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_slideanh)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_dangnhap
            // 
            this.pn_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.pn_dangnhap.Controls.Add(this.pic_UEH);
            this.pn_dangnhap.Controls.Add(this.btn_exit);
            this.pn_dangnhap.Controls.Add(this.btn_dangnhap);
            this.pn_dangnhap.Controls.Add(this.pn_taikhoan);
            this.pn_dangnhap.Controls.Add(this.linklbl_quenmatkhau);
            this.pn_dangnhap.Controls.Add(this.lbl_tendangnhap);
            this.pn_dangnhap.Controls.Add(this.lbl_makhau);
            this.pn_dangnhap.Controls.Add(this.pn_matkhau);
            this.pn_dangnhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_dangnhap.Location = new System.Drawing.Point(638, 0);
            this.pn_dangnhap.Name = "pn_dangnhap";
            this.pn_dangnhap.Size = new System.Drawing.Size(367, 600);
            this.pn_dangnhap.TabIndex = 1;
            // 
            // pic_UEH
            // 
            this.pic_UEH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_UEH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_UEH.Image = global::PMTHITN.Properties.Resources.logo_header;
            this.pic_UEH.Location = new System.Drawing.Point(112, 57);
            this.pic_UEH.Name = "pic_UEH";
            this.pic_UEH.Size = new System.Drawing.Size(146, 85);
            this.pic_UEH.TabIndex = 57;
            this.pic_UEH.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(228, 553);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(127, 35);
            this.btn_exit.TabIndex = 56;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dangnhap.FlatAppearance.BorderSize = 0;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_dangnhap.ForeColor = System.Drawing.Color.Black;
            this.btn_dangnhap.Location = new System.Drawing.Point(35, 431);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(296, 53);
            this.btn_dangnhap.TabIndex = 50;
            this.btn_dangnhap.Text = "ĐĂNG NHẬP";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // pn_taikhoan
            // 
            this.pn_taikhoan.Controls.Add(this.txt_taikhoan);
            this.pn_taikhoan.Controls.Add(this.pic_taikhoan);
            this.pn_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_taikhoan.Location = new System.Drawing.Point(35, 206);
            this.pn_taikhoan.Name = "pn_taikhoan";
            this.pn_taikhoan.Size = new System.Drawing.Size(296, 73);
            this.pn_taikhoan.TabIndex = 54;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_taikhoan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_taikhoan.Location = new System.Drawing.Point(20, 26);
            this.txt_taikhoan.Multiline = true;
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(262, 35);
            this.txt_taikhoan.TabIndex = 1;
            // 
            // pic_taikhoan
            // 
            this.pic_taikhoan.Image = global::PMTHITN.Properties.Resources.thanhdangnhap__2_;
            this.pic_taikhoan.Location = new System.Drawing.Point(0, 0);
            this.pic_taikhoan.Name = "pic_taikhoan";
            this.pic_taikhoan.Size = new System.Drawing.Size(296, 73);
            this.pic_taikhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_taikhoan.TabIndex = 10;
            this.pic_taikhoan.TabStop = false;
            // 
            // linklbl_quenmatkhau
            // 
            this.linklbl_quenmatkhau.ActiveLinkColor = System.Drawing.Color.White;
            this.linklbl_quenmatkhau.AutoSize = true;
            this.linklbl_quenmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_quenmatkhau.LinkColor = System.Drawing.SystemColors.Control;
            this.linklbl_quenmatkhau.Location = new System.Drawing.Point(200, 376);
            this.linklbl_quenmatkhau.Name = "linklbl_quenmatkhau";
            this.linklbl_quenmatkhau.Size = new System.Drawing.Size(131, 20);
            this.linklbl_quenmatkhau.TabIndex = 53;
            this.linklbl_quenmatkhau.TabStop = true;
            this.linklbl_quenmatkhau.Text = "Quên mật khẩu?";
            this.linklbl_quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_quenmatkhau_LinkClicked);
            // 
            // lbl_tendangnhap
            // 
            this.lbl_tendangnhap.AutoSize = true;
            this.lbl_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tendangnhap.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tendangnhap.Location = new System.Drawing.Point(51, 185);
            this.lbl_tendangnhap.Name = "lbl_tendangnhap";
            this.lbl_tendangnhap.Size = new System.Drawing.Size(124, 20);
            this.lbl_tendangnhap.TabIndex = 48;
            this.lbl_tendangnhap.Text = "Tên đăng nhập:\t";
            // 
            // lbl_makhau
            // 
            this.lbl_makhau.AutoSize = true;
            this.lbl_makhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_makhau.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_makhau.Location = new System.Drawing.Point(51, 280);
            this.lbl_makhau.Name = "lbl_makhau";
            this.lbl_makhau.Size = new System.Drawing.Size(82, 20);
            this.lbl_makhau.TabIndex = 49;
            this.lbl_makhau.Text = "Mật khẩu:";
            // 
            // pn_matkhau
            // 
            this.pn_matkhau.Controls.Add(this.txt_matkhau);
            this.pn_matkhau.Controls.Add(this.pic_matkhau);
            this.pn_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_matkhau.Location = new System.Drawing.Point(35, 300);
            this.pn_matkhau.Name = "pn_matkhau";
            this.pn_matkhau.Size = new System.Drawing.Size(296, 73);
            this.pn_matkhau.TabIndex = 46;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_matkhau.Location = new System.Drawing.Point(20, 26);
            this.txt_matkhau.Multiline = true;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(262, 35);
            this.txt_matkhau.TabIndex = 2;
            // 
            // pic_matkhau
            // 
            this.pic_matkhau.Image = global::PMTHITN.Properties.Resources.thanhdangnhap__2_;
            this.pic_matkhau.Location = new System.Drawing.Point(0, 0);
            this.pic_matkhau.Name = "pic_matkhau";
            this.pic_matkhau.Size = new System.Drawing.Size(296, 73);
            this.pic_matkhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_matkhau.TabIndex = 10;
            this.pic_matkhau.TabStop = false;
            // 
            // pn_slide
            // 
            this.pn_slide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_slide.Controls.Add(this.pic_slideanh);
            this.pn_slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_slide.Location = new System.Drawing.Point(0, 0);
            this.pn_slide.Name = "pn_slide";
            this.pn_slide.Size = new System.Drawing.Size(638, 600);
            this.pn_slide.TabIndex = 2;
            // 
            // pic_slideanh
            // 
            this.pic_slideanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_slideanh.Location = new System.Drawing.Point(0, 0);
            this.pic_slideanh.Name = "pic_slideanh";
            this.pic_slideanh.Size = new System.Drawing.Size(638, 600);
            this.pic_slideanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_slideanh.TabIndex = 1;
            this.pic_slideanh.TabStop = false;
            // 
            // timer_slideanh
            // 
            this.timer_slideanh.Tick += new System.EventHandler(this.timer_slideanh_Tick);
            // 
            // frmlogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1005, 600);
            this.Controls.Add(this.pn_slide);
            this.Controls.Add(this.pn_dangnhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Hệ thống thi trắc nghiệm NEU";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.pn_dangnhap.ResumeLayout(false);
            this.pn_dangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UEH)).EndInit();
            this.pn_taikhoan.ResumeLayout(false);
            this.pn_taikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_taikhoan)).EndInit();
            this.pn_matkhau.ResumeLayout(false);
            this.pn_matkhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_matkhau)).EndInit();
            this.pn_slide.ResumeLayout(false);
            this.pn_slide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_slideanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_dangnhap;
        private System.Windows.Forms.LinkLabel linklbl_quenmatkhau;
        private System.Windows.Forms.Label lbl_tendangnhap;
        private System.Windows.Forms.Label lbl_makhau;
        private System.Windows.Forms.Panel pn_matkhau;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.PictureBox pic_matkhau;
        private System.Windows.Forms.Panel pn_taikhoan;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.PictureBox pic_taikhoan;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.PictureBox pic_UEH;
        private System.Windows.Forms.Panel pn_slide;
        private System.Windows.Forms.PictureBox pic_slideanh;
        private System.Windows.Forms.Timer timer_slideanh;
    }
}

