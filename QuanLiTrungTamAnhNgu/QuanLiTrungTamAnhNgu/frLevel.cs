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
    public partial class frLevel : DevExpress.XtraEditors.XtraForm
    {
        public frLevel()
        {
            InitializeComponent();
        }
        EnglishCenterDbContext context = new EnglishCenterDbContext();
        Query_Level level = new Query_Level();
        string tenLevel;
        string moTa;
        private void bttThemLv_Click(object sender, EventArgs e)
        {
            if (txtLevel.Text != "" && txtMoTaLevel.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm level này chứ!", "Thêm level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    tenLevel = txtLevel.Text;
                    moTa = txtMoTaLevel.Text;
                    if (level.Them_Level(tenLevel, moTa))
                    {
                        MessageBox.Show("Đã thêm level");
                        Load_Level();
                    }
                    else
                        MessageBox.Show(" Level Đã Tồn Tại");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Thêm level ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttSuaLv_Click(object sender, EventArgs e)
        {
            if (txtLevel.Text != "" && txtMoTaLevel.Text != "")
            {
                int id = Convert.ToInt32(gvLevel.GetRowCellValue(gvLevel.FocusedRowHandle, gvLevel.Columns[0]).ToString());
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin level này chứ!", "Sửa level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    tenLevel = txtLevel.Text;
                    moTa = txtMoTaLevel.Text;
                    if (level.SuaLevel(id, tenLevel, moTa))
                    {
                        MessageBox.Show("Đã Sửa level");
                        Load_Level();
                    }
                    else
                        MessageBox.Show(" Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Sửa level ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvLevel_Click(object sender, EventArgs e)
        {
            if (gvLevel.RowCount > 0)
            {
                txtLevel.EditValue = gvLevel.GetRowCellValue(gvLevel.FocusedRowHandle, gvLevel.Columns[1]).ToString();
                txtMoTaLevel.Text = gvLevel.GetRowCellValue(gvLevel.FocusedRowHandle, gvLevel.Columns[2]).ToString();
            }
        }



        private void bttXoaLv_Click(object sender, EventArgs e)
        {
            if (txtLevel.Text != "" && txtMoTaLevel.Text != "")
            {
                int id = Convert.ToInt32(gvLevel.GetRowCellValue(gvLevel.FocusedRowHandle, gvLevel.Columns[0]).ToString());
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thông tin level này chứ!", "Xóa level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    tenLevel = txtLevel.Text;
                    moTa = txtMoTaLevel.Text;
                    if (level.XoaLevel(id))
                    {
                        MessageBox.Show("Đã Xóa level");
                        Load_Level();
                    }
                    else
                        MessageBox.Show(" Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Xóa level ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Load_Level()
        {
            var levels = (from lv in context.Levels
                          select new
                          {
                              lv.ID_Level,
                              lv.Ten_Level,
                              lv.MoTa
                          }).ToList();
            gcLevel.DataSource = levels;
            gvLevel.Columns[0].Visible = false;
            gvLevel.Columns[1].Caption = "Tên Level";
            gvLevel.Columns[2].Caption = "Mô Tả Level";


        }

        private void frLevel_Load(object sender, EventArgs e)
        {
            Load_Level();
        }

        private void bttLHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtLevel.Text = "";
            txtMoTaLevel.Text = "";
        }
    }
}