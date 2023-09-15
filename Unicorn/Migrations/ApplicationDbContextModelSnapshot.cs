﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unicorn.Data;

#nullable disable

namespace Unicorn.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Unicorn.Models.BTP", b =>
                {
                    b.Property<string>("ID_BTP")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DG_ban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DG_mua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_DVT")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ID_Loai")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mo_ta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nguon_goc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SL_ton")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_BTP");

                    b.HasIndex("ID_DVT");

                    b.HasIndex("ID_Loai");

                    b.ToTable("tbl_BTP");
                });

            modelBuilder.Entity("Unicorn.Models.CV", b =>
                {
                    b.Property<string>("ID_CV")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ghi_chu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_CV");

                    b.ToTable("tbl_CV");
                });

            modelBuilder.Entity("Unicorn.Models.DMNVL", b =>
                {
                    b.Property<string>("ID_DMNVL")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ghi_chu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_BTP")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ID_NVL")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ID_TP")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("SL")
                        .HasColumnType("int");

                    b.HasKey("ID_DMNVL");

                    b.HasIndex("ID_BTP");

                    b.HasIndex("ID_TP");

                    b.ToTable("tbl_DMNVL");
                });

            modelBuilder.Entity("Unicorn.Models.DVCD", b =>
                {
                    b.Property<string>("ID_DVCD")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BTPID_BTP")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Dien_giai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_NVL")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phep_tinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TPID_TP")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Ty_le")
                        .HasColumnType("int");

                    b.HasKey("ID_DVCD");

                    b.HasIndex("BTPID_BTP");

                    b.HasIndex("ID_NVL");

                    b.HasIndex("TPID_TP");

                    b.ToTable("tbl_DVCD");
                });

            modelBuilder.Entity("Unicorn.Models.DVT", b =>
                {
                    b.Property<string>("ID_DVT")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ghi_chú")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_DVT");

                    b.ToTable("tbl_DVT");
                });

            modelBuilder.Entity("Unicorn.Models.KH", b =>
                {
                    b.Property<string>("ID_KH")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Dia_chi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ghi_chu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Is_NCC")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_KH");

                    b.ToTable("tbl_KH");
                });

            modelBuilder.Entity("Unicorn.Models.Loai", b =>
                {
                    b.Property<string>("ID_Loai")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ghi_chú")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_Loai");

                    b.ToTable("tbl_Loai");
                });

            modelBuilder.Entity("Unicorn.Models.MQC", b =>
                {
                    b.Property<string>("ID_MQC")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BTPID_BTP")
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<double>("Gia_Ton")
                        .HasColumnType("float");

                    b.Property<double>("Giatri_Ton")
                        .HasColumnType("float");

                    b.Property<string>("ID_NVL")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SL_Ton")
                        .HasColumnType("int");

                    b.Property<string>("TPID_TP")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Thoi_gian")
                        .HasColumnType("int");

                    b.HasKey("ID_MQC");

                    b.HasIndex("BTPID_BTP");

                    b.HasIndex("ID_NVL");

                    b.HasIndex("TPID_TP");

                    b.ToTable("tbl_MQC");
                });

            modelBuilder.Entity("Unicorn.Models.NCC", b =>
                {
                    b.Property<string>("ID_NCC")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Dia_chi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ghi_chu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Is_KH")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_NCC");

                    b.ToTable("tbl_NCC");
                });

            modelBuilder.Entity("Unicorn.Models.NV", b =>
                {
                    b.Property<string>("ID_NV")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("CMT")
                        .HasColumnType("int");

                    b.Property<string>("CVsID_CV")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Gioi_tinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nam_sinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Ngay_tao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngay_vao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Que_quan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SDT")
                        .HasColumnType("int");

                    b.Property<string>("TosID_To")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID_NV");

                    b.HasIndex("CVsID_CV");

                    b.HasIndex("TosID_To");

                    b.ToTable("tbl.NV");
                });

            modelBuilder.Entity("Unicorn.Models.NVL", b =>
                {
                    b.Property<string>("ID_NVL")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DG_ban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DG_mua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_DVT")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ID_Loai")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mo_ta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nguon_goc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SL_ton")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_NVL");

                    b.HasIndex("ID_DVT");

                    b.HasIndex("ID_Loai");

                    b.ToTable("tbl_NVL");
                });

            modelBuilder.Entity("Unicorn.Models.TP", b =>
                {
                    b.Property<string>("ID_TP")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DG_ban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_DVT")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ID_Loai")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mo_ta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nguon_goc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SL_ton")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_TP");

                    b.HasIndex("ID_DVT");

                    b.HasIndex("ID_Loai");

                    b.ToTable("tbl_TP");
                });

            modelBuilder.Entity("Unicorn.Models.To", b =>
                {
                    b.Property<string>("ID_To")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ghi_chu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_To");

                    b.ToTable("tbl_To");
                });

            modelBuilder.Entity("Unicorn.Models.User", b =>
                {
                    b.Property<string>("ID_User")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ID_NV")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MK")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TK")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_User");

                    b.HasIndex("ID_NV");

                    b.ToTable("tbl_User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Unicorn.Models.BTP", b =>
                {
                    b.HasOne("Unicorn.Models.DVT", "DVT")
                        .WithMany()
                        .HasForeignKey("ID_DVT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unicorn.Models.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("ID_Loai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVT");

                    b.Navigation("Loai");
                });

            modelBuilder.Entity("Unicorn.Models.DMNVL", b =>
                {
                    b.HasOne("Unicorn.Models.BTP", "BTP")
                        .WithMany("DMNVL")
                        .HasForeignKey("ID_BTP");

                    b.HasOne("Unicorn.Models.TP", "TP")
                        .WithMany("DMNVL")
                        .HasForeignKey("ID_TP");

                    b.Navigation("BTP");

                    b.Navigation("TP");
                });

            modelBuilder.Entity("Unicorn.Models.DVCD", b =>
                {
                    b.HasOne("Unicorn.Models.BTP", null)
                        .WithMany("DVCD")
                        .HasForeignKey("BTPID_BTP");

                    b.HasOne("Unicorn.Models.NVL", "NVL")
                        .WithMany("DVCD")
                        .HasForeignKey("ID_NVL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unicorn.Models.TP", null)
                        .WithMany("DVCD")
                        .HasForeignKey("TPID_TP");

                    b.Navigation("NVL");
                });

            modelBuilder.Entity("Unicorn.Models.MQC", b =>
                {
                    b.HasOne("Unicorn.Models.BTP", null)
                        .WithMany("MQC")
                        .HasForeignKey("BTPID_BTP");

                    b.HasOne("Unicorn.Models.NVL", "NVL")
                        .WithMany("MQC")
                        .HasForeignKey("ID_NVL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unicorn.Models.TP", null)
                        .WithMany("MQC")
                        .HasForeignKey("TPID_TP");

                    b.Navigation("NVL");
                });

            modelBuilder.Entity("Unicorn.Models.NV", b =>
                {
                    b.HasOne("Unicorn.Models.CV", "CVs")
                        .WithMany()
                        .HasForeignKey("CVsID_CV");

                    b.HasOne("Unicorn.Models.To", "Tos")
                        .WithMany()
                        .HasForeignKey("TosID_To");

                    b.Navigation("CVs");

                    b.Navigation("Tos");
                });

            modelBuilder.Entity("Unicorn.Models.NVL", b =>
                {
                    b.HasOne("Unicorn.Models.DVT", "DVT")
                        .WithMany()
                        .HasForeignKey("ID_DVT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unicorn.Models.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("ID_Loai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVT");

                    b.Navigation("Loai");
                });

            modelBuilder.Entity("Unicorn.Models.TP", b =>
                {
                    b.HasOne("Unicorn.Models.DVT", "DVT")
                        .WithMany()
                        .HasForeignKey("ID_DVT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unicorn.Models.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("ID_Loai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DVT");

                    b.Navigation("Loai");
                });

            modelBuilder.Entity("Unicorn.Models.User", b =>
                {
                    b.HasOne("Unicorn.Models.NV", "NV")
                        .WithMany()
                        .HasForeignKey("ID_NV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NV");
                });

            modelBuilder.Entity("Unicorn.Models.BTP", b =>
                {
                    b.Navigation("DMNVL");

                    b.Navigation("DVCD");

                    b.Navigation("MQC");
                });

            modelBuilder.Entity("Unicorn.Models.NVL", b =>
                {
                    b.Navigation("DVCD");

                    b.Navigation("MQC");
                });

            modelBuilder.Entity("Unicorn.Models.TP", b =>
                {
                    b.Navigation("DMNVL");

                    b.Navigation("DVCD");

                    b.Navigation("MQC");
                });
#pragma warning restore 612, 618
        }
    }
}
