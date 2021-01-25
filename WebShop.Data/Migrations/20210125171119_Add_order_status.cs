using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Data.Migrations
{
    public partial class Add_order_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderStatusId",
                table: "ORDERS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ORDER_STATUS",
                columns: table => new
                {
                    OrderStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatusText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_STATUS", x => x.OrderStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_OrderStatusId",
                table: "ORDERS",
                column: "OrderStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDERS_ORDER_STATUS_OrderStatusId",
                table: "ORDERS",
                column: "OrderStatusId",
                principalTable: "ORDER_STATUS",
                principalColumn: "OrderStatusId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDERS_ORDER_STATUS_OrderStatusId",
                table: "ORDERS");

            migrationBuilder.DropTable(
                name: "ORDER_STATUS");

            migrationBuilder.DropIndex(
                name: "IX_ORDERS_OrderStatusId",
                table: "ORDERS");

            migrationBuilder.DropColumn(
                name: "OrderStatusId",
                table: "ORDERS");
        }
    }
}
