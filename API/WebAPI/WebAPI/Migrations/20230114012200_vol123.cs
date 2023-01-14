using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class vol123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subelers");

            migrationBuilder.AddColumn<string>(
                name: "AraclarURL",
                table: "araclars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AraclarURL",
                table: "araclars");

            migrationBuilder.CreateTable(
                name: "subelers",
                columns: table => new
                {
                    SubelerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubelerAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubelerIl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubelerImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubelerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubelerTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subelers", x => x.SubelerID);
                });
        }
    }
}
