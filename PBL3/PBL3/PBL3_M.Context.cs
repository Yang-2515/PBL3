﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PBL3 : DbContext
    {
        public PBL3()
            : base("name=PBL3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoaDonCT> HoaDonCT { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<KhuyenMaiCT> KhuyenMaiCT { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MatHang> MatHang { get; set; }
        public virtual DbSet<NhaSX> NhaSX { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<PhieuNhapCT> PhieuNhapCT { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
