//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiTrungTamAnhNgu
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.LopHocs = new HashSet<LopHoc>();
            this.PhieuThus = new HashSet<PhieuThu>();
            this.TaikhoanGiaoViens = new HashSet<TaikhoanGiaoVien>();
        }
    
        public int ID_NV { get; set; }
        public string Ma_GV { get; set; }
        public string HoTen_NV { get; set; }
        public string ChucVu { get; set; }
        public string Email { get; set; }
        public string SDT_NV { get; set; }
        public string CMND { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThu> PhieuThus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaikhoanGiaoVien> TaikhoanGiaoViens { get; set; }
    }
}