//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLITHUVIENWINFORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.ChiTietMuons = new HashSet<ChiTietMuon>();
            this.ChiTietYeuCaus = new HashSet<ChiTietYeuCau>();
        }
    
        public int MaSach { get; set; }
        public int MaNXB { get; set; }
        public int MaTheLoai { get; set; }
        public int MaTacGia { get; set; }
        public string TenSach { get; set; }
        public int NamXB { get; set; }
        public int SoLuong { get; set; }
    
        public virtual NXB NXB { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        public virtual TacGia TacGia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietMuon> ChiTietMuons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietYeuCau> ChiTietYeuCaus { get; set; }
    }
}
