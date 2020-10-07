using Microsoft.EntityFrameworkCore.Migrations;

namespace MuicStore2.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Music",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    YearReleased = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Album = table.Column<string>(nullable: true),
                    Feature = table.Column<bool>(nullable: false),
                    FeaturedArtist = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.Id);
                });
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Music");
        }
    }
}
