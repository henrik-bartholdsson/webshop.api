using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Data.Migrations
{
    public partial class Add_order_orderrecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    OrderInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ORDERRECORDS",
                columns: table => new
                {
                    OrderRecordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERRECORDS", x => x.OrderRecordId);
                    table.ForeignKey(
                        name: "FK_ORDERRECORDS_ORDERS_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ORDERS",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDERRECORDS_OrderId",
                table: "ORDERRECORDS",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDERRECORDS");

            migrationBuilder.DropTable(
                name: "ORDERS");
        }
    }
}
