using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unicorn.Migrations
{
    /// <inheritdoc />
    public partial class CreateData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DMNVL",
                columns: table => new
                {
                    ID_DMNVL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID_NVL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SL = table.Column<int>(type: "int", nullable: false),
                    Ghi_chu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DMNVL", x => x.ID_DMNVL);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DVCD",
                columns: table => new
                {
                    ID_DVCD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID_DVT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ty_le = table.Column<int>(type: "int", nullable: false),
                    Phep_tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dien_giai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DVCD", x => x.ID_DVCD);
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
                name: "tbl_MQC",
                columns: table => new
                {
                    ID_MQC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ID_NVL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    Thoi_gian = table.Column<int>(type: "int", nullable: false),
                    SL_Ton = table.Column<int>(type: "int", nullable: false),
                    Gia_Ton = table.Column<double>(type: "float", nullable: false),
                    Giatri_Ton = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MQC", x => x.ID_MQC);
                });

            migrationBuilder.CreateTable(
                name: "tbl_NVL",
                columns: table => new
                {
                    ID_NVL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID_DVT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mo_ta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SL_ton = table.Column<int>(type: "int", nullable: false),
                    Nguon_goc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DG_mua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DG_ban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Loai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_NVL", x => x.ID_NVL);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DMNVL");

            migrationBuilder.DropTable(
                name: "tbl_DVCD");

            migrationBuilder.DropTable(
                name: "tbl_DVT");

            migrationBuilder.DropTable(
                name: "tbl_Loai");

            migrationBuilder.DropTable(
                name: "tbl_MQC");

            migrationBuilder.DropTable(
                name: "tbl_NVL");
        }
    }
}
