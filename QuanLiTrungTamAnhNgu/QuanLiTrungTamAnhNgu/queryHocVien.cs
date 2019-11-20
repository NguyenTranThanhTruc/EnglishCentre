using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTrungTamAnhNgu
{
    class queryHocVien
    {
        EnglishCenterEntities2 _db = new EnglishCenterEntities2();
        public bool checkHocVien(string hoTen)
        {
            var query = (from item in _db.HocViens
                         where item.HoTen_HV.Contains(hoTen)
                         select item).Count();
            if (Convert.ToInt32(query) == 0)
                return false;
            else return true;

            // false chua co ng
            //true co ng
        }


        public void insertHocVien( string hoTen, DateTime ngaySinh , string diaChi, string email, string soDienThoai)
        {
        //    var countHV = (from item in _db.HocViens
        //                   select item).Count();
        //    int id = Convert.ToInt32(countHV)+1;
        //    string maHV = "HV" + id;
            var hocVien = new HocVien
            {
               
                HoTen_HV = hoTen,
                NgaySinh_HV = ngaySinh,
                DiaChi_HV = diaChi,
                Email_HV = email,
                SDT_HV = soDienThoai
            };
            _db.HocViens.Add(hocVien);
            _db.SaveChanges();
        }
        public bool updateHocVien (string hoTen, DateTime ngaySinh, string diaChi, string email, string soDienThoai)
        {
           if(checkHocVien(hoTen))
           {
                var hocVien = new HocVien
                {
                    HoTen_HV = hoTen,
                    NgaySinh_HV = ngaySinh,
                    DiaChi_HV = diaChi,
                    Email_HV = email,
                    SDT_HV = soDienThoai
                };
                _db.Entry(hocVien).State = EntityState.Modified;
                _db.SaveChanges();
                return true;
           }
            return false;
         
        }
    }
}
