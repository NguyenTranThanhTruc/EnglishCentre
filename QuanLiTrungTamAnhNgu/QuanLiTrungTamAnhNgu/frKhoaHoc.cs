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
    public partial class frKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        public frKhoaHoc()
        {
            InitializeComponent();
        }
        EnglishCenterDbContext context = new EnglishCenterDbContext();
        Query_KhoaHoc khoahoc = new Query_KhoaHoc();
        string ten_KH;
        string mota;
        private void bttThemKH_Click(object sender, EventArgs e)
        {
            if (txtTenKhoaHoc.Text != "" && txtMota.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm khóa học này chứ!", "Thêm Khóa Học", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ten_KH = txtTenKhoaHoc.Text;
                    mota = txtMota.Text;
                    if (khoahoc.Them_KhoaHoc(ten_KH, mota))
                    {
                        MessageBox.Show("Đã thêm level");
                        Load_KH();
                    }
                    else
                        MessageBox.Show(" Khóa Học Đã Tồn Tại");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Thêm Khóa Học ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttSuaKH_Click(object sender, EventArgs e)
        {
            if (txtMota.Text != "" && txtTenKhoaHoc.Text != "")
            {
                int id = Convert.ToInt32(gvKhoaHoc.GetRowCellValue(gvKhoaHoc.FocusedRowHandle, gvKhoaHoc.Columns[0]).ToString());
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin khóa học này chứ!", "Sửa Khóa Học", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ten_KH = txtTenKhoaHoc.Text;
                    mota = txtMota.Text;
                    if (khoahoc.Sua_KhoaHoc(id, ten_KH, mota))
                    {
                        MessageBox.Show("Đã Sửa level");
                        Load_KH();
                    }
                    else
                        MessageBox.Show(" Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Sửa Khóa Học ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttXoaKH_Click(object sender, EventArgs e)
        {
            if (txtTenKhoaHoc.Text != "" && txtMota.Text != "")
            {
                int id = Convert.ToInt32(gvKhoaHoc.GetRowCellValue(gvKhoaHoc.FocusedRowHandle, gvKhoaHoc.Columns[0]).ToString());

                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thông tin khóa học này chứ!", "Xóa Khóa Học", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ten_KH = txtTenKhoaHoc.Text;
                    mota = txtMota.Text;
                    if (khoahoc.Xoa_KhoaHoc(id))
                    {
                        MessageBox.Show("Đã Xóa Khóa Học");
                        Load_KH();
                    }
                    else
                        MessageBox.Show(" Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Xóa Khóa Học ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttLHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvKhoaHoc_Click(object sender, EventArgs e)
        {
            if (gvKhoaHoc.RowCount > 0)
            {
                txtTenKhoaHoc.EditValue = gvKhoaHoc.GetRowCellValue(gvKhoaHoc.FocusedRowHandle, gvKhoaHoc.Columns[1]).ToString();
                txtMota.Text = gvKhoaHoc.GetRowCellValue(gvKhoaHoc.FocusedRowHandle, gvKhoaHoc.Columns[2]).ToString();
            }
        }
        private void Load_KH()
        {
            var khoahoc = (from kh in context.KhoaHocs
                           select new
                           {
                               kh.ID_KH,
                               kh.Ten_KH,
                               kh.MoTa
                           }).ToList();
            gcKhoaHoc.DataSource = khoahoc;
            gvKhoaHoc.Columns[0].Visible = false;
            gvKhoaHoc.Columns[1].Caption = "Tên Khoa Học ";
            gvKhoaHoc.Columns[2].Caption = "Mô Tả Khóa Học";

        }

        private void frKhoaHoc_Load(object sender, EventArgs e)
        {
            Load_KH();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenKhoaHoc.Text = "";
            txtMota.Text = "";
        }
    }
}