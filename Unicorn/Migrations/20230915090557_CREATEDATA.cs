using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unicorn.Migrations
{
    /// <inheritdoc />
    public partial class CREATEDATA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CV",
                columns: table => new
                {
                    ID_CV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ghi_chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CV", x => x.ID_CV);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DVT",
                columns: table => new
                {
                    ID_DVT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ghi_chú = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DVT", x => x.ID_DVT);
                });

            migrationBuilder.CreateTable(
                name: "tbl_KH",
                columns: table => new
                {
                    ID_KH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dia_chi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ghi_chu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_NCC = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_KH", x => x.ID_KH);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Loai",
                columns: table => new
                {
                    ID_Loai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ghi_chú = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Loai", x => x.ID_Loai);
                });

            migrationBuilder.CreateTable(
                name: "tbl_NCC",
                columns: table => new
                {
                    ID_NCC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dia_chi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ghi_chu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_KH = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_NCC", x => x.ID_NCC);
                });

            migrationBuilder.CreateTable(
                name: "tbl_To",
                columns: table => new
                {
                    ID_To = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ghi_chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_To", x => x.ID_To);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_BTP",
                columns: table => new
                {
                    ID_BTP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mo_ta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SL_ton = table.Column<int>(type: "int", nullable: true),
                    Nguon_goc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DG_mua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DG_ban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_DVT = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ID_Loai = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BTP", x => x.ID_BTP);
                    table.ForeignKey(
                        name: "FK_tbl_BTP_tbl_DVT_ID_DVT",
                        column: x => x.ID_DVT,
                        principalTable: "tbl_DVT",
                        principalColumn: "ID_DVT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_BTP_tbl_Loai_ID_Loai",
                        column: x => x.ID_Loai,
                        principalTable: "tbl_Loai",
                        principalColumn: "ID_Loai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_NVL",
                columns: table => new
                {
                    ID_NVL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mo_ta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SL_ton = table.Column<int>(type: "int", nullable: true),
                    Nguon_goc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DG_mua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DG_ban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_DVT = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ID_Loai = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_NVL", x => x.ID_NVL);
                    table.ForeignKey(
                        name: "FK_tbl_NVL_tbl_DVT_ID_DVT",
                        column: x => x.ID_DVT,
                        principalTable: "tbl_DVT",
                        principalColumn: "ID_DVT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_NVL_tbl_Loai_ID_Loai",
                        column: x => x.ID_Loai,
                        principalTable: "tbl_Loai",
                        principalColumn: "ID_Loai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TP",
                columns: table => new
                {
                    ID_TP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mo_ta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SL_ton = table.Column<int>(type: "int", nullable: true),
                    Nguon_goc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DG_ban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_DVT = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ID_Loai = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TP", x => x.ID_TP);
                    table.ForeignKey(
                        name: "FK_tbl_TP_tbl_DVT_ID_DVT",
                        column: x => x.ID_DVT,
                        principalTable: "tbl_DVT",
                        principalColumn: "ID_DVT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_TP_tbl_Loai_ID_Loai",
                        column: x => x.ID_Loai,
                        principalTable: "tbl_Loai",
                        principalColumn: "ID_Loai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl.NV",
                columns: table => new
                {
                    ID_NV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nam_sinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gioi_tinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Que_quan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<int>(type: "int", nullable: true),
                    CMT = table.Column<int>(type: "int", nullable: true),
                    Ngay_vao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngay_tao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_To = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ID_CV = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl.NV", x => x.ID_NV);
                    table.ForeignKey(
                        name: "FK_tbl.NV_tbl_CV_ID_CV",
                        column: x => x.ID_CV,
                        principalTable: "tbl_CV",
                        principalColumn: "ID_CV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl.NV_tbl_To_ID_To",
                        column: x => x.ID_To,
                        principalTable: "tbl_To",
                        principalColumn: "ID_To",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DMNVL",
                columns: table => new
                {
                    ID_DMNVL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID_NVL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SL = table.Column<int>(type: "int", nullable: false),
                    Ghi_chu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_TP = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ID_BTP = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DMNVL", x => x.ID_DMNVL);
                    table.ForeignKey(
                        name: "FK_tbl_DMNVL_tbl_BTP_ID_BTP",
                        column: x => x.ID_BTP,
                        principalTable: "tbl_BTP",
                        principalColumn: "ID_BTP");
                    table.ForeignKey(
                        name: "FK_tbl_DMNVL_tbl_TP_ID_TP",
                        column: x => x.ID_TP,
                        principalTable: "tbl_TP",
                        principalColumn: "ID_TP");
                });

            migrationBuilder.CreateTable(
                name: "tbl_DVCD",
                columns: table => new
                {
                    ID_DVCD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID_NVL = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Ty_le = table.Column<int>(type: "int", nullable: false),
                    Phep_tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dien_giai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BTPID_BTP = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    TPID_TP = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DVCD", x => x.ID_DVCD);
                    table.ForeignKey(
                        name: "FK_tbl_DVCD_tbl_BTP_BTPID_BTP",
                        column: x => x.BTPID_BTP,
                        principalTable: "tbl_BTP",
                        principalColumn: "ID_BTP");
                    table.ForeignKey(
                        name: "FK_tbl_DVCD_tbl_NVL_ID_NVL",
                        column: x => x.ID_NVL,
                        principalTable: "tbl_NVL",
                        principalColumn: "ID_NVL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_DVCD_tbl_TP_TPID_TP",
                        column: x => x.TPID_TP,
                        principalTable: "tbl_TP",
                        principalColumn: "ID_TP");
                });

            migrationBuilder.CreateTable(
                name: "tbl_MQC",
                columns: table => new
                {
                    ID_MQC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID_NVL = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    Thoi_gian = table.Column<int>(type: "int", nullable: false),
                    SL_Ton = table.Column<int>(type: "int", nullable: false),
                    Gia_Ton = table.Column<double>(type: "float", nullable: false),
                    Giatri_Ton = table.Column<double>(type: "float", nullable: false),
                    BTPID_BTP = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    TPID_TP = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MQC", x => x.ID_MQC);
                    table.ForeignKey(
                        name: "FK_tbl_MQC_tbl_BTP_BTPID_BTP",
                        column: x => x.BTPID_BTP,
                        principalTable: "tbl_BTP",
                        principalColumn: "ID_BTP");
                    table.ForeignKey(
                        name: "FK_tbl_MQC_tbl_NVL_ID_NVL",
                        column: x => x.ID_NVL,
                        principalTable: "tbl_NVL",
                        principalColumn: "ID_NVL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_MQC_tbl_TP_TPID_TP",
                        column: x => x.TPID_TP,
                        principalTable: "tbl_TP",
                        principalColumn: "ID_TP");
                });

            migrationBuilder.CreateTable(
                name: "tbl_User",
                columns: table => new
                {
                    ID_User = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TK = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MK = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID_NV = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_User", x => x.ID_User);
                    table.ForeignKey(
                        name: "FK_tbl_User_tbl.NV_ID_NV",
                        column: x => x.ID_NV,
                        principalTable: "tbl.NV",
                        principalColumn: "ID_NV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BTP_ID_DVT",
                table: "tbl_BTP",
                column: "ID_DVT");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_BTP_ID_Loai",
                table: "tbl_BTP",
                column: "ID_Loai");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DMNVL_ID_BTP",
                table: "tbl_DMNVL",
                column: "ID_BTP");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DMNVL_ID_TP",
                table: "tbl_DMNVL",
                column: "ID_TP");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DVCD_BTPID_BTP",
                table: "tbl_DVCD",
                column: "BTPID_BTP");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DVCD_ID_NVL",
                table: "tbl_DVCD",
                column: "ID_NVL");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_DVCD_TPID_TP",
                table: "tbl_DVCD",
                column: "TPID_TP");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MQC_BTPID_BTP",
                table: "tbl_MQC",
                column: "BTPID_BTP");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MQC_ID_NVL",
                table: "tbl_MQC",
                column: "ID_NVL");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_MQC_TPID_TP",
                table: "tbl_MQC",
                column: "TPID_TP");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_NVL_ID_DVT",
                table: "tbl_NVL",
                column: "ID_DVT");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_NVL_ID_Loai",
                table: "tbl_NVL",
                column: "ID_Loai");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TP_ID_DVT",
                table: "tbl_TP",
                column: "ID_DVT");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TP_ID_Loai",
                table: "tbl_TP",
                column: "ID_Loai");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_User_ID_NV",
                table: "tbl_User",
                column: "ID_NV");

            migrationBuilder.CreateIndex(
                name: "IX_tbl.NV_ID_CV",
                table: "tbl.NV",
                column: "ID_CV");

            migrationBuilder.CreateIndex(
                name: "IX_tbl.NV_ID_To",
                table: "tbl.NV",
                column: "ID_To");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tbl_DMNVL");

            migrationBuilder.DropTable(
                name: "tbl_DVCD");

            migrationBuilder.DropTable(
                name: "tbl_KH");

            migrationBuilder.DropTable(
                name: "tbl_MQC");

            migrationBuilder.DropTable(
                name: "tbl_NCC");

            migrationBuilder.DropTable(
                name: "tbl_User");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "tbl_BTP");

            migrationBuilder.DropTable(
                name: "tbl_NVL");

            migrationBuilder.DropTable(
                name: "tbl_TP");

            migrationBuilder.DropTable(
                name: "tbl.NV");

            migrationBuilder.DropTable(
                name: "tbl_DVT");

            migrationBuilder.DropTable(
                name: "tbl_Loai");

            migrationBuilder.DropTable(
                name: "tbl_CV");

            migrationBuilder.DropTable(
                name: "tbl_To");
        }
    }
}
