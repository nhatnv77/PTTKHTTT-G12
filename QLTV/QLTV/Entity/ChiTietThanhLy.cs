//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietThanhLy
    {
        public int MaSach { get; set; }
        public string MaNhaThanhLy { get; set; }
        public System.DateTime NgayThanhLy { get; set; }
    
        public virtual DoiTac DoiTac { get; set; }
        public virtual Sach Sach { get; set; }
    }
}