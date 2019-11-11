namespace QuanLiTrungTamAnhNgu
{
    partial class frDangNhap
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.bttDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.bttThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(297, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(144, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(266, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tài khoản:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(266, 174);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(346, 124);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(125, 22);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(346, 169);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(125, 22);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Visible = false;
            // 
            // bttDangNhap
            // 
            this.bttDangNhap.Location = new System.Drawing.Point(222, 245);
            this.bttDangNhap.Name = "bttDangNhap";
            this.bttDangNhap.Size = new System.Drawing.Size(94, 29);
            this.bttDangNhap.TabIndex = 5;
            this.bttDangNhap.Text = "Đăng Nhập";
            // 
            // bttThoat
            // 
            this.bttThoat.Location = new System.Drawing.Point(435, 245);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(94, 29);
            this.bttThoat.TabIndex = 6;
            this.bttThoat.Text = "Thoát";
            // 
            // frDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 332);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frDangNhap";
            this.Text = "frDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.SimpleButton bttDangNhap;
        private DevExpress.XtraEditors.SimpleButton bttThoat;
    }
}