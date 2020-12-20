using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Data.Migrations
{
    public partial class Propertynameupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ORDERRECORDS");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemSequence",
                table: "ORDERRECORDS",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderItemSequence",
                table: "ORDERRECORDS");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ORDERRECORDS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
