﻿// <auto-generated />
using System;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagement.Migrations
{
    [DbContext(typeof(HotelContext))]
    partial class HotelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelManagement.Models.DichVu", b =>
                {
                    b.Property<string>("MaDichVu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("GiaDichVu")
                        .HasColumnType("real");

                    b.Property<string>("TenDichVu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaDichVu")
                        .HasName("PK__Dich_Vu__C0E6DE8FC72B2A69");

                    b.ToTable("Dich_Vu", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.HoaDon", b =>
                {
                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MaOrderPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("NgayIn")
                        .HasColumnType("datetime");

                    b.Property<float>("TongTien")
                        .HasColumnType("real");

                    b.HasKey("MaHoaDon")
                        .HasName("PK__Hoa_Don__835ED13B118615AA");

                    b.HasIndex("MaOrderPhong");

                    b.ToTable("Hoa_Don", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.KhachHang", b =>
                {
                    b.Property<string>("KhachHangId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("KhachHang_ID");

                    b.HasKey("KhachHangId");

                    b.ToTable("Khach_Hang", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.LoaiPhong", b =>
                {
                    b.Property<string>("MaLoaiPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("GiaPhong")
                        .HasColumnType("real");

                    b.Property<string>("TenLoaiPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaLoaiPhong")
                        .HasName("PK__Loai_Pho__23021217A48C92C2");

                    b.ToTable("Loai_Phong", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.LoaiTaiKhoan", b =>
                {
                    b.Property<string>("MaLoaiTaiKhoan")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TenLoai")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaLoaiTaiKhoan")
                        .HasName("PK__Loai_Tai__5F6E141C07C4DC2B");

                    b.ToTable("Loai_Tai_Khoan", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.NhanVien", b =>
                {
                    b.Property<string>("NhanVienId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("NhanVienID");

                    b.Property<string>("MaVaiTro")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("NgayDuocTuyen")
                        .HasColumnType("datetime");

                    b.HasKey("NhanVienId");

                    b.HasIndex("MaVaiTro");

                    b.ToTable("Nhan_Vien", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.OrderPhong", b =>
                {
                    b.Property<string>("MaOrderPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MaPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("NgayDen")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayDi")
                        .HasColumnType("datetime");

                    b.Property<string>("PersonId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("PersonID");

                    b.Property<int>("TrangThaiThanhToan")
                        .HasColumnType("int");

                    b.HasKey("MaOrderPhong")
                        .HasName("PK__Order_Ph__829E7C7605A5F40A");

                    b.HasIndex("MaPhong");

                    b.HasIndex("PersonId");

                    b.ToTable("Order_Phong", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.OrderPhongDichVu", b =>
                {
                    b.Property<string>("MaOrderPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MaDichVu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<float?>("DonGia")
                        .HasColumnType("real");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaOrderPhong", "MaDichVu")
                        .HasName("PK__Order_Ph__6E90119E9EC16A77");

                    b.HasIndex("MaDichVu");

                    b.ToTable("Order_Phong_Dich_Vu", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("PersonID");

                    b.Property<string>("Cccd")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("CCCD");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("SDT");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.Phong", b =>
                {
                    b.Property<string>("MaPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MaLoaiPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MaTrangThai")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MoTaPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TenPhong")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaPhong")
                        .HasName("PK__Phong__20BD5E5B177E3D28");

                    b.HasIndex("MaLoaiPhong");

                    b.HasIndex("MaTrangThai");

                    b.ToTable("Phong", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.TaiKhoan", b =>
                {
                    b.Property<string>("MaTaiKhoan")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LoaiTaiKhoan")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PersonId")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("PersonID");

                    b.Property<string>("UserName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaTaiKhoan")
                        .HasName("PK__Tai_Khoa__AD7C6529EF10FB2D");

                    b.HasIndex("LoaiTaiKhoan");

                    b.HasIndex("PersonId");

                    b.ToTable("Tai_Khoan", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.TrangThaiPhong", b =>
                {
                    b.Property<string>("MaTrangThai")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TenTrangThai")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaTrangThai")
                        .HasName("PK__Trang_Th__AADE41383344BB34");

                    b.ToTable("Trang_Thai_Phong", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.VaiTro", b =>
                {
                    b.Property<string>("MaVaiTro")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TenVaiTro")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaVaiTro")
                        .HasName("PK__Vai_Tro__C24C41CFA446BD32");

                    b.ToTable("Vai_Tro", (string)null);
                });

            modelBuilder.Entity("HotelManagement.Models.HoaDon", b =>
                {
                    b.HasOne("HotelManagement.Models.OrderPhong", "MaOrderPhongNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaOrderPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FKHoa_Don624260");

                    b.Navigation("MaOrderPhongNavigation");
                });

            modelBuilder.Entity("HotelManagement.Models.KhachHang", b =>
                {
                    b.HasOne("HotelManagement.Models.Person", "KhachHangNavigation")
                        .WithOne("KhachHang")
                        .HasForeignKey("HotelManagement.Models.KhachHang", "KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKKhach_Hang279424");

                    b.Navigation("KhachHangNavigation");
                });

            modelBuilder.Entity("HotelManagement.Models.NhanVien", b =>
                {
                    b.HasOne("HotelManagement.Models.VaiTro", "MaVaiTroNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("MaVaiTro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FKNhan_Vien799741");

                    b.HasOne("HotelManagement.Models.Person", "NhanVienNavigation")
                        .WithOne("NhanVien")
                        .HasForeignKey("HotelManagement.Models.NhanVien", "NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKNhan_Vien605300");

                    b.Navigation("MaVaiTroNavigation");

                    b.Navigation("NhanVienNavigation");
                });

            modelBuilder.Entity("HotelManagement.Models.OrderPhong", b =>
                {
                    b.HasOne("HotelManagement.Models.Phong", "MaPhongNavigation")
                        .WithMany("OrderPhongs")
                        .HasForeignKey("MaPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FKOrder_Phon460975");

                    b.HasOne("HotelManagement.Models.Person", "Person")
                        .WithMany("OrderPhongs")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FKOrder_Phon746646");

                    b.Navigation("MaPhongNavigation");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HotelManagement.Models.OrderPhongDichVu", b =>
                {
                    b.HasOne("HotelManagement.Models.DichVu", "MaDichVuNavigation")
                        .WithMany("OrderPhongDichVus")
                        .HasForeignKey("MaDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKOrder_Phon597344");

                    b.HasOne("HotelManagement.Models.OrderPhong", "MaOrderPhongNavigation")
                        .WithMany("OrderPhongDichVus")
                        .HasForeignKey("MaOrderPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FKOrder_Phon17642");

                    b.Navigation("MaDichVuNavigation");

                    b.Navigation("MaOrderPhongNavigation");
                });

            modelBuilder.Entity("HotelManagement.Models.Phong", b =>
                {
                    b.HasOne("HotelManagement.Models.LoaiPhong", "MaLoaiPhongNavigation")
                        .WithMany("Phongs")
                        .HasForeignKey("MaLoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FKPhong134689");

                    b.HasOne("HotelManagement.Models.TrangThaiPhong", "MaTrangThaiNavigation")
                        .WithMany("Phongs")
                        .HasForeignKey("MaTrangThai")
                        .HasConstraintName("FKPhong128242");

                    b.Navigation("MaLoaiPhongNavigation");

                    b.Navigation("MaTrangThaiNavigation");
                });

            modelBuilder.Entity("HotelManagement.Models.TaiKhoan", b =>
                {
                    b.HasOne("HotelManagement.Models.LoaiTaiKhoan", "LoaiTaiKhoanNavigation")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("LoaiTaiKhoan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FKTai_Khoan92928");

                    b.HasOne("HotelManagement.Models.Person", "Person")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FKTai_Khoan172310");

                    b.Navigation("LoaiTaiKhoanNavigation");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HotelManagement.Models.DichVu", b =>
                {
                    b.Navigation("OrderPhongDichVus");
                });

            modelBuilder.Entity("HotelManagement.Models.LoaiPhong", b =>
                {
                    b.Navigation("Phongs");
                });

            modelBuilder.Entity("HotelManagement.Models.LoaiTaiKhoan", b =>
                {
                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("HotelManagement.Models.OrderPhong", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("OrderPhongDichVus");
                });

            modelBuilder.Entity("HotelManagement.Models.Person", b =>
                {
                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");

                    b.Navigation("OrderPhongs");

                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("HotelManagement.Models.Phong", b =>
                {
                    b.Navigation("OrderPhongs");
                });

            modelBuilder.Entity("HotelManagement.Models.TrangThaiPhong", b =>
                {
                    b.Navigation("Phongs");
                });

            modelBuilder.Entity("HotelManagement.Models.VaiTro", b =>
                {
                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
