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
    
    public partial class HocVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocVien()
        {
            this.PhieuThus = new HashSet<PhieuThu>();
            this.TaiKhoanHocViens = new HashSet<TaiKhoanHocVien>();
        }
    
        public int ID_HV { get; set; }
        public string Ma_HV { get; set; }
        public string HoTen_HV { get; set; }
        public System.DateTime NgaySinh_HV { get; set; }
        public string DiaChi_HV { get; set; }
        public string Email_HV { get; set; }
        public string SDT_HV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThu> PhieuThus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanHocVien> TaiKhoanHocViens { get; set; }
    }
}
