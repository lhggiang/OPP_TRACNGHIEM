namespace PMTHITN.GiangVien.Quanly
{
    partial class frmbangdiem
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
            this.tab_bangdiem = new System.Windows.Forms.TabPage();
            this.pn_bangdiem = new System.Windows.Forms.Panel();
            this.dgv_bangdiem = new System.Windows.Forms.DataGridView();
            this.pn_subheader = new System.Windows.Forms.Panel();
            this.table_subheader = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_bangdiem = new System.Windows.Forms.Label();
            this.tab_baikiemtracu = new System.Windows.Forms.TabControl();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.tab_bangdiem.SuspendLayout();
            this.pn_bangdiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdiem)).BeginInit();
            this.pn_subheader.SuspendLayout();
            this.table_subheader.SuspendLayout();
            this.tab_baikiemtracu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_bangdiem
            // 
            this.tab_bangdiem.Controls.Add(this.pn_bangdiem);
            this.tab_bangdiem.Controls.Add(this.pn_subheader);
            this.tab_bangdiem.Location = new System.Drawing.Point(4, 31);
            this.tab_bangdiem.Name = "tab_bangdiem";
            this.tab_bangdiem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_bangdiem.Size = new System.Drawing.Size(943, 649);
            this.tab_bangdiem.TabIndex = 1;
            this.tab_bangdiem.Text = "Bảng điểm";
            this.tab_bangdiem.UseVisualStyleBackColor = true;
            // 
            // pn_bangdiem
            // 
            this.pn_bangdiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_bangdiem.Controls.Add(this.dgv_bangdiem);
            this.pn_bangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_bangdiem.Location = new System.Drawing.Point(3, 65);
            this.pn_bangdiem.Name = "pn_bangdiem";
            this.pn_bangdiem.Size = new System.Drawing.Size(937, 581);
            this.pn_bangdiem.TabIndex = 5;
            // 
            // dgv_bangdiem
            // 
            this.dgv_bangdiem.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_bangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bangdiem.Location = new System.Drawing.Point(0, 0);
            this.dgv_bangdiem.Name = "dgv_bangdiem";
            this.dgv_bangdiem.RowHeadersWidth = 51;
            this.dgv_bangdiem.RowTemplate.Height = 24;
            this.dgv_bangdiem.Size = new System.Drawing.Size(935, 579);
            this.dgv_bangdiem.TabIndex = 0;
            // 
            // pn_subheader
            // 
            this.pn_subheader.BackColor = System.Drawing.Color.SeaShell;
            this.pn_subheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_subheader.Controls.Add(this.btn_xuat);
            this.pn_subheader.Controls.Add(this.table_subheader);
            this.pn_subheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_subheader.Location = new System.Drawing.Point(3, 3);
            this.pn_subheader.Name = "pn_subheader";
            this.pn_subheader.Size = new System.Drawing.Size(937, 62);
            this.pn_subheader.TabIndex = 4;
            // 
            // table_subheader
            // 
            this.table_subheader.ColumnCount = 2;
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.table_subheader.Controls.Add(this.lbl_back, 0, 0);
            this.table_subheader.Controls.Add(this.lbl_bangdiem, 1, 0);
            this.table_subheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_subheader.Location = new System.Drawing.Point(12, 12);
            this.table_subheader.Name = "table_subheader";
            this.table_subheader.RowCount = 1;
            this.table_subheader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.lbl_back.Click += new System.EventHandler(this.lbl_backnd_Click);
            // 
            // lbl_bangdiem
            // 
            this.lbl_bangdiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_bangdiem.AutoSize = true;
            this.lbl_bangdiem.Location = new System.Drawing.Point(24, 5);
            this.lbl_bangdiem.Name = "lbl_bangdiem";
            this.lbl_bangdiem.Size = new System.Drawing.Size(244, 29);
            this.lbl_bangdiem.TabIndex = 1;
            this.lbl_bangdiem.Text = "Bảng điểm môn học";
            this.lbl_bangdiem.Click += new System.EventHandler(this.lbl_backnd_Click);
            // 
            // tab_baikiemtracu
            // 
            this.tab_baikiemtracu.Controls.Add(this.tab_bangdiem);
            this.tab_baikiemtracu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_baikiemtracu.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_baikiemtracu.Location = new System.Drawing.Point(0, 0);
            this.tab_baikiemtracu.Name = "tab_baikiemtracu";
            this.tab_baikiemtracu.SelectedIndex = 0;
            this.tab_baikiemtracu.Size = new System.Drawing.Size(951, 684);
            this.tab_baikiemtracu.TabIndex = 0;
            // 
            // btn_xuat
            // 
            this.btn_xuat.BackColor = System.Drawing.Color.SeaShell;
            this.btn_xuat.Location = new System.Drawing.Point(723, 8);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(200, 42);
            this.btn_xuat.TabIndex = 2;
            this.btn_xuat.Text = "Xuất bảng điểm";
            this.btn_xuat.UseVisualStyleBackColor = false;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // frmbangdiem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(951, 684);
            this.Controls.Add(this.tab_baikiemtracu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmbangdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbangdiem";
            this.tab_bangdiem.ResumeLayout(false);
            this.pn_bangdiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdiem)).EndInit();
            this.pn_subheader.ResumeLayout(false);
            this.table_subheader.ResumeLayout(false);
            this.table_subheader.PerformLayout();
            this.tab_baikiemtracu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_bangdiem;
        private System.Windows.Forms.Panel pn_bangdiem;
        private System.Windows.Forms.DataGridView dgv_bangdiem;
        private System.Windows.Forms.Panel pn_subheader;
        private System.Windows.Forms.TableLayoutPanel table_subheader;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_bangdiem;
        private System.Windows.Forms.TabControl tab_baikiemtracu;
        private System.Windows.Forms.Button btn_xuat;
    }
}