using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.net_Web_API.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hero", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mr. Nice" },
                    { 2, "Narco" },
                    { 3, "Bombasto" },
                    { 4, "Celeritas" },
                    { 5, "Magneta" },
                    { 6, "RubberMan" },
                    { 7, "Dynama" },
                    { 8, "Dr IQ" },
                    { 9, "Magma" },
                    { 10, "Tornado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hero");
        }
    }
}
