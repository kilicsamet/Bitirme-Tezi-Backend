using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "araclars",
                columns: table => new
                {
                    AraclarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AraclarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraclarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraclarYıl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraclarSeri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraclarRenk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraclarDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraclarHız = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AraclarYakıt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_araclars", x => x.AraclarID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "araclars");
        }
    }
}
