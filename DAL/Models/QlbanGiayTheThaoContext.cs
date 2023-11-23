using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class QlbanGiayTheThaoContext : DbContext
{
    public QlbanGiayTheThaoContext()
    {
    }

    public QlbanGiayTheThaoContext(DbContextOptions<QlbanGiayTheThaoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CaLamViec> CaLamViecs { get; set; }

    public virtual DbSet<ChatLieu> ChatLieus { get; set; }

    public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<Doi> Dois { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<MauSac> MauSacs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Rank> Ranks { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Thongke> Thongkes { get; set; }

    public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }

    public virtual DbSet<Tra> Tras { get; set; }

    public virtual DbSet<VouCher> VouChers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=VANNTRONGG\\SQLEXPRESS;Initial Catalog=QLBanGiayTheThao;TrustServerCertificate=true;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaLamViec>(entity =>
        {
            entity.HasKey(e => e.MaCa).HasName("PK__CaLamVie__27258E7B8B603A70");

            entity.ToTable("CaLamViec");

            entity.Property(e => e.MaCa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            entity.Property(e => e.TrangThai).HasMaxLength(30);
        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {
            entity.HasKey(e => e.MaChatLieu).HasName("PK__ChatLieu__453995BC350D00EB");

            entity.ToTable("ChatLieu");

            entity.Property(e => e.MaChatLieu)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LoaiChatLieu).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasMaxLength(30);
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.Maspct).HasName("PK__ChiTietS__3D158D869E7D634A");

            entity.ToTable("ChiTietSanPham");

            entity.Property(e => e.Maspct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASPCT");
            entity.Property(e => e.MaChatLieu)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaMau)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaSize)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSP");
            entity.Property(e => e.MaTh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaTH");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.MaChatLieu)
                .HasConstraintName("FK__ChiTietSa__MaCha__60A75C0F");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.MaMau)
                .HasConstraintName("FK__ChiTietSa__MaMau__5EBF139D");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.MaSize)
                .HasConstraintName("FK__ChiTietSa__MaSiz__5FB337D6");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.MaSp)
                .HasConstraintName("FK__ChiTietSan__MaSP__5DCAEF64");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.MaTh)
                .HasConstraintName("FK__ChiTietSan__MaTH__619B8048");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E5670B363AB");

            entity.ToTable("ChucVu");

            entity.Property(e => e.MaCv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TenChucVu).HasMaxLength(50);
        });

        modelBuilder.Entity<Doi>(entity =>
        {
            entity.HasKey(e => e.MaDoi).HasName("PK__Doi__3D89F553476B7BAE");

            entity.ToTable("Doi");

            entity.Property(e => e.MaDoi)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DoiSangSp).HasMaxLength(100);
            entity.Property(e => e.LyDo).HasMaxLength(250);
            entity.Property(e => e.MaHdct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHDCT");
            entity.Property(e => e.NgayDoi).HasColumnType("date");
            entity.Property(e => e.TrangThai).HasMaxLength(10);

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Dois)
                .HasForeignKey(d => d.MaHdct)
                .HasConstraintName("FK__Doi__MaHDCT__00200768");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E05B3E8566");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaNV");
            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaVoucher)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayTao).HasColumnType("date");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__HoaDon__MaKh__7A672E12");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__HoaDon__MaNV__797309D9");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaSp)
                .HasConstraintName("FK__HoaDon__MaSp__778AC167");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaVoucher)
                .HasConstraintName("FK__HoaDon__MaVouche__787EE5A0");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHdct).HasName("PK__HoaDonCh__1419C1297177018A");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.MaHdct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHDCT");
            entity.Property(e => e.GhiChu).HasMaxLength(250);
            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHD");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaHd)
                .HasConstraintName("FK__HoaDonChiT__MaHD__7D439ABD");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF7E5C743C52");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh).HasMaxLength(250);
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.MaMau).HasName("PK__MauSac__3A5BBB7DE40A566D");

            entity.ToTable("MauSac");

            entity.Property(e => e.MaMau)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TenMau).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasMaxLength(30);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D76A68E23587");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaCa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaChucVu)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau).HasMaxLength(30);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TenNhanVien).HasMaxLength(50);

            entity.HasOne(d => d.MaCaNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaCa)
                .HasConstraintName("FK__NhanVien__MaCa__5165187F");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaChucVu)
                .HasConstraintName("FK__NhanVien__MaChuc__5070F446");
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity.HasKey(e => e.RankId).HasName("PK__RANKS__B37AFB96BAE93221");

            entity.ToTable("RANKS");

            entity.Property(e => e.RankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RankID");
            entity.Property(e => e.DieuKien).HasMaxLength(100);
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(250);
            entity.Property(e => e.MucUuDai)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai).HasMaxLength(30);

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Ranks)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__RANKS__MaKh__74AE54BC");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C40BBA149");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaSP");
            entity.Property(e => e.NgayNhap).HasColumnType("date");
            entity.Property(e => e.TenSanPham).HasMaxLength(250);
            entity.Property(e => e.TrangThai).HasMaxLength(30);
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.MaSize).HasName("PK__Size__A787E7EDF2B9CB5D");

            entity.ToTable("Size");

            entity.Property(e => e.MaSize)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KichThuoc).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasMaxLength(30);
        });

        modelBuilder.Entity<Thongke>(entity =>
        {
            entity.HasKey(e => e.MaThongKe).HasName("PK__THONGKE__60E521F43AC0EB44");

            entity.ToTable("THONGKE");

            entity.Property(e => e.MaThongKe)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayThongKe).HasColumnType("date");
            entity.Property(e => e.TongDoanhThu).HasMaxLength(40);

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Thongkes)
                .HasForeignKey(d => d.MaHd)
                .HasConstraintName("FK__THONGKE__MaHD__2A164134");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Thongkes)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__THONGKE__MaNv__2B0A656D");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.MaTh).HasName("PK__ThuongHi__272500750B2593A1");

            entity.ToTable("ThuongHieu");

            entity.Property(e => e.MaTh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaTH");
            entity.Property(e => e.TenThuongHieu).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasMaxLength(30);
        });

        modelBuilder.Entity<Tra>(entity =>
        {
            entity.HasKey(e => e.MaTra).HasName("PK__Tra__31493C67E7504149");

            entity.ToTable("Tra");

            entity.Property(e => e.MaTra)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LyDo).HasMaxLength(250);
            entity.Property(e => e.MaHdct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaHDCT");
            entity.Property(e => e.NgayDoi).HasColumnType("date");
            entity.Property(e => e.TrangThai).HasMaxLength(10);

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Tras)
                .HasForeignKey(d => d.MaHdct)
                .HasConstraintName("FK__Tra__MaHDCT__02FC7413");
        });

        modelBuilder.Entity<VouCher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__VouCher__0AAC5B1116781A70");

            entity.ToTable("VouCher");

            entity.Property(e => e.MaVoucher)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(250);
            entity.Property(e => e.NgayBatDau).HasColumnType("date");
            entity.Property(e => e.NgayKetThuc).HasColumnType("date");
            entity.Property(e => e.TenVoucher).HasMaxLength(50);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
