//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEMIS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HocPhan_NCS
    {
        public int Id { get; set; }
        public string MaNCS { get; set; }
        public string TenHocPhan { get; set; }
        public Nullable<int> TinChi { get; set; }
        public Nullable<double> Diem { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string MaHocPhan { get; set; }
        public Nullable<bool> TuChon { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public Nullable<double> DiemDieuKien { get; set; }
        public Nullable<double> DiemThi { get; set; }
    }
}
