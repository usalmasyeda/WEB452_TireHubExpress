using Microsoft.EntityFrameworkCore.Migrations;

namespace TireHubExpress.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tire",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Durability = table.Column<string>(nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Review = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tire", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tire");
        }
    }
}
