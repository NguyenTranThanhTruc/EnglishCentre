namespace QuanLiTrungTamAnhNgu
{
    partial class frKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frKhoaHoc));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bttLHuy = new DevExpress.XtraEditors.SimpleButton();
            this.bttXoaKH = new DevExpress.XtraEditors.SimpleButton();
            this.bttSuaKH = new DevExpress.XtraEditors.SimpleButton();
            this.bttThemKH = new DevExpress.XtraEditors.SimpleButton();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtTenKhoaHoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcKhoaHoc = new DevExpress.XtraGrid.GridControl();
            this.gvKhoaHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoaHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.bttLHuy);
            this.panelControl1.Controls.Add(this.bttXoaKH);
            this.panelControl1.Controls.Add(this.bttSuaKH);
            this.panelControl1.Controls.Add(this.bttThemKH);
            this.panelControl1.Controls.Add(this.txtMota);
            this.panelControl1.Controls.Add(this.txtTenKhoaHoc);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(341, 406);
            this.panelControl1.TabIndex = 0;
            // 
            // bttLHuy
            // 
            this.bttLHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttLHuy.ImageOptions.Image")));
            this.bttLHuy.Location = new System.Drawing.Point(118, 336);
            this.bttLHuy.Name = "bttLHuy";
            this.bttLHuy.Size = new System.Drawing.Size(94, 35);
            this.bttLHuy.TabIndex = 51;
            this.bttLHuy.Text = "Hủy";
            this.bttLHuy.Click += new System.EventHandler(this.bttLHuy_Click);
            // 
            // bttXoaKH
            // 
            this.bttXoaKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttXoaKH.ImageOptions.Image")));
            this.bttXoaKH.Location = new System.Drawing.Point(218, 288);
            this.bttXoaKH.Name = "bttXoaKH";
            this.bttXoaKH.Size = new System.Drawing.Size(94, 29);
            this.bttXoaKH.TabIndex = 50;
            this.bttXoaKH.Text = "Xóa";
            this.bttXoaKH.Click += new System.EventHandler(this.bttXoaKH_Click);
            // 
            // bttSuaKH
            // 
            this.bttSuaKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttSuaKH.ImageOptions.Image")));
            this.bttSuaKH.Location = new System.Drawing.Point(118, 288);
            this.bttSuaKH.Name = "bttSuaKH";
            this.bttSuaKH.Size = new System.Drawing.Size(94, 29);
            this.bttSuaKH.TabIndex = 49;
            this.bttSuaKH.Text = "Sửa";
            this.bttSuaKH.Click += new System.EventHandler(this.bttSuaKH_Click);
            // 
            // bttThemKH
            // 
            this.bttThemKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttThemKH.ImageOptions.Image")));
            this.bttThemKH.Location = new System.Drawing.Point(8, 288);
            this.bttThemKH.Name = "bttThemKH";
            this.bttThemKH.Size = new System.Drawing.Size(94, 29);
            this.bttThemKH.TabIndex = 48;
            this.bttThemKH.Text = "Thêm";
            this.bttThemKH.Click += new System.EventHandler(this.bttThemKH_Click);
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(105, 109);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(209, 145);
            this.txtMota.TabIndex = 46;
            // 
            // txtTenKhoaHoc
            // 
            this.txtTenKhoaHoc.Location = new System.Drawing.Point(105, 66);
            this.txtTenKhoaHoc.Name = "txtTenKhoaHoc";
            this.txtTenKhoaHoc.Size = new System.Drawing.Size(209, 22);
            this.txtTenKhoaHoc.TabIndex = 44;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 17);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Mô tả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên khóa học:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "THÔNG TIN KHÓA HỌC";
            // 
            // gcKhoaHoc
            // 
            this.gcKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoaHoc.Location = new System.Drawing.Point(341, 0);
            this.gcKhoaHoc.MainView = this.gvKhoaHoc;
            this.gcKhoaHoc.Name = "gcKhoaHoc";
            this.gcKhoaHoc.Size = new System.Drawing.Size(558, 406);
            this.gcKhoaHoc.TabIndex = 1;
            this.gcKhoaHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoaHoc});
            // 
            // gvKhoaHoc
            // 
            this.gvKhoaHoc.GridControl = this.gcKhoaHoc;
            this.gvKhoaHoc.Name = "gvKhoaHoc";
            this.gvKhoaHoc.OptionsFind.AlwaysVisible = true;
            this.gvKhoaHoc.Click += new System.EventHandler(this.gvKhoaHoc_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(220, 336);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 35);
            this.btnRefresh.TabIndex = 52;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 406);
            this.Controls.Add(this.gcKhoaHoc);
            this.Controls.Add(this.panelControl1);
            this.Name = "frKhoaHoc";
            this.Text = "Khóa học ";
            this.Load += new System.EventHandler(this.frKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoaHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoaHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcKhoaHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoaHoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenKhoaHoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMota;
        private DevExpress.XtraEditors.SimpleButton bttLHuy;
        private DevExpress.XtraEditors.SimpleButton bttXoaKH;
        private DevExpress.XtraEditors.SimpleButton bttSuaKH;
        private DevExpress.XtraEditors.SimpleButton bttThemKH;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}