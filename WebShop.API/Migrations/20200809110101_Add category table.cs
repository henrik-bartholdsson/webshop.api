using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.API.Migrations
{
    public partial class Addcategorytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    PRODUCT_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECT_ID = table.Column<int>(nullable: false),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    SORT_ORDER = table.Column<int>(nullable: false),
                    TYPE_ID = table.Column<int>(nullable: false),
                    PARENT_ID = table.Column<int>(nullable: false),
                    REDIRECT_TO_ID = table.Column<int>(nullable: false),
                    ACTIVE = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.PRODUCT_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
