using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTrungTamAnhNgu.LinQ
{

    public class Query_KhoaHoc
    {
        EnglishCenterDbContext context = new EnglishCenterDbContext();
        public bool Them_KhoaHoc(string ten, string mota)
        {
            if (LayIdKhoaHocTheoTen(ten) == null)
            {
                var khoahoc = new KhoaHoc()
                {
                    Ten_KH = ten,
                    MoTa = mota
                };
                context.Entry(khoahoc).State = EntityState.Added;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public KhoaHoc LayIdKhoaHocTheoTen(string ten)
        {
            var khoaHoc = context.KhoaHocs
                .Where(p => p.Ten_KH.ToUpper().Contains(ten.ToUpper())).FirstOrDefault();
            return khoaHoc;
        }
        public bool Sua_KhoaHoc(int id, string ten, string mota)
        {
            if (id != 0)
            {

                var kh = context.KhoaHocs
                              .Where(h => h.ID_KH == id)
                              .SingleOrDefault();
                kh.Ten_KH = ten;
                kh.MoTa = mota;
                context.Entry(kh).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Xoa_KhoaHoc(int id)
        {
            if (id != 0)
            {
                var kh = context.KhoaHocs
                             .Where(h => h.ID_KH == id)
                             .SingleOrDefault();
                context.KhoaHocs.Remove(kh);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
