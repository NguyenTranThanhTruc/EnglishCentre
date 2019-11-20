namespace QuanLiTrungTamAnhNgu
{
    partial class frThoiGianLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frThoiGianLopHoc));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcThoiGianLopHoc = new DevExpress.XtraGrid.GridControl();
            this.gvThoiGianLopHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bttLHuy = new DevExpress.XtraEditors.SimpleButton();
            this.bttXoaTGLH = new DevExpress.XtraEditors.SimpleButton();
            this.bttSuaTGLH = new DevExpress.XtraEditors.SimpleButton();
            this.bttThemTGLH = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaLH = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgayHoc = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThoiGianCuaBuoiHoc = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThoiGianLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoiGianLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianCuaBuoiHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtThoiGianCuaBuoiHoc);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtNgayHoc);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.bttLHuy);
            this.panelControl1.Controls.Add(this.bttXoaTGLH);
            this.panelControl1.Controls.Add(this.bttSuaTGLH);
            this.panelControl1.Controls.Add(this.bttThemTGLH);
            this.panelControl1.Controls.Add(this.txtMaLH);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(434, 369);
            this.panelControl1.TabIndex = 0;
            // 
            // gcThoiGianLopHoc
            // 
            this.gcThoiGianLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThoiGianLopHoc.Location = new System.Drawing.Point(434, 0);
            this.gcThoiGianLopHoc.MainView = this.gvThoiGianLopHoc;
            this.gcThoiGianLopHoc.Name = "gcThoiGianLopHoc";
            this.gcThoiGianLopHoc.Size = new System.Drawing.Size(628, 369);
            this.gcThoiGianLopHoc.TabIndex = 1;
            this.gcThoiGianLopHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThoiGianLopHoc});
            // 
            // gvThoiGianLopHoc
            // 
            this.gvThoiGianLopHoc.GridControl = this.gcThoiGianLopHoc;
            this.gvThoiGianLopHoc.Name = "gvThoiGianLopHoc";
            // 
            // bttLHuy
            // 
            this.bttLHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttLHuy.ImageOptions.Image")));
            this.bttLHuy.Location = new System.Drawing.Point(161, 294);
            this.bttLHuy.Name = "bttLHuy";
            this.bttLHuy.Size = new System.Drawing.Size(94, 35);
            this.bttLHuy.TabIndex = 60;
            this.bttLHuy.Text = "Hủy";
            // 
            // bttXoaTGLH
            // 
            this.bttXoaTGLH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttXoaKH.ImageOptions.Image")));
            this.bttXoaTGLH.Location = new System.Drawing.Point(292, 246);
            this.bttXoaTGLH.Name = "bttXoaTGLH";
            this.bttXoaTGLH.Size = new System.Drawing.Size(94, 29);
            this.bttXoaTGLH.TabIndex = 59;
            this.bttXoaTGLH.Text = "Xóa";
            // 
            // bttSuaTGLH
            // 
            this.bttSuaTGLH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttSuaKH.ImageOptions.Image")));
            this.bttSuaTGLH.Location = new System.Drawing.Point(161, 246);
            this.bttSuaTGLH.Name = "bttSuaTGLH";
            this.bttSuaTGLH.Size = new System.Drawing.Size(94, 29);
            this.bttSuaTGLH.TabIndex = 58;
            this.bttSuaTGLH.Text = "Sửa";
            // 
            // bttThemTGLH
            // 
            this.bttThemTGLH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttThemKH.ImageOptions.Image")));
            this.bttThemTGLH.Location = new System.Drawing.Point(51, 246);
            this.bttThemTGLH.Name = "bttThemTGLH";
            this.bttThemTGLH.Size = new System.Drawing.Size(94, 29);
            this.bttThemTGLH.TabIndex = 57;
            this.bttThemTGLH.Text = "Thêm";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(177, 85);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLH.Properties.Appearance.Options.UseFont = true;
            this.txtMaLH.Size = new System.Drawing.Size(209, 26);
            this.txtMaLH.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã lớp học:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(136, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 17);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "THỜI GIAN CỦA LỚP HỌC";
            // 
            // txtNgayHoc
            // 
            this.txtNgayHoc.Location = new System.Drawing.Point(177, 132);
            this.txtNgayHoc.Name = "txtNgayHoc";
            this.txtNgayHoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHoc.Properties.Appearance.Options.UseFont = true;
            this.txtNgayHoc.Size = new System.Drawing.Size(209, 26);
            this.txtNgayHoc.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ngày học:";
            // 
            // txtThoiGianCuaBuoiHoc
            // 
            this.txtThoiGianCuaBuoiHoc.Location = new System.Drawing.Point(177, 184);
            this.txtThoiGianCuaBuoiHoc.Name = "txtThoiGianCuaBuoiHoc";
            this.txtThoiGianCuaBuoiHoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianCuaBuoiHoc.Properties.Appearance.Options.UseFont = true;
            this.txtThoiGianCuaBuoiHoc.Size = new System.Drawing.Size(209, 26);
            this.txtThoiGianCuaBuoiHoc.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Thời gian của buổi học:";
            // 
            // frThoiGianLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 369);
            this.Controls.Add(this.gcThoiGianLopHoc);
            this.Controls.Add(this.panelControl1);
            this.Name = "frThoiGianLopHoc";
            this.Text = "Thời gian lớp học";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThoiGianLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoiGianLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianCuaBuoiHoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcThoiGianLopHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThoiGianLopHoc;
        private DevExpress.XtraEditors.SimpleButton bttLHuy;
        private DevExpress.XtraEditors.SimpleButton bttXoaTGLH;
        private DevExpress.XtraEditors.SimpleButton bttSuaTGLH;
        private DevExpress.XtraEditors.SimpleButton bttThemTGLH;
        private DevExpress.XtraEditors.TextEdit txtMaLH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNgayHoc;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtThoiGianCuaBuoiHoc;
        private System.Windows.Forms.Label label3;
    }
}