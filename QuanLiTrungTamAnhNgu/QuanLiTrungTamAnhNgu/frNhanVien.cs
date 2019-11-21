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
    public partial class frNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frNhanVien()
        {
            InitializeComponent();
        }

        Query_NhanVien nhanVien = new Query_NhanVien();

        EnglishCenterDbContext context = new EnglishCenterDbContext();
        private void frNhanVien_Load(object sender, EventArgs e)
        {
            Load_CbChucVu();
            Load_NV();
        }
        string hoten;
        string chucvu;
        string sdt;
        string cmnd;
        string email;
        DateTime ngaysinh;
        string manv;
        private void bttThemNV_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text.Replace(" ", "") != "" && txtSoDienThoaiNV.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm nhân viên  này chứ!", "Thêm nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    hoten = txtHoTenNV.Text;
                    chucvu = cbxChucVu.Text;
                    sdt = txtSoDienThoaiNV.Text;
                    cmnd = txtCMND.Text;
                    email = txtEmailNV.Text;
                    ngaysinh = Convert.ToDateTime(dtNgaySinh.Value);

                    if (nhanVien.KiemTraNhanVienTheoCMND(cmnd))
                    {
                        if (nhanVien.Them_NhanVien(hoten, chucvu, email, sdt, cmnd, ngaysinh))
                        {
                            manv = GetMaNV(cbxChucVu.Text, nhanVien.LayIdNhanVienTheoCMND(cmnd));
                            if (nhanVien.CapNhatMaNhanVien(manv, cmnd))
                            {
                                Load_NV();
                                MessageBox.Show("Đã thêm nhân viên");
                            }
                        }
                        else
                            MessageBox.Show("Nhân viên chuaw được thêm vào");
                    }
                    else
                    {
                        MessageBox.Show("Nhân Viên đã tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền hết thông tin", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bttSuaNV_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text != "" && txtEmailNV.Text != "" && txtSoDienThoaiNV.Text != "" && txtCMND.Text != "" && cbxChucVu.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin nhân viên này chứ!", "Sửa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ngaysinh = Convert.ToDateTime(dtNgaySinh.Value);
                    if (nhanVien.CapNhatNhanVien(txtHoTenNV.Text, cbxChucVu.Text, txtEmailNV.Text, txtSoDienThoaiNV.Text, txtCMND.Text, ngaysinh))
                    {
                        MessageBox.Show("Đã sửa thông tin nhân viên ");
                        Load_NV();
                    }
                    else
                        MessageBox.Show(" Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Sửa Nhân Viên ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttXoaNV_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text.Replace(" ", "") != "" && txtSoDienThoaiNV.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "" && cbxChucVu.Text.Replace(" ", "") != "" && txtEmailNV.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên  này chứ!", "Xóa nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    cmnd = txtCMND.Text;
                    if (nhanVien.XoaNhanVien(cmnd))
                    {
                        MessageBox.Show("Da xoa nhan vien");
                    }
                    else
                        MessageBox.Show("Nhan Vien chua duoc xoa vao");
                }
                Load_NV();
            }
            else
            {
                MessageBox.Show("Vui Long dien het thong tin", "Xóa Nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtHoTenNV.Text = "";
            txtSoDienThoaiNV.Text = "";
            txtEmailNV.Text = "";
            txtCMND.Text = "";
            cbxChucVu.Text = "";
        }
        private void Load_NV()
        {

            var nhanViens = (from nhanvien in context.NhanViens
                             select new
                             {
                                 nhanvien.HoTen_NV,
                                 nhanvien.Ma_GV,
                                 nhanvien.ChucVu,
                                 nhanvien.Email,
                                 nhanvien.SDT_NV,
                                 nhanvien.CMND,
                                 nhanvien.Birthday,
                             }).ToList();
            gcNhanVien.DataSource = nhanViens;
            gvNhanVien.Columns[0].Caption = "Họ tên";
            gvNhanVien.Columns[1].Caption = "Mã Nhân Viên";
            gvNhanVien.Columns[2].Caption = "Chức vụ";
            gvNhanVien.Columns[3].Caption = "Email";
            gvNhanVien.Columns[4].Caption = "Số điện thoại";
            gvNhanVien.Columns[5].Caption = "CMND";
            gvNhanVien.Columns[6].Caption = "Ngày sinh";
        }
        private void Load_CbChucVu()
        {
            cbxChucVu.Items.Add("Kế Toán");
            cbxChucVu.Items.Add("Giáo Viên");
            cbxChucVu.Items.Add("Nhân Viến");
        }
        private string GetMaNV(string chucvu, int id)
        {
            switch (chucvu)
            {
                case "Nhân Viên":
                    manv = "NV_" + id;
                    break;
                case "Kế Toán":
                    manv = "KT_" + id;
                    break;
                case "Giáo Viên":
                    manv = "GV_" + id;
                    break;
            }
            return manv;
        }

       

        private void gvNhanVien_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.RowCount > 0)
            {
                txtHoTenNV.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[0]).ToString();
                cbxChucVu.Text = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[2]).ToString();
                txtEmailNV.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[3]).ToString();
                txtSoDienThoaiNV.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[4]).ToString();
                txtCMND.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[5]).ToString();
                dtNgaySinh.Value = DateTime.Parse(gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[6]).ToString());
            }
        }
    }
}