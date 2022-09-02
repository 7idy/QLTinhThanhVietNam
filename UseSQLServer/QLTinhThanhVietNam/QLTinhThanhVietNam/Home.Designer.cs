namespace QLTinhThanhVietNam
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTinh = new System.Windows.Forms.ComboBox();
            this.cbbQHuyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbXPhuong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLThiTran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSLPhuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSLXa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongXP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1089, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các tỉnh thành của Việt Nam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(0, 548);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(1089, 40);
            this.lblTime.TabIndex = 1;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(71, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tỉnh/Thành";
            // 
            // cbbTinh
            // 
            this.cbbTinh.FormattingEnabled = true;
            this.cbbTinh.Location = new System.Drawing.Point(75, 179);
            this.cbbTinh.Name = "cbbTinh";
            this.cbbTinh.Size = new System.Drawing.Size(283, 28);
            this.cbbTinh.TabIndex = 3;
            this.cbbTinh.SelectedIndexChanged += new System.EventHandler(this.cbbTinh_SelectedIndexChanged);
            // 
            // cbbQHuyen
            // 
            this.cbbQHuyen.FormattingEnabled = true;
            this.cbbQHuyen.Location = new System.Drawing.Point(403, 179);
            this.cbbQHuyen.Name = "cbbQHuyen";
            this.cbbQHuyen.Size = new System.Drawing.Size(283, 28);
            this.cbbQHuyen.TabIndex = 5;
            this.cbbQHuyen.SelectedIndexChanged += new System.EventHandler(this.cbbQHuyen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(399, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quận/Huyện";
            // 
            // cbbXPhuong
            // 
            this.cbbXPhuong.FormattingEnabled = true;
            this.cbbXPhuong.Location = new System.Drawing.Point(731, 179);
            this.cbbXPhuong.Name = "cbbXPhuong";
            this.cbbXPhuong.Size = new System.Drawing.Size(283, 28);
            this.cbbXPhuong.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(727, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phường/Xã";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSLThiTran);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSLPhuong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSLXa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(359, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 205);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bao gồm";
            // 
            // txtSLThiTran
            // 
            this.txtSLThiTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLThiTran.Location = new System.Drawing.Point(245, 139);
            this.txtSLThiTran.Name = "txtSLThiTran";
            this.txtSLThiTran.Size = new System.Drawing.Size(55, 28);
            this.txtSLThiTran.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số lượng Thị trấn";
            // 
            // txtSLPhuong
            // 
            this.txtSLPhuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLPhuong.Location = new System.Drawing.Point(245, 95);
            this.txtSLPhuong.Name = "txtSLPhuong";
            this.txtSLPhuong.Size = new System.Drawing.Size(55, 28);
            this.txtSLPhuong.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng Phường:";
            // 
            // txtSLXa
            // 
            this.txtSLXa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLXa.Location = new System.Drawing.Point(245, 49);
            this.txtSLXa.Name = "txtSLXa";
            this.txtSLXa.Size = new System.Drawing.Size(55, 28);
            this.txtSLXa.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng Xã:";
            // 
            // txtTongXP
            // 
            this.txtTongXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongXP.Location = new System.Drawing.Point(652, 252);
            this.txtTongXP.Name = "txtTongXP";
            this.txtTongXP.Size = new System.Drawing.Size(52, 28);
            this.txtTongXP.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(389, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Đơn vị hành chính cấp Phường xã:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 588);
            this.Controls.Add(this.txtTongXP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbXPhuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbQHuyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Các tỉnh thành của Việt Nam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTinh;
        private System.Windows.Forms.ComboBox cbbQHuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbXPhuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSLXa;
        private System.Windows.Forms.TextBox txtSLThiTran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSLPhuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongXP;
        private System.Windows.Forms.Label label9;
    }
}

