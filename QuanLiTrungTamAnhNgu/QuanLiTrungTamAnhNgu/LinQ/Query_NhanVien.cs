using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace QuanLiTrungTamAnhNgu.LinQ
{
    public class Query_NhanVien
    {
        EnglishCenterDbContext context = new EnglishCenterDbContext();

        public bool Them_NhanVien(string hoten, string chucvu, string email_nv, string sdt_nv, string cmnd_nv, DateTime ngaysinh)
        {
            if (KiemTraNhanVienTheoCMND(cmnd_nv))
            {
                var nhanvien = new NhanVien()
                {
                    HoTen_NV = hoten,
                    ChucVu = chucvu,
                    Email = email_nv,
                    SDT_NV = sdt_nv,
                    CMND = cmnd_nv,
                    Birthday = ngaysinh
                };
                context.Entry(nhanvien).State = EntityState.Added;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool KiemTraNhanVienTheoCMND(string cmnd)
        {
            var nhanvien = context.NhanViens
                .Where(nv => nv.CMND.Contains(cmnd))
                .FirstOrDefault();
            if (nhanvien == null)
                return true;
            return false;
        }
        public int LayIdNhanVienTheoCMND(string cmnd)
        {
            var nhanvien = context.NhanViens
                .Where(nv => nv.CMND.Contains(cmnd))
                .FirstOrDefault();
            return nhanvien.ID_NV;
        }
        public bool CapNhatMaNhanVien(string manv, string cmnd)
        {
            var nhanvien = context.NhanViens
                   .Where(nv => nv.CMND.Contains(cmnd))
                   .FirstOrDefault();
            if (nhanvien != null)
            {
                nhanvien.Ma_GV = manv;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool CapNhatNhanVien(string hoten, string chucvu, string email_nv, string sdt_nv, string cmnd_nv, DateTime ngaysinh)
        {
            int id = LayIdNhanVienTheoCMND(cmnd_nv);
            if (!KiemTraNhanVienTheoCMND(cmnd_nv))
            {
                var nhanvien = context.NhanViens
                              .Where(nv => nv.ID_NV==id)
                              .SingleOrDefault();
                nhanvien.HoTen_NV = hoten;
                nhanvien.ChucVu = chucvu;
                nhanvien.Email = email_nv;
                nhanvien.SDT_NV = sdt_nv;
                nhanvien.CMND = cmnd_nv;
                nhanvien.Birthday = ngaysinh;
                context.Entry(nhanvien).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaNhanVien(string cmnd)
        {
            int id = LayIdNhanVienTheoCMND(cmnd);
            var nhanvien = context.NhanViens
                              .Where(nv => nv.ID_NV == id)
                              .SingleOrDefault();
            if (nhanvien != null)
            {
                context.NhanViens.Remove(nhanvien);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
