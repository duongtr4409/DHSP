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
    
    public partial class PhanBienDocLap
    {
        public long Id { get; set; }
        public string HoTen { get; set; }
        public string TrachNhiem { get; set; }
        public string SDT { get; set; }
        public string File { get; set; }
        public string LanGui { get; set; }
        public Nullable<System.DateTime> NgayGui { get; set; }
        public Nullable<System.DateTime> NgaNhan { get; set; }
        public string KetQua { get; set; }
        public string MaNCS { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
