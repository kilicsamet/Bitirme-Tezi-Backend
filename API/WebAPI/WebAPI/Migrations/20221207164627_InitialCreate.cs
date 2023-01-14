using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subelers",
                columns: table => new
                {
                    SubelerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubelerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubelerIl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubelerAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubelerTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubelerImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subelers", x => x.SubelerID);
                });

            migrationBuilder.CreateTable(
                name: "urunlers",
                columns: table => new
                {
                    UrunlerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunlerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunlerUzunAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunlerKisaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunlerImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunlers", x => x.UrunlerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subelers");

            migrationBuilder.DropTable(
                name: "urunlers");
        }
    }
}
