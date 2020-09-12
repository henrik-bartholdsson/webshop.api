using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    SORT_ORDER = table.Column<int>(nullable: false),
                    PARENT_ID = table.Column<int>(nullable: true),
                    REDIRECT_TO_ID = table.Column<int>(nullable: true),
                    ACTIVE = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CATEGORY_CATEGORY_PARENT_ID",
                        column: x => x.PARENT_ID,
                        principalTable: "CATEGORY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CORS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADDRESS = table.Column<string>(nullable: true),
                    ACTIVE = table.Column<bool>(nullable: false),
                    COMMENT = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CORS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    PRICE = table.Column<int>(nullable: false),
                    EXTRA_PRICE = table.Column<int>(nullable: false),
                    EXTRA_PRICE_ACTIVE = table.Column<bool>(nullable: false),
                    PARENT_CATEGORY_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORY_PARENT_ID",
                table: "CATEGORY",
                column: "PARENT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CATEGORY");

            migrationBuilder.DropTable(
                name: "CORS");

            migrationBuilder.DropTable(
                name: "PRODUCT");
        }
    }
}
