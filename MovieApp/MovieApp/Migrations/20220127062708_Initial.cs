using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    movieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentto = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.movieID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movieID", "category", "director", "edited", "lentto", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Romantic Comedy", "Mark Steven Johnson", false, null, null, "PG-13", "When in Rome", "2010" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movieID", "category", "director", "edited", "lentto", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Comedy/Family", "Tom McGrath", false, null, null, "PG", "Megamind", "2010" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movieID", "category", "director", "edited", "lentto", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action/Adventure", "Joe Johnston", false, null, null, "PG-13", "Captain America: The First Avenger", "2011" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
