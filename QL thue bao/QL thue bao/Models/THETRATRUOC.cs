//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_thue_bao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THETRATRUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THETRATRUOC()
        {
            this.THUEBAOs = new HashSet<THUEBAO>();
        }
    
        public string Seri { get; set; }
        public string SoThe { get; set; }
        public Nullable<float> GiaTien { get; set; }
        public Nullable<float> DungLuong { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public string TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUEBAO> THUEBAOs { get; set; }
    }
}
