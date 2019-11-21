using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuanLiTrungTamAnhNgu.LinQ
{
    public class Query_Level
    {
        EnglishCenterDbContext context = new EnglishCenterDbContext();
        public bool Them_Level(string tenLevel, string mota)
        {         
            if (KiemTraLevel(tenLevel) == null)
            {
                var level = new Level()
                {
                    Ten_Level = tenLevel,
                    MoTa = mota
                };
                context.Entry(level).State = EntityState.Added;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Level KiemTraLevel(string tenLevel)
        {
            var query = context.Levels
                .Where(lv => lv.Ten_Level.ToUpper().Contains(tenLevel.ToUpper())).FirstOrDefault();
            return query;
        }
        public bool SuaLevel(int id,string ten, string mota)
        {
            if (id != 0)
            {
                var level = context.Levels
                              .Where(nv => nv.ID_Level == id)
                              .FirstOrDefault();
                level.Ten_Level = ten;
                level.MoTa = mota;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaLevel(int id)
        {
            if (id != 0)
            {
                var level = context.Levels
                              .Where(nv => nv.ID_Level == id)
                              .FirstOrDefault();
                context.Levels.Remove(level);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
