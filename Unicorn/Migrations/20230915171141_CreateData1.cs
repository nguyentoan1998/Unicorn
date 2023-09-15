using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unicorn.Migrations
{
    /// <inheritdoc />
    public partial class CreateData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl.NV_tbl_CV_ID_CV",
                table: "tbl.NV");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl.NV_tbl_To_ID_To",
                table: "tbl.NV");

            migrationBuilder.DropIndex(
                name: "IX_tbl.NV_ID_CV",
                table: "tbl.NV");

            migrationBuilder.DropIndex(
                name: "IX_tbl.NV_ID_To",
                table: "tbl.NV");

            migrationBuilder.AlterColumn<string>(
                name: "ID_To",
                table: "tbl.NV",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "ID_CV",
                table: "tbl.NV",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AddColumn<string>(
                name: "CVsID_CV",
                table: "tbl.NV",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TosID_To",
                table: "tbl.NV",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl.NV_CVsID_CV",
                table: "tbl.NV",
                column: "CVsID_CV");

            migrationBuilder.CreateIndex(
                name: "IX_tbl.NV_TosID_To",
                table: "tbl.NV",
                column: "TosID_To");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl.NV_tbl_CV_CVsID_CV",
                table: "tbl.NV",
                column: "CVsID_CV",
                principalTable: "tbl_CV",
                principalColumn: "ID_CV");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl.NV_tbl_To_TosID_To",
                table: "tbl.NV",
                column: "TosID_To",
                principalTable: "tbl_To",
                principalColumn: "ID_To");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl.NV_tbl_CV_CVsID_CV",
                table: "tbl.NV");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl.NV_tbl_To_TosID_To",
                table: "tbl.NV");

            migrationBuilder.DropIndex(
                name: "IX_tbl.NV_CVsID_CV",
                table: "tbl.NV");

            migrationBuilder.DropIndex(
                name: "IX_tbl.NV_TosID_To",
                table: "tbl.NV");

            migrationBuilder.DropColumn(
                name: "CVsID_CV",
                table: "tbl.NV");

            migrationBuilder.DropColumn(
                name: "TosID_To",
                table: "tbl.NV");

            migrationBuilder.AlterColumn<string>(
                name: "ID_To",
                table: "tbl.NV",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ID_CV",
                table: "tbl.NV",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_tbl.NV_ID_CV",
                table: "tbl.NV",
                column: "ID_CV");

            migrationBuilder.CreateIndex(
                name: "IX_tbl.NV_ID_To",
                table: "tbl.NV",
                column: "ID_To");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl.NV_tbl_CV_ID_CV",
                table: "tbl.NV",
                column: "ID_CV",
                principalTable: "tbl_CV",
                principalColumn: "ID_CV",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl.NV_tbl_To_ID_To",
                table: "tbl.NV",
                column: "ID_To",
                principalTable: "tbl_To",
                principalColumn: "ID_To",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
