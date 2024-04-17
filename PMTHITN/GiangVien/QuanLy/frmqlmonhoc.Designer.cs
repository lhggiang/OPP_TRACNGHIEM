namespace PMTHITN
{
    partial class frmqlmonhoc
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
            this.pn_subheader = new System.Windows.Forms.Panel();
            this.table_subheader = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lbl_dsmonhoc = new System.Windows.Forms.Label();
            this.pn_subcontent = new System.Windows.Forms.Panel();
            this.dgv_dsmonhoc = new System.Windows.Forms.DataGridView();
            this.pn_subheader.SuspendLayout();
            this.table_subheader.SuspendLayout();
            this.pn_subcontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsmonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_subheader
            // 
            this.pn_subheader.BackColor = System.Drawing.Color.SeaShell;
            this.pn_subheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_subheader.Controls.Add(this.table_subheader);
            this.pn_subheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_subheader.Location = new System.Drawing.Point(0, 0);
            this.pn_subheader.Name = "pn_subheader";
            this.pn_subheader.Size = new System.Drawing.Size(991, 58);
            this.pn_subheader.TabIndex = 0;
            // 
            // table_subheader
            // 
            this.table_subheader.ColumnCount = 2;
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_subheader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.table_subheader.Controls.Add(this.lbl_back, 0, 0);
            this.table_subheader.Controls.Add(this.lbl_dsmonhoc, 1, 0);
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
            // lbl_dsmonhoc
            // 
            this.lbl_dsmonhoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dsmonhoc.AutoSize = true;
            this.lbl_dsmonhoc.Location = new System.Drawing.Point(24, 5);
            this.lbl_dsmonhoc.Name = "lbl_dsmonhoc";
            this.lbl_dsmonhoc.Size = new System.Drawing.Size(240, 29);
            this.lbl_dsmonhoc.TabIndex = 1;
            this.lbl_dsmonhoc.Text = "Danh sách môn học";
            // 
            // pn_subcontent
            // 
            this.pn_subcontent.Controls.Add(this.dgv_dsmonhoc);
            this.pn_subcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_subcontent.Location = new System.Drawing.Point(0, 58);
            this.pn_subcontent.Name = "pn_subcontent";
            this.pn_subcontent.Size = new System.Drawing.Size(991, 362);
            this.pn_subcontent.TabIndex = 1;
            // 
            // dgv_dsmonhoc
            // 
            this.dgv_dsmonhoc.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_dsmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsmonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsmonhoc.Location = new System.Drawing.Point(0, 0);
            this.dgv_dsmonhoc.Name = "dgv_dsmonhoc";
            this.dgv_dsmonhoc.RowHeadersWidth = 51;
            this.dgv_dsmonhoc.RowTemplate.Height = 24;
            this.dgv_dsmonhoc.Size = new System.Drawing.Size(991, 362);
            this.dgv_dsmonhoc.TabIndex = 0;
            this.dgv_dsmonhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsmonhoc_CellContentClick);
            // 
            // frmqlmonhoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(991, 420);
            this.Controls.Add(this.pn_subcontent);
            this.Controls.Add(this.pn_subheader);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmqlmonhoc";
            this.Text = "frmqlmonhoc";
            this.pn_subheader.ResumeLayout(false);
            this.table_subheader.ResumeLayout(false);
            this.table_subheader.PerformLayout();
            this.pn_subcontent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsmonhoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_subheader;
        private System.Windows.Forms.TableLayoutPanel table_subheader;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label lbl_dsmonhoc;
        private System.Windows.Forms.Panel pn_subcontent;
        private System.Windows.Forms.DataGridView dgv_dsmonhoc;
    }
}