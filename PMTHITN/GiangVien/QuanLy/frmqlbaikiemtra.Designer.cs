namespace PMTHITN.GiangVien.Quanly
{
    partial class frmqlbaikiemtra
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
            this.dgv_dsbaikiemtra = new System.Windows.Forms.DataGridView();
            this.pn_subheader = new System.Windows.Forms.Panel();
            this.table_subheader = new System.Windows.Forms.TableLayoutPanel();
            this.btn_taomoi = new System.Windows.Forms.Button();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_dsbaikiemtra = new System.Windows.Forms.Label();
            this.pn_subcontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsbaikiemtra)).BeginInit();
            this.pn_subheader.SuspendLayout();
            this.table_subheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_subcontent
            // 
            this.pn_subcontent.Controls.Add(this.dgv_dsbaikiemtra);
            this.pn_subcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_subcontent.Location = new System.Drawing.Point(0, 58);
            this.pn_subcontent.Name = "pn_subcontent";
            this.pn_subcontent.Size = new System.Drawing.Size(991, 362);
            this.pn_subcontent.TabIndex = 3;
            // 
            // dgv_dsbaikiemtra
            // 
            this.dgv_dsbaikiemtra.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_dsbaikiemtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsbaikiemtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsbaikiemtra.Location = new System.Drawing.Point(0, 0);
            this.dgv_dsbaikiemtra.Name = "dgv_dsbaikiemtra";
            this.dgv_dsbaikiemtra.RowHeadersWidth = 51;
            this.dgv_dsbaikiemtra.RowTemplate.Height = 24;
            this.dgv_dsbaikiemtra.Size = new System.Drawing.Size(991, 362);
            this.dgv_dsbaikiemtra.TabIndex = 0;
            this.dgv_dsbaikiemtra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsbaikiemtra_CellContentClick);
            // 
            // pn_subheader
            // 
            this.pn_subheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_subheader.Controls.Add(this.table_subheader);
            this.pn_subheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_subheader.Location = new System.Drawing.Point(0, 0);
            this.pn_subheader.Name = "pn_subheader";
            this.pn_subheader.Size = new System.Drawing.Size(991, 58);
            this.pn_subheader.TabIndex = 2;
            // 
            // table_subheader
            // 
            this.table_subheader.ColumnCount = 3;
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 745F));
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.table_subheader.Controls.Add(this.btn_taomoi, 2, 0);
            this.table_subheader.Controls.Add(this.lbl_back, 0, 0);
            this.table_subheader.Controls.Add(this.lbl_dsbaikiemtra, 1, 0);
            this.table_subheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_subheader.Location = new System.Drawing.Point(12, 8);
            this.table_subheader.Name = "table_subheader";
            this.table_subheader.RowCount = 1;
            this.table_subheader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.Size = new System.Drawing.Size(966, 39);
            this.table_subheader.TabIndex = 0;
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_taomoi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_taomoi.FlatAppearance.BorderSize = 0;
            this.btn_taomoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taomoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taomoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_taomoi.Location = new System.Drawing.Point(873, 3);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(90, 33);
            this.btn_taomoi.TabIndex = 10;
            this.btn_taomoi.Text = "Tạo mới";
            this.btn_taomoi.UseVisualStyleBackColor = false;
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // lbl_back
            // 
            this.lbl_back.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_back.AutoSize = true;
            this.lbl_back.Location = new System.Drawing.Point(3, 5);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(22, 29);
            this.lbl_back.TabIndex = 0;
            this.lbl_back.Text = "<";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // lbl_dsbaikiemtra
            // 
            this.lbl_dsbaikiemtra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dsbaikiemtra.AutoSize = true;
            this.lbl_dsbaikiemtra.Location = new System.Drawing.Point(31, 5);
            this.lbl_dsbaikiemtra.Name = "lbl_dsbaikiemtra";
            this.lbl_dsbaikiemtra.Size = new System.Drawing.Size(277, 29);
            this.lbl_dsbaikiemtra.TabIndex = 1;
            this.lbl_dsbaikiemtra.Text = "Danh sách bài kiểm tra";
            // 
            // frmqlbaikiemtra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(991, 420);
            this.Controls.Add(this.pn_subcontent);
            this.Controls.Add(this.pn_subheader);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmqlbaikiemtra";
            this.Text = "frmqlbaikiemtra";
            this.pn_subcontent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsbaikiemtra)).EndInit();
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
        private System.Windows.Forms.Label lbl_dsbaikiemtra;
        private System.Windows.Forms.DataGridView dgv_dsbaikiemtra;
        private System.Windows.Forms.Button btn_taomoi;
    }
}