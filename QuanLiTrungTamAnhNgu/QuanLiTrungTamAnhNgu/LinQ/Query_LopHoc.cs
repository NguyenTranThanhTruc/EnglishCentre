using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTrungTamAnhNgu.LinQ
{
    public class Query_LopHoc
    {
        EnglishCenterDbContext context = new EnglishCenterDbContext();
        public bool ThemLopHoc(string tenlop, int id_gv, int id_kh, string malop, DateTime ngaybatdau, DateTime ngayketthuc, decimal hocphi, int id_lv, string khunggiohoc, int sobuoihoc)
        { 
            if (LayIdLopHocTheoMaLH(malop)==null)
            {
                var lopHoc = new LopHoc()
                {
                    Ten_LH = tenlop,
                    ID_GV = id_gv,
                    ID_KH = id_kh,
                    ID_Level = id_lv,
                    Ma_LH = malop,
                    ThoiGianBatDau_LH = ngaybatdau,
                    ThoiGianKetThuc_LH = ngayketthuc,
                    HocPhi = hocphi,
                    KhungGioHoc = khunggiohoc,
                    SoBuoiHoc=sobuoihoc
                };
                context.Entry(lopHoc).State = EntityState.Added;
                context.SaveChanges();
                return true;
            }
            return false;
      
        }
        public LopHoc LayIdLopHocTheoMaLH(string maLH)
        {
            var lopHoc= context.LopHocs
                .Where(p=>p.Ma_LH.ToUpper().Contains(maLH.ToUpper())).FirstOrDefault();
            return lopHoc;
        }
        public bool Sua_LopHoc(int id, string tenlop, int id_gv, int id_kh, string malop, DateTime ngaybatdau, DateTime ngayketthuc, decimal hocphi, int id_lv, string khunggiohoc, int sobuoihoc)
        {
            if (id!=0)
            {
                var lophoc = context.LopHocs
                              .Where(lh => lh.ID_LH== id)
                              .FirstOrDefault();
                lophoc.Ten_LH = tenlop;
                lophoc.ID_GV = id_gv;
                lophoc.ID_KH = id_kh;
                lophoc.ID_Level = id_lv;
                lophoc.Ma_LH = malop;
                lophoc.ThoiGianBatDau_LH = ngaybatdau;
                lophoc.ThoiGianKetThuc_LH = ngayketthuc;
                lophoc.HocPhi = hocphi;
                lophoc.KhungGioHoc = khunggiohoc;
                lophoc.SoBuoiHoc = sobuoihoc;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Xoa_LopHoc(int id)
        {
            if (id != 0)
            {
                var lophoc = context.LopHocs
                             .Where(lh => lh.ID_LH == id)
                             .FirstOrDefault();
                context.LopHocs.Remove(lophoc);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
