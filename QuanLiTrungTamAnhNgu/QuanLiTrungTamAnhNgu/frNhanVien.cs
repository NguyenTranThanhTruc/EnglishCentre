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
    public partial class frNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frNhanVien()
        {
            InitializeComponent();
        }

        EnglishCenterEntities2 context = new EnglishCenterEntities2();
        private void frNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void bttThemNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien()
            {
                HoTen_NV=txtHoTenNV.Text,
                Email=txtEmailNV.Text,
                SDT_NV=txtSoDienThoaiNV.Text,
                ChucVu=txtChucVu.Text,
                CMND=txtCMND.Text
            };
            context.NhanViens.Add(nv);
            context.SaveChanges();
        }

    }
}