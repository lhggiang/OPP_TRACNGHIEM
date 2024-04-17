namespace PMTHITN.SinhVien
{
    partial class frmcauhoi
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
            this.pn_cauhoi = new System.Windows.Forms.Panel();
            this.pn_cautraloi = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_d = new System.Windows.Forms.RadioButton();
            this.rb_c = new System.Windows.Forms.RadioButton();
            this.rb_b = new System.Windows.Forms.RadioButton();
            this.rb_a = new System.Windows.Forms.RadioButton();
            this.pn_debai = new System.Windows.Forms.Panel();
            this.table_debai = new System.Windows.Forms.TableLayoutPanel();
            this.lb_socau = new System.Windows.Forms.Label();
            this.lbl_debai = new System.Windows.Forms.Label();
            this.pn_cauhoi.SuspendLayout();
            this.pn_cautraloi.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pn_debai.SuspendLayout();
            this.table_debai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_cauhoi
            // 
            this.pn_cauhoi.Controls.Add(this.pn_cautraloi);
            this.pn_cauhoi.Controls.Add(this.pn_debai);
            this.pn_cauhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cauhoi.Location = new System.Drawing.Point(0, 0);
            this.pn_cauhoi.Name = "pn_cauhoi";
            this.pn_cauhoi.Size = new System.Drawing.Size(818, 503);
            this.pn_cauhoi.TabIndex = 0;
            // 
            // pn_cautraloi
            // 
            this.pn_cautraloi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_cautraloi.Controls.Add(this.tableLayoutPanel1);
            this.pn_cautraloi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cautraloi.Location = new System.Drawing.Point(0, 349);
            this.pn_cautraloi.Name = "pn_cautraloi";
            this.pn_cautraloi.Size = new System.Drawing.Size(818, 154);
            this.pn_cautraloi.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rb_d, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rb_c, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rb_b, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rb_a, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 144);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rb_d
            // 
            this.rb_d.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_d.AutoSize = true;
            this.rb_d.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_d.Location = new System.Drawing.Point(3, 113);
            this.rb_d.Name = "rb_d";
            this.rb_d.Size = new System.Drawing.Size(97, 26);
            this.rb_d.TabIndex = 3;
            this.rb_d.TabStop = true;
            this.rb_d.Text = "Đáp án D";
            this.rb_d.UseVisualStyleBackColor = true;
            this.rb_d.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_c
            // 
            this.rb_c.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_c.AutoSize = true;
            this.rb_c.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_c.Location = new System.Drawing.Point(3, 77);
            this.rb_c.Name = "rb_c";
            this.rb_c.Size = new System.Drawing.Size(96, 26);
            this.rb_c.TabIndex = 2;
            this.rb_c.TabStop = true;
            this.rb_c.Text = "Đáp án C";
            this.rb_c.UseVisualStyleBackColor = true;
            this.rb_c.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_b
            // 
            this.rb_b.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_b.AutoSize = true;
            this.rb_b.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_b.Location = new System.Drawing.Point(3, 41);
            this.rb_b.Name = "rb_b";
            this.rb_b.Size = new System.Drawing.Size(96, 26);
            this.rb_b.TabIndex = 1;
            this.rb_b.TabStop = true;
            this.rb_b.Text = "Đáp án B";
            this.rb_b.UseVisualStyleBackColor = true;
            this.rb_b.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_a
            // 
            this.rb_a.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_a.AutoSize = true;
            this.rb_a.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_a.Location = new System.Drawing.Point(3, 5);
            this.rb_a.Name = "rb_a";
            this.rb_a.Size = new System.Drawing.Size(96, 26);
            this.rb_a.TabIndex = 0;
            this.rb_a.TabStop = true;
            this.rb_a.Text = "Đáp án A";
            this.rb_a.UseVisualStyleBackColor = true;
            this.rb_a.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // pn_debai
            // 
            this.pn_debai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_debai.Controls.Add(this.table_debai);
            this.pn_debai.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_debai.Location = new System.Drawing.Point(0, 0);
            this.pn_debai.Name = "pn_debai";
            this.pn_debai.Size = new System.Drawing.Size(818, 349);
            this.pn_debai.TabIndex = 0;
            // 
            // table_debai
            // 
            this.table_debai.ColumnCount = 2;
            this.table_debai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_debai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 716F));
            this.table_debai.Controls.Add(this.lb_socau, 0, 0);
            this.table_debai.Controls.Add(this.lbl_debai, 1, 0);
            this.table_debai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table_debai.Location = new System.Drawing.Point(0, 21);
            this.table_debai.Name = "table_debai";
            this.table_debai.RowCount = 1;
            this.table_debai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_debai.Size = new System.Drawing.Size(816, 326);
            this.table_debai.TabIndex = 0;
            // 
            // lb_socau
            // 
            this.lb_socau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_socau.AutoSize = true;
            this.lb_socau.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_socau.Location = new System.Drawing.Point(55, 0);
            this.lb_socau.Name = "lb_socau";
            this.lb_socau.Size = new System.Drawing.Size(42, 24);
            this.lb_socau.TabIndex = 0;
            this.lb_socau.Text = "Câu";
            // 
            // lbl_debai
            // 
            this.lbl_debai.AutoSize = true;
            this.lbl_debai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debai.Location = new System.Drawing.Point(103, 0);
            this.lbl_debai.Name = "lbl_debai";
            this.lbl_debai.Size = new System.Drawing.Size(74, 24);
            this.lbl_debai.TabIndex = 1;
            this.lbl_debai.Text = "Câu hỏi";
            // 
            // frmcauhoi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(818, 503);
            this.Controls.Add(this.pn_cauhoi);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcauhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcauhoi";
            this.pn_cauhoi.ResumeLayout(false);
            this.pn_cautraloi.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pn_debai.ResumeLayout(false);
            this.table_debai.ResumeLayout(false);
            this.table_debai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_cauhoi;
        private System.Windows.Forms.Panel pn_cautraloi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rb_d;
        private System.Windows.Forms.RadioButton rb_c;
        private System.Windows.Forms.RadioButton rb_b;
        private System.Windows.Forms.RadioButton rb_a;
        private System.Windows.Forms.Panel pn_debai;
        private System.Windows.Forms.TableLayoutPanel table_debai;
        private System.Windows.Forms.Label lb_socau;
        private System.Windows.Forms.Label lbl_debai;
    }
}