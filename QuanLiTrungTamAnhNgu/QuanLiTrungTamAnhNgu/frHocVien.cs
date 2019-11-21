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

namespace QuanLiTrungTamAnhNgu
{
    public partial class frHocVien : DevExpress.XtraEditors.XtraForm
    {
        public frHocVien()
        {
            InitializeComponent();
        }

        private void frHocVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'englishCenterDataSet.HocVien' table. You can move, or remove it, as needed.
            this.WindowState = FormWindowState.Maximized;

        }
        EnglishCenterDbContext _db = new EnglishCenterDbContext();
        queryHocVien hocvien = new queryHocVien();
        //Khai bao bien


        private void Load_HocVien()
        {
            gcHocVien.DataSource = (from item in _db.HocViens
                                    select new { item.Ma_HV, item.HoTen_HV, item.NgaySinh_HV, item.DiaChi_HV, item.Email_HV, item.SDT_HV }).ToList();
            gvHocVien.Columns[0].Caption = "Mã học viên";
            gvHocVien.Columns[1].Caption = "Họ tên";
            gvHocVien.Columns[2].Caption = "Ngày sinh";
            gvHocVien.Columns[3].Caption = "Địa chỉ";
            gvHocVien.Columns[4].Caption = "Email";
            gvHocVien.Columns[5].Caption = "Số điện thoại";

        }
        private void bttThemHV_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTenHV.Text;
            string diaChi = txtDiaChiHV.Text;
            string email = txtEmailHV.Text;
            DateTime ngaySinh = dateTimeNgaySinh.Value;
            string soDienThoai = txtSoDienThoaiHV.Text;
            if (txtHoTenHV.Text == null ||
              txtDiaChiHV.Text == null ||
              txtEmailHV.Text == null ||
              txtSoDienThoaiHV.Text == null)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!", "Thêm học viên.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm học viên này hả?", "Thêm học viên.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult==DialogResult.Yes)
                {
                    hocvien.insertHocVien(hoTen, ngaySinh, diaChi, email, soDienThoai);
                    MessageBox.Show("Bạn đã thêm học viên thành công!", "Thêm học viên.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_HocVien();
                }
            }
        }

        private void bttSuaHV_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTenHV.Text;
            string diaChi = txtDiaChiHV.Text;
            string email = txtEmailHV.Text;
            DateTime ngaySinh = dateTimeNgaySinh.Value;
            string soDienThoai = txtSoDienThoaiHV.Text;
            if (txtHoTenHV.Text == null ||
             txtDiaChiHV.Text == null ||
             txtEmailHV.Text == null ||
             txtSoDienThoaiHV.Text == null)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!", "Thêm học viên.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Bạn muốn sua thong tin học viên này hả?", "Thêm học viên.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (hocvien.updateHocVien(hoTen, ngaySinh, diaChi, email, soDienThoai))
                    {
                        MessageBox.Show("Bạn đã sua thành công!", "Thêm học viên.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nhan Vien chua duoc cap nhat vao");
                    }
                    Load_HocVien();
                 

                }
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttLHuy_Click(object sender, EventArgs e)
        {
            Load_HocVien();
        }
    }
}