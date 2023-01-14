using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class veryfinalmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UrunlerUzunAciklama",
                table: "urunlers",
                newName: "PanelMetrekare");

            migrationBuilder.RenameColumn(
                name: "UrunlerKisaAciklama",
                table: "urunlers",
                newName: "MusteriSoyisim");

            migrationBuilder.RenameColumn(
                name: "UrunlerImageURL",
                table: "urunlers",
                newName: "MusteriIsim");

            migrationBuilder.AddColumn<string>(
                name: "Fiyat",
                table: "urunlers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusteriAdres",
                table: "urunlers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AraclarFiyat",
                table: "araclars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "urunlers");

            migrationBuilder.DropColumn(
                name: "MusteriAdres",
                table: "urunlers");

            migrationBuilder.DropColumn(
                name: "AraclarFiyat",
                table: "araclars");

            migrationBuilder.RenameColumn(
                name: "PanelMetrekare",
                table: "urunlers",
                newName: "UrunlerUzunAciklama");

            migrationBuilder.RenameColumn(
                name: "MusteriSoyisim",
                table: "urunlers",
                newName: "UrunlerKisaAciklama");

            migrationBuilder.RenameColumn(
                name: "MusteriIsim",
                table: "urunlers",
                newName: "UrunlerImageURL");
        }
    }
}
