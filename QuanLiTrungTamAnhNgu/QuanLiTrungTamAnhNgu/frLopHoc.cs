using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLiTrungTamAnhNgu.LinQ;


namespace QuanLiTrungTamAnhNgu
{
    public partial class frLopHoc : DevExpress.XtraEditors.XtraForm
    {
        public frLopHoc()
        {
            InitializeComponent();
        }
        EnglishCenterDbContext context = new EnglishCenterDbContext();
        Query_LopHoc lopHoc = new Query_LopHoc();
        string tenlh;
        int id_gv;
        int id_kh;
        int id_lv;
        string malh;
        decimal hocphi;
        string khunggiohoc;
        DateTime ngaybatdau;
        DateTime ngayketthuc;
        int sobuoihoc;

        private void frLopHoc_Load(object sender, EventArgs e)
        {
            Load_CbGiaoVien();
            Load_CbKhoaHoc();
            Load_CbLevel();
            Load_LopHoc();
        }
        private void Load_CbGiaoVien()
        {
            cbxGV.Properties.DataSource = (from nhanvien in context.NhanViens
                                           where nhanvien.ChucVu.Contains("Giáo Viên")
                                           select new { nhanvien.HoTen_NV, nhanvien.ID_NV }).ToList();
              
            cbxGV.Properties.DisplayMember = "HoTen_NV";
            cbxGV.Properties.ValueMember = "ID_NV";
            cbxGV.Properties.PopulateColumns();
            cbxGV.Properties.Columns["ID_NV"].Visible = false;
        }
        private void Load_CbKhoaHoc()
        {
            cbxKhoaHoc.Properties.DataSource = (from khoahoc in context.KhoaHocs
                                                select new { khoahoc.Ten_KH, khoahoc.ID_KH }).ToList();
            cbxKhoaHoc.Properties.DisplayMember = "Ten_KH";
            cbxKhoaHoc.Properties.ValueMember = "ID_KH";
            cbxKhoaHoc.Properties.PopulateColumns();
            cbxKhoaHoc.Properties.Columns["ID_KH"].Visible = false;
        }
        private void Load_CbLevel()
        {
            cbxLevel.Properties.DataSource = (from level in context.Levels
                                                select new { level.Ten_Level, level.ID_Level }).ToList();
            cbxLevel.Properties.DisplayMember = "Ten_Level";
            cbxLevel.Properties.ValueMember = "ID_Level";
            cbxLevel.Properties.PopulateColumns();
            cbxLevel.Properties.Columns["ID_Level"].Visible = false;

        }

        private void bttThemLH_Click(object sender, EventArgs e)
        {
            if (txtHocPhi.Text.Replace(" ", "") != "" && txtMaLop.Text.Replace(" ", "") != "" && txtTenLop.Text.Replace(" ", "") != ""
                && cbxGV.Text!="" && cbxKhoaHoc.Text!=""&&cbxLevel.Text!="")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm lớp học  này chứ!", "Thêm Lớp Học ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    tenlh = txtTenLop.Text;
                    malh = txtMaLop.Text;
                    id_gv = Convert.ToInt32(cbxGV.EditValue);
                    id_kh = Convert.ToInt32(cbxKhoaHoc.EditValue);
                    id_lv = Convert.ToInt32(cbxLevel.EditValue);
                    hocphi = Convert.ToDecimal(txtHocPhi.Text);
                    sobuoihoc = Convert.ToInt32(txtSoBuoiHoc.Text);
                    khunggiohoc = txtThoiGianHoc.Text;
                    ngaybatdau = Convert.ToDateTime(dtThoiGianBatDau.Value);
                    ngayketthuc = Convert.ToDateTime(dtThoiGianKetThuc.Value);


                    if (lopHoc.LayIdLopHocTheoMaLH(malh)==null)
                    {
                        if (lopHoc.ThemLopHoc(tenlh,id_gv,id_kh,malh,ngaybatdau,ngayketthuc,hocphi,id_lv,khunggiohoc,sobuoihoc))
                        {
                            MessageBox.Show("Đã thêm Lớp Học");
                            Load_LopHoc();
                        }
                        else
                            MessageBox.Show("Lỗi");
                    }
                    else
                    {
                       
                        MessageBox.Show("Lớp Học đã tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền hết thông tin", "Thêm Lớp Học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttSuaLH_Click(object sender, EventArgs e)
        {
            if (txtHocPhi.Text.Replace(" ", "") != "" && txtMaLop.Text.Replace(" ", "") != "" && txtTenLop.Text.Replace(" ", "") != ""
                && cbxGV.Text != "" && cbxKhoaHoc.Text != "" && cbxLevel.Text != "")
            {
                int id = Convert.ToInt32(gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[0]).ToString());

                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin lớp học  này không?", "Sửa Lớp Học ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    tenlh = txtTenLop.Text;
                    malh = txtMaLop.Text;
                    id_gv = Convert.ToInt32(cbxGV.EditValue);
                    id_kh = Convert.ToInt32(cbxKhoaHoc.EditValue);
                    id_lv = Convert.ToInt32(cbxLevel.EditValue);
                    hocphi = Convert.ToDecimal(txtHocPhi.Text);
                    sobuoihoc = Convert.ToInt32(txtSoBuoiHoc.Text);
                    khunggiohoc = txtThoiGianHoc.Text;
                    ngaybatdau = Convert.ToDateTime(dtThoiGianBatDau.Value);
                    ngayketthuc = Convert.ToDateTime(dtThoiGianKetThuc.Value);


                    if (lopHoc.Sua_LopHoc(id,tenlh, id_gv, id_kh, malh, ngaybatdau, ngayketthuc, hocphi, id_lv, khunggiohoc, sobuoihoc))
                    {
                        MessageBox.Show("Đã Sửa Lớp Học");
                        Load_LopHoc();
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền hết thông tin", "Sửa Lớp Học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttXoaLH_Click(object sender, EventArgs e)
        {
            if (txtHocPhi.Text.Replace(" ", "") != "" && txtMaLop.Text.Replace(" ", "") != "" && txtTenLop.Text.Replace(" ", "") != ""
                && cbxGV.Text != "" && cbxKhoaHoc.Text != "" && cbxLevel.Text != "")
            {
                int id = Convert.ToInt32(gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[0]).ToString());
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa lớp học  này chứ!", "Xóa Lớp Học ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    malh = txtMaLop.Text;
                    if (lopHoc.Xoa_LopHoc(id))
                    {
                        MessageBox.Show("Đã xóa Lớp Học");
                        Load_LopHoc();
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền hết thông tin", "Xóa Lớp Học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttLHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load_LopHoc()
        {
            var lophocs = (from lh in context.LopHocs
                           .Include("KhoaHocs").Include("GiaoViens").Include("Levels")
                           select new
                           {
                               lh.ID_LH,
                               lh.Ten_LH,
                               lh.Ma_LH,
                               lh.NhanVien.HoTen_NV,
                               lh.KhoaHoc.Ten_KH,
                               lh.Level.Ten_Level,
                               lh.HocPhi,
                               lh.ThoiGianBatDau_LH,
                               lh.ThoiGianKetThuc_LH,
                               lh.SoBuoiHoc,
                               lh.KhungGioHoc                               
                           }).ToList();
            gcLopHoc.DataSource = lophocs;
            gvLopHoc.Columns[0].Visible = false;
            gvLopHoc.Columns[1].Caption = "Tên Lớp Học";
            gvLopHoc.Columns[2].Caption = "Mã Lớp Học";
            gvLopHoc.Columns[3].Caption = "Họ Tên Giáo Viên";
            gvLopHoc.Columns[4].Caption = "Tên Khóa Học";
            gvLopHoc.Columns[5].Caption = "Level";
            gvLopHoc.Columns[6].Caption = "Học Phí";
            gvLopHoc.Columns[7].Caption = "Thời Gian Bắt Đầu";
            gvLopHoc.Columns[8].Caption = "Thời Gian Kết Thúc";
            gvLopHoc.Columns[9].Caption = "Số Buổi Học";
            gvLopHoc.Columns[10].Caption = "Khung Giờ Học";
        }

        private void gvLopHoc_Click(object sender, EventArgs e)
        {
           
            if (gvLopHoc.RowCount > 0)
            {
                txtTenLop.EditValue = gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[1]).ToString();
                cbxGV.Text = gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[3]).ToString();
                cbxKhoaHoc.Text = gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[4]).ToString();
                cbxLevel.Text = gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[5]).ToString();
                txtMaLop.EditValue = gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[2]).ToString();
                dtThoiGianBatDau.Value = DateTime.Parse(gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[7]).ToString());
                dtThoiGianKetThuc.Value = DateTime.Parse(gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[8]).ToString());
                txtSoBuoiHoc.EditValue = gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[9]).ToString();
                txtHocPhi.EditValue = gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[6]).ToString();
                txtThoiGianHoc.EditValue = gvLopHoc.GetRowCellValue(gvLopHoc.FocusedRowHandle, gvLopHoc.Columns[10]).ToString();
            }
        }

        private void drdbttXemTheoKhoaLH_Click(object sender, EventArgs e)
        {

        }
    }
}