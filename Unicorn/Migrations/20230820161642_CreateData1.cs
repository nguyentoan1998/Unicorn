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
            migrationBuilder.AddColumn<string>(
                name: "Name_CV",
                table: "tbl.NV",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_To",
                table: "tbl.NV",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name_CV",
                table: "tbl.NV");

            migrationBuilder.DropColumn(
                name: "Name_To",
                table: "tbl.NV");
        }
    }
}
