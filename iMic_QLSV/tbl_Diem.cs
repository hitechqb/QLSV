//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iMic_QLSV
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Diem
    {
        public string MSSV { get; set; }
        public string MaMH { get; set; }
        public Nullable<double> Diem { get; set; }
    
        public virtual tbl_DMMonHoc tbl_DMMonHoc { get; set; }
        public virtual tbl_SinhVien tbl_SinhVien { get; set; }
    }
}