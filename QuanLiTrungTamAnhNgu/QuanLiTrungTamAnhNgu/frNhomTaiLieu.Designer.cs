namespace QuanLiTrungTamAnhNgu
{
    partial class frNhomTaiLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frNhomTaiLieu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.gcNTL = new DevExpress.XtraGrid.GridControl();
            this.gvNTL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rbXemToanBo = new System.Windows.Forms.RadioButton();
            this.rdXemTheoKhoaHV = new System.Windows.Forms.RadioButton();
            this.ddXemTheoKhoa = new DevExpress.XtraEditors.DropDownButton();
            this.bttLHuy = new DevExpress.XtraEditors.SimpleButton();
            this.bttXoaNTL = new DevExpress.XtraEditors.SimpleButton();
            this.bttSuaNTL = new DevExpress.XtraEditors.SimpleButton();
            this.bttThemNTL = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaNTL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNTL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ddKhoaHoc = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNTL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rbXemToanBo);
            this.panelControl1.Controls.Add(this.rdXemTheoKhoaHV);
            this.panelControl1.Controls.Add(this.ddXemTheoKhoa);
            this.panelControl1.Controls.Add(this.sidePanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(390, 397);
            this.panelControl1.TabIndex = 0;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.ddKhoaHoc);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.txtTenNTL);
            this.sidePanel1.Controls.Add(this.bttLHuy);
            this.sidePanel1.Controls.Add(this.bttXoaNTL);
            this.sidePanel1.Controls.Add(this.bttSuaNTL);
            this.sidePanel1.Controls.Add(this.bttThemNTL);
            this.sidePanel1.Controls.Add(this.txtMaNTL);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel1.Location = new System.Drawing.Point(2, 70);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(386, 325);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // gcNTL
            // 
            this.gcNTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNTL.Location = new System.Drawing.Point(390, 0);
            this.gcNTL.MainView = this.gvNTL;
            this.gcNTL.Name = "gcNTL";
            this.gcNTL.Size = new System.Drawing.Size(462, 397);
            this.gcNTL.TabIndex = 1;
            this.gcNTL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNTL});
            // 
            // gvNTL
            // 
            this.gvNTL.GridControl = this.gcNTL;
            this.gvNTL.Name = "gvNTL";
            this.gvNTL.OptionsFind.AlwaysVisible = true;
            // 
            // rbXemToanBo
            // 
            this.rbXemToanBo.AutoSize = true;
            this.rbXemToanBo.Location = new System.Drawing.Point(13, 6);
            this.rbXemToanBo.Name = "rbXemToanBo";
            this.rbXemToanBo.Size = new System.Drawing.Size(108, 21);
            this.rbXemToanBo.TabIndex = 23;
            this.rbXemToanBo.TabStop = true;
            this.rbXemToanBo.Text = "Xem toàn bộ\r\n";
            this.rbXemToanBo.UseVisualStyleBackColor = true;
            // 
            // rdXemTheoKhoaHV
            // 
            this.rdXemTheoKhoaHV.AutoSize = true;
            this.rdXemTheoKhoaHV.Location = new System.Drawing.Point(13, 43);
            this.rdXemTheoKhoaHV.Name = "rdXemTheoKhoaHV";
            this.rdXemTheoKhoaHV.Size = new System.Drawing.Size(122, 21);
            this.rdXemTheoKhoaHV.TabIndex = 22;
            this.rdXemTheoKhoaHV.TabStop = true;
            this.rdXemTheoKhoaHV.Text = "Xem theo khóa";
            this.rdXemTheoKhoaHV.UseVisualStyleBackColor = true;
            // 
            // ddXemTheoKhoa
            // 
            this.ddXemTheoKhoa.Location = new System.Drawing.Point(186, 35);
            this.ddXemTheoKhoa.Name = "ddXemTheoKhoa";
            this.ddXemTheoKhoa.Size = new System.Drawing.Size(154, 29);
            this.ddXemTheoKhoa.TabIndex = 21;
            this.ddXemTheoKhoa.Text = "Khóa học";
            // 
            // bttLHuy
            // 
            this.bttLHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttLHuy.ImageOptions.Image")));
            this.bttLHuy.Location = new System.Drawing.Point(160, 271);
            this.bttLHuy.Name = "bttLHuy";
            this.bttLHuy.Size = new System.Drawing.Size(94, 35);
            this.bttLHuy.TabIndex = 60;
            this.bttLHuy.Text = "Hủy";
            // 
            // bttXoaNTL
            // 
            this.bttXoaNTL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttXoaKH.ImageOptions.Image")));
            this.bttXoaNTL.Location = new System.Drawing.Point(260, 223);
            this.bttXoaNTL.Name = "bttXoaNTL";
            this.bttXoaNTL.Size = new System.Drawing.Size(94, 29);
            this.bttXoaNTL.TabIndex = 59;
            this.bttXoaNTL.Text = "Xóa";
            // 
            // bttSuaNTL
            // 
            this.bttSuaNTL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttSuaKH.ImageOptions.Image")));
            this.bttSuaNTL.Location = new System.Drawing.Point(160, 223);
            this.bttSuaNTL.Name = "bttSuaNTL";
            this.bttSuaNTL.Size = new System.Drawing.Size(94, 29);
            this.bttSuaNTL.TabIndex = 58;
            this.bttSuaNTL.Text = "Sửa";
            // 
            // bttThemNTL
            // 
            this.bttThemNTL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttThemKH.ImageOptions.Image")));
            this.bttThemNTL.Location = new System.Drawing.Point(50, 223);
            this.bttThemNTL.Name = "bttThemNTL";
            this.bttThemNTL.Size = new System.Drawing.Size(94, 29);
            this.bttThemNTL.TabIndex = 57;
            this.bttThemNTL.Text = "Thêm";
            // 
            // txtMaNTL
            // 
            this.txtMaNTL.Enabled = false;
            this.txtMaNTL.Location = new System.Drawing.Point(145, 55);
            this.txtMaNTL.Name = "txtMaNTL";
            this.txtMaNTL.Size = new System.Drawing.Size(209, 22);
            this.txtMaNTL.TabIndex = 55;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 16);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã nhóm tài liệu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(132, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 17);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "NHÓM TÀI LIỆU";
            // 
            // txtTenNTL
            // 
            this.txtTenNTL.Enabled = false;
            this.txtTenNTL.Location = new System.Drawing.Point(145, 95);
            this.txtTenNTL.Name = "txtTenNTL";
            this.txtTenNTL.Size = new System.Drawing.Size(209, 22);
            this.txtTenNTL.TabIndex = 61;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 17);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Khóa học:";
            // 
            // ddKhoaHoc
            // 
            this.ddKhoaHoc.Location = new System.Drawing.Point(145, 149);
            this.ddKhoaHoc.Name = "ddKhoaHoc";
            this.ddKhoaHoc.Size = new System.Drawing.Size(209, 29);
            this.ddKhoaHoc.TabIndex = 63;
            this.ddKhoaHoc.Text = "dropDownButton1";
            // 
            // frNhomTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 397);
            this.Controls.Add(this.gcNTL);
            this.Controls.Add(this.panelControl1);
            this.Name = "frNhomTaiLieu";
            this.Text = "Nhóm tài liệu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNTL.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gcNTL;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNTL;
        private System.Windows.Forms.RadioButton rbXemToanBo;
        private System.Windows.Forms.RadioButton rdXemTheoKhoaHV;
        private DevExpress.XtraEditors.DropDownButton ddXemTheoKhoa;
        private DevExpress.XtraEditors.SimpleButton bttLHuy;
        private DevExpress.XtraEditors.SimpleButton bttXoaNTL;
        private DevExpress.XtraEditors.SimpleButton bttSuaNTL;
        private DevExpress.XtraEditors.SimpleButton bttThemNTL;
        private DevExpress.XtraEditors.TextEdit txtMaNTL;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DropDownButton ddKhoaHoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenNTL;
    }
}