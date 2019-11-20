namespace QuanLiTrungTamAnhNgu
{
    partial class frPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPhieuThu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcPhieuThu = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rdXemTheoLH = new System.Windows.Forms.RadioButton();
            this.rdXemTheoNgayThanhToan = new System.Windows.Forms.RadioButton();
            this.drdbttLopHoc = new DevExpress.XtraEditors.DropDownButton();
            this.bttLHuy = new DevExpress.XtraEditors.SimpleButton();
            this.bttXoaPT = new DevExpress.XtraEditors.SimpleButton();
            this.bttSuaPT = new DevExpress.XtraEditors.SimpleButton();
            this.bttThemPT = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.txtPTTT = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHV = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rdXemTheoLH);
            this.panelControl1.Controls.Add(this.rdXemTheoNgayThanhToan);
            this.panelControl1.Controls.Add(this.drdbttLopHoc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1189, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtMaLop);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txtMaHV);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.txtSoTien);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.txtPTTT);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.dtNgayThanhToan);
            this.panelControl2.Controls.Add(this.bttLHuy);
            this.panelControl2.Controls.Add(this.bttXoaPT);
            this.panelControl2.Controls.Add(this.bttSuaPT);
            this.panelControl2.Controls.Add(this.bttThemPT);
            this.panelControl2.Controls.Add(this.txtMaPT);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 53);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(473, 505);
            this.panelControl2.TabIndex = 1;
            // 
            // gcPhieuThu
            // 
            this.gcPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhieuThu.Location = new System.Drawing.Point(473, 53);
            this.gcPhieuThu.MainView = this.gvPhieuThu;
            this.gcPhieuThu.Name = "gcPhieuThu";
            this.gcPhieuThu.Size = new System.Drawing.Size(716, 505);
            this.gcPhieuThu.TabIndex = 2;
            this.gcPhieuThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuThu});
            // 
            // gvPhieuThu
            // 
            this.gvPhieuThu.GridControl = this.gcPhieuThu;
            this.gvPhieuThu.Name = "gvPhieuThu";
            this.gvPhieuThu.OptionsFind.AlwaysVisible = true;
            // 
            // rdXemTheoLH
            // 
            this.rdXemTheoLH.AutoSize = true;
            this.rdXemTheoLH.Location = new System.Drawing.Point(324, 15);
            this.rdXemTheoLH.Name = "rdXemTheoLH";
            this.rdXemTheoLH.Size = new System.Drawing.Size(137, 21);
            this.rdXemTheoLH.TabIndex = 19;
            this.rdXemTheoLH.TabStop = true;
            this.rdXemTheoLH.Text = "Xem theo lớp học";
            this.rdXemTheoLH.UseVisualStyleBackColor = true;
            // 
            // rdXemTheoNgayThanhToan
            // 
            this.rdXemTheoNgayThanhToan.AutoSize = true;
            this.rdXemTheoNgayThanhToan.Location = new System.Drawing.Point(12, 12);
            this.rdXemTheoNgayThanhToan.Name = "rdXemTheoNgayThanhToan";
            this.rdXemTheoNgayThanhToan.Size = new System.Drawing.Size(195, 21);
            this.rdXemTheoNgayThanhToan.TabIndex = 18;
            this.rdXemTheoNgayThanhToan.TabStop = true;
            this.rdXemTheoNgayThanhToan.Text = "Xem theo ngày thanh toán";
            this.rdXemTheoNgayThanhToan.UseVisualStyleBackColor = true;
            // 
            // drdbttLopHoc
            // 
            this.drdbttLopHoc.Location = new System.Drawing.Point(467, 7);
            this.drdbttLopHoc.Name = "drdbttLopHoc";
            this.drdbttLopHoc.Size = new System.Drawing.Size(154, 29);
            this.drdbttLopHoc.TabIndex = 15;
            this.drdbttLopHoc.Text = "Lớp học";
            // 
            // bttLHuy
            // 
            this.bttLHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttLHuy.ImageOptions.Image")));
            this.bttLHuy.Location = new System.Drawing.Point(190, 387);
            this.bttLHuy.Name = "bttLHuy";
            this.bttLHuy.Size = new System.Drawing.Size(94, 35);
            this.bttLHuy.TabIndex = 60;
            this.bttLHuy.Text = "Hủy";
            // 
            // bttXoaPT
            // 
            this.bttXoaPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttXoaKH.ImageOptions.Image")));
            this.bttXoaPT.Location = new System.Drawing.Point(290, 339);
            this.bttXoaPT.Name = "bttXoaPT";
            this.bttXoaPT.Size = new System.Drawing.Size(94, 29);
            this.bttXoaPT.TabIndex = 59;
            this.bttXoaPT.Text = "Xóa";
            // 
            // bttSuaPT
            // 
            this.bttSuaPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttSuaKH.ImageOptions.Image")));
            this.bttSuaPT.Location = new System.Drawing.Point(190, 339);
            this.bttSuaPT.Name = "bttSuaPT";
            this.bttSuaPT.Size = new System.Drawing.Size(94, 29);
            this.bttSuaPT.TabIndex = 58;
            this.bttSuaPT.Text = "Sửa";
            // 
            // bttThemPT
            // 
            this.bttThemPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttThemKH.ImageOptions.Image")));
            this.bttThemPT.Location = new System.Drawing.Point(80, 339);
            this.bttThemPT.Name = "bttThemPT";
            this.bttThemPT.Size = new System.Drawing.Size(94, 29);
            this.bttThemPT.TabIndex = 57;
            this.bttThemPT.Text = "Thêm";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(204, 69);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(209, 22);
            this.txtMaPT.TabIndex = 55;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 16);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "Ngày thanh toán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã phiếu thu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(122, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 17);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "THÔNG TIN PHIẾU THU";
            // 
            // dtNgayThanhToan
            // 
            this.dtNgayThanhToan.Location = new System.Drawing.Point(203, 105);
            this.dtNgayThanhToan.Name = "dtNgayThanhToan";
            this.dtNgayThanhToan.Size = new System.Drawing.Size(206, 23);
            this.dtNgayThanhToan.TabIndex = 61;
            // 
            // txtPTTT
            // 
            this.txtPTTT.Location = new System.Drawing.Point(204, 146);
            this.txtPTTT.Name = "txtPTTT";
            this.txtPTTT.Size = new System.Drawing.Size(209, 22);
            this.txtPTTT.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Phương thức thanh toán:\r\n";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(203, 276);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(209, 22);
            this.txtSoTien.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Số tiền:";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(203, 189);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(206, 22);
            this.txtMaHV.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã học viên:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(204, 234);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(206, 22);
            this.txtMaLop.TabIndex = 69;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 237);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 17);
            this.labelControl3.TabIndex = 68;
            this.labelControl3.Text = "Mã lớp:";
            // 
            // frPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 558);
            this.Controls.Add(this.gcPhieuThu);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frPhieuThu";
            this.Text = "Phiếu thu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcPhieuThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuThu;
        private System.Windows.Forms.RadioButton rdXemTheoLH;
        private System.Windows.Forms.RadioButton rdXemTheoNgayThanhToan;
        private DevExpress.XtraEditors.DropDownButton drdbttLopHoc;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPTTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayThanhToan;
        private DevExpress.XtraEditors.SimpleButton bttLHuy;
        private DevExpress.XtraEditors.SimpleButton bttXoaPT;
        private DevExpress.XtraEditors.SimpleButton bttSuaPT;
        private DevExpress.XtraEditors.SimpleButton bttThemPT;
        private DevExpress.XtraEditors.TextEdit txtMaPT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaHV;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}