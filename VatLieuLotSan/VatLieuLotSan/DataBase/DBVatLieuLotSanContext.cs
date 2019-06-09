namespace VatLieuLotSan.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBVatLieuLotSanContext : DbContext
    {
        public DBVatLieuLotSanContext()
            : base("name=DBVatLieuLotSanContext")
        {
        }

        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<CT_PHIEUDAT> CT_PHIEUDAT { get; set; }
        public virtual DbSet<CT_PHIEUNHAP> CT_PHIEUNHAP { get; set; }
        public virtual DbSet<CTKHUYENMAI> CTKHUYENMAIs { get; set; }
        public virtual DbSet<CTPHIEUGIAO> CTPHIEUGIAOs { get; set; }
        public virtual DbSet<FOOTER> FOOTERs { get; set; }
        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<LienHe> LienHes { get; set; }
        public virtual DbSet<LOAIHANG> LOAIHANGs { get; set; }
        public virtual DbSet<MANHINH> MANHINHs { get; set; }
        public virtual DbSet<MAUSAC> MAUSACs { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHOMQUYEN> NHOMQUYENs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<PHIEUDAT> PHIEUDATs { get; set; }
        public virtual DbSet<PHIEUGIAO> PHIEUGIAOs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<QUYCACH> QUYCACHes { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MAHD)
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MAHANG)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUDAT>()
                .Property(e => e.MAPHIEUDAT)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUDAT>()
                .Property(e => e.MAHANG)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUDAT>()
                .Property(e => e.MAMAU)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUNHAP>()
                .Property(e => e.MAPHIEUNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUNHAP>()
                .Property(e => e.MAHANG)
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUNHAP>()
                .Property(e => e.MAMAU)
                .IsUnicode(false);

            modelBuilder.Entity<CTKHUYENMAI>()
                .Property(e => e.MAKM)
                .IsUnicode(false);

            modelBuilder.Entity<CTKHUYENMAI>()
                .Property(e => e.MAHANG)
                .IsUnicode(false);

            modelBuilder.Entity<CTKHUYENMAI>()
                .Property(e => e.MAMAU)
                .IsUnicode(false);

            modelBuilder.Entity<CTKHUYENMAI>()
                .Property(e => e.SANPHAMTANG)
                .IsFixedLength();

            modelBuilder.Entity<CTPHIEUGIAO>()
                .Property(e => e.MAPHIEUGIAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTPHIEUGIAO>()
                .Property(e => e.MAHANG)
                .IsUnicode(false);

            modelBuilder.Entity<CTPHIEUGIAO>()
                .Property(e => e.MAMAU)
                .IsUnicode(false);

            modelBuilder.Entity<FOOTER>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.MAHANG)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .Property(e => e.MAU)
                .IsUnicode(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CT_PHIEUDAT)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CT_PHIEUNHAP)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CTKHUYENMAIs)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHOA>()
                .HasMany(e => e.CTPHIEUGIAOs)
                .WithRequired(e => e.HANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HANGHOA>()
                .HasOptional(e => e.QUYCACH)
                .WithRequired(e => e.HANGHOA);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAKHACHHANG)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.SODIENTHOAI)
                .IsFixedLength();

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKHACHHANG)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.LOAIKHACH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SODIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.TENDANGNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<KHUYENMAI>()
                .Property(e => e.MAKM)
                .IsUnicode(false);

            modelBuilder.Entity<KHUYENMAI>()
                .HasMany(e => e.CTKHUYENMAIs)
                .WithRequired(e => e.KHUYENMAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIHANG>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<MANHINH>()
                .Property(e => e.MAMH)
                .IsUnicode(false);

            modelBuilder.Entity<MANHINH>()
                .HasMany(e => e.PHANQUYENs)
                .WithRequired(e => e.MANHINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAUSAC>()
                .Property(e => e.MAMAU)
                .IsUnicode(false);

            modelBuilder.Entity<MAUSAC>()
                .HasMany(e => e.HANGHOAs)
                .WithOptional(e => e.MAUSAC)
                .HasForeignKey(e => e.MAU);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.TENDANGNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.NHOMQUYENs)
                .WithMany(e => e.NGUOIDUNGs)
                .Map(m => m.ToTable("CHITIETNHOMQUYEN").MapLeftKey("TENDANGNHAP").MapRightKey("MANHOM"));

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SODIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SODIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<NHOMQUYEN>()
                .Property(e => e.MANHOM)
                .IsUnicode(false);

            modelBuilder.Entity<NHOMQUYEN>()
                .HasMany(e => e.PHANQUYENs)
                .WithRequired(e => e.NHOMQUYEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHANQUYEN>()
                .Property(e => e.MAMH)
                .IsUnicode(false);

            modelBuilder.Entity<PHANQUYEN>()
                .Property(e => e.TINIHTRANG)
                .IsFixedLength();

            modelBuilder.Entity<PHANQUYEN>()
                .Property(e => e.MANHOM)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDAT>()
                .Property(e => e.MAPHIEUDAT)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDAT>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDAT>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDAT>()
                .HasMany(e => e.CT_PHIEUDAT)
                .WithRequired(e => e.PHIEUDAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUGIAO>()
                .Property(e => e.MAPHIEUGIAO)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGIAO>()
                .Property(e => e.MAHD)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGIAO>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGIAO>()
                .Property(e => e.SDTNV)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUGIAO>()
                .Property(e => e.SDTKH)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGIAO>()
                .HasMany(e => e.CTPHIEUGIAOs)
                .WithRequired(e => e.PHIEUGIAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MAPHIEUNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MAPHIEUDAT)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<QUYCACH>()
                .Property(e => e.MAHH)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.SUABOI)
                .IsUnicode(false);
        }
    }
}
