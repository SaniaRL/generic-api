using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace generic_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "postCategoryDisplaySettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Index = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postCategoryDisplaySettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "postCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    TextColor = table.Column<string>(type: "TEXT", nullable: false),
                    BackgroundColor = table.Column<string>(type: "TEXT", nullable: false),
                    DisplaySettingsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_postCategories_postCategoryDisplaySettings_DisplaySettingsId",
                        column: x => x.DisplaySettingsId,
                        principalTable: "postCategoryDisplaySettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "postCategoryDisplaySettings",
                columns: new[] { "Id", "Index" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "postCategories",
                columns: new[] { "Id", "BackgroundColor", "DisplaySettingsId", "TextColor", "Title" },
                values: new object[,]
                {
                    { 1, "#585858", 1, "#FFFFFF", "Post" },
                    { 2, "#2D416F", 2, "#FFFFFF", "Work" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_postCategories_DisplaySettingsId",
                table: "postCategories",
                column: "DisplaySettingsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postCategories");

            migrationBuilder.DropTable(
                name: "postCategoryDisplaySettings");
        }
    }
}
