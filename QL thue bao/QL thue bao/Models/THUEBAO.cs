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
    
    public partial class THUEBAO
    {
        public int IdThueBao { get; set; }
        public Nullable<System.DateTime> NgayDangKi { get; set; }
        public string TenKhachHang { get; set; }
        public string SoCCCD { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public Nullable<float> PhiDangKi { get; set; }
        public string SoThe { get; set; }
        public string Seri { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<float> DungLuong { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<int> IdTraSau { get; set; }
        public string MatKhau { get; set; }
        public string TenLoaiThueBao { get; set; }
    
        public virtual DIENTHOAI DIENTHOAI { get; set; }
        public virtual THETRATRUOC THETRATRUOC { get; set; }
        public virtual TRASAU TRASAU { get; set; }
    }
}
