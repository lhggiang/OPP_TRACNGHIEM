namespace PMTHITN
{
    partial class frmquenmk
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
            this.pn_quenmk = new System.Windows.Forms.Panel();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.lbl_mkmoi = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_tieptheo = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.pn_quenmk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_quenmk
            // 
            this.pn_quenmk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.pn_quenmk.Controls.Add(this.txt_confirm);
            this.pn_quenmk.Controls.Add(this.lbl_confirm);
            this.pn_quenmk.Controls.Add(this.txt_mkmoi);
            this.pn_quenmk.Controls.Add(this.lbl_mkmoi);
            this.pn_quenmk.Controls.Add(this.btn_exit);
            this.pn_quenmk.Controls.Add(this.btn_tieptheo);
            this.pn_quenmk.Controls.Add(this.txt_email);
            this.pn_quenmk.Controls.Add(this.lbl_email);
            this.pn_quenmk.Location = new System.Drawing.Point(12, 12);
            this.pn_quenmk.Name = "pn_quenmk";
            this.pn_quenmk.Size = new System.Drawing.Size(529, 295);
            this.pn_quenmk.TabIndex = 0;
            // 
            // txt_confirm
            // 
            this.txt_confirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm.Location = new System.Drawing.Point(243, 128);
            this.txt_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.PasswordChar = '*';
            this.txt_confirm.Size = new System.Drawing.Size(228, 32);
            this.txt_confirm.TabIndex = 25;
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_confirm.Location = new System.Drawing.Point(57, 131);
            this.lbl_confirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(171, 24);
            this.lbl_confirm.TabIndex = 24;
            this.lbl_confirm.Text = "Nhập lại mật khẩu:";
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkmoi.Location = new System.Drawing.Point(243, 77);
            this.txt_mkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.PasswordChar = '*';
            this.txt_mkmoi.Size = new System.Drawing.Size(228, 32);
            this.txt_mkmoi.TabIndex = 23;
            // 
            // lbl_mkmoi
            // 
            this.lbl_mkmoi.AutoSize = true;
            this.lbl_mkmoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mkmoi.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_mkmoi.Location = new System.Drawing.Point(57, 80);
            this.lbl_mkmoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mkmoi.Name = "lbl_mkmoi";
            this.lbl_mkmoi.Size = new System.Drawing.Size(136, 24);
            this.lbl_mkmoi.TabIndex = 22;
            this.lbl_mkmoi.Text = "Mật khẩu mới:";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(294, 205);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(177, 50);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_tieptheo
            // 
            this.btn_tieptheo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tieptheo.Location = new System.Drawing.Point(61, 205);
            this.btn_tieptheo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tieptheo.Name = "btn_tieptheo";
            this.btn_tieptheo.Size = new System.Drawing.Size(177, 50);
            this.btn_tieptheo.TabIndex = 20;
            this.btn_tieptheo.Text = "Tiếp theo";
            this.btn_tieptheo.UseVisualStyleBackColor = true;
            this.btn_tieptheo.Click += new System.EventHandler(this.btn_tieptheo_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(139, 27);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(332, 32);
            this.txt_email.TabIndex = 19;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_email.Location = new System.Drawing.Point(57, 30);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 24);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email:";
            // 
            // frmquenmk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(553, 319);
            this.Controls.Add(this.pn_quenmk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmquenmk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmquenmk";
            this.pn_quenmk.ResumeLayout(false);
            this.pn_quenmk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_quenmk;
        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.Label lbl_confirm;
        private System.Windows.Forms.TextBox txt_mkmoi;
        private System.Windows.Forms.Label lbl_mkmoi;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_tieptheo;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
    }
}