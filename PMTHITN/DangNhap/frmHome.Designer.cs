namespace PMTHITN
{
    partial class frmHome
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
            this.table_dangnhap = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sinhvien = new System.Windows.Forms.Button();
            this.btn_giangvien = new System.Windows.Forms.Button();
            this.pic_UEH = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_choice = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.table_dangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UEH)).BeginInit();
            this.SuspendLayout();
            // 
            // table_dangnhap
            // 
            this.table_dangnhap.ColumnCount = 1;
            this.table_dangnhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_dangnhap.Controls.Add(this.btn_sinhvien, 0, 4);
            this.table_dangnhap.Controls.Add(this.btn_giangvien, 0, 3);
            this.table_dangnhap.Controls.Add(this.pic_UEH, 0, 0);
            this.table_dangnhap.Controls.Add(this.lbl_title, 0, 1);
            this.table_dangnhap.Controls.Add(this.lbl_choice, 0, 2);
            this.table_dangnhap.Controls.Add(this.btn_exit, 0, 5);
            this.table_dangnhap.Location = new System.Drawing.Point(12, 69);
            this.table_dangnhap.Name = "table_dangnhap";
            this.table_dangnhap.RowCount = 6;
            this.table_dangnhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.table_dangnhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.table_dangnhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table_dangnhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_dangnhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_dangnhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.table_dangnhap.Size = new System.Drawing.Size(421, 597);
            this.table_dangnhap.TabIndex = 0;
            // 
            // btn_sinhvien
            // 
            this.btn_sinhvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sinhvien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sinhvien.FlatAppearance.BorderSize = 0;
            this.btn_sinhvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sinhvien.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_sinhvien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sinhvien.Location = new System.Drawing.Point(34, 361);
            this.btn_sinhvien.Name = "btn_sinhvien";
            this.btn_sinhvien.Size = new System.Drawing.Size(352, 68);
            this.btn_sinhvien.TabIndex = 33;
            this.btn_sinhvien.Text = "SINH VIÊN";
            this.btn_sinhvien.UseVisualStyleBackColor = false;
            this.btn_sinhvien.Click += new System.EventHandler(this.btn_sinhvien_Click);
            // 
            // btn_giangvien
            // 
            this.btn_giangvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_giangvien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_giangvien.FlatAppearance.BorderSize = 0;
            this.btn_giangvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giangvien.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_giangvien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_giangvien.Location = new System.Drawing.Point(34, 271);
            this.btn_giangvien.Name = "btn_giangvien";
            this.btn_giangvien.Size = new System.Drawing.Size(352, 68);
            this.btn_giangvien.TabIndex = 1;
            this.btn_giangvien.Text = "GIẢNG VIÊN";
            this.btn_giangvien.UseVisualStyleBackColor = false;
            this.btn_giangvien.Click += new System.EventHandler(this.btn_giangvien_Click);
            // 
            // pic_UEH
            // 
            this.pic_UEH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_UEH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_UEH.Image = global::PMTHITN.Properties.Resources.logo_header;
            this.pic_UEH.Location = new System.Drawing.Point(137, 3);
            this.pic_UEH.Name = "pic_UEH";
            this.pic_UEH.Size = new System.Drawing.Size(146, 85);
            this.pic_UEH.TabIndex = 28;
            this.pic_UEH.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(7, 113);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(407, 42);
            this.lbl_title.TabIndex = 30;
            this.lbl_title.Text = "PHẦN MỀM TRẮC NGHIỆM";
            // 
            // lbl_choice
            // 
            this.lbl_choice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_choice.AutoSize = true;
            this.lbl_choice.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_choice.Location = new System.Drawing.Point(156, 222);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(108, 35);
            this.lbl_choice.TabIndex = 31;
            this.lbl_choice.Text = "Bạn là ?";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.Location = new System.Drawing.Point(271, 548);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(147, 46);
            this.btn_exit.TabIndex = 34;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(445, 678);
            this.Controls.Add(this.table_dangnhap);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.table_dangnhap.ResumeLayout(false);
            this.table_dangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UEH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table_dangnhap;
        private System.Windows.Forms.PictureBox pic_UEH;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_choice;
        private System.Windows.Forms.Button btn_sinhvien;
        private System.Windows.Forms.Button btn_giangvien;
        private System.Windows.Forms.Button btn_exit;
    }
}