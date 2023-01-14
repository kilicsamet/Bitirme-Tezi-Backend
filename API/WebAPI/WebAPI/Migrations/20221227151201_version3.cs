using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AraclarYıl",
                table: "araclars",
                newName: "AraclarYil");

            migrationBuilder.RenameColumn(
                name: "AraclarYakıt",
                table: "araclars",
                newName: "AraclarYakit");

            migrationBuilder.RenameColumn(
                name: "AraclarHız",
                table: "araclars",
                newName: "AraclarHiz");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AraclarYil",
                table: "araclars",
                newName: "AraclarYıl");

            migrationBuilder.RenameColumn(
                name: "AraclarYakit",
                table: "araclars",
                newName: "AraclarYakıt");

            migrationBuilder.RenameColumn(
                name: "AraclarHiz",
                table: "araclars",
                newName: "AraclarHız");
        }
    }
}
