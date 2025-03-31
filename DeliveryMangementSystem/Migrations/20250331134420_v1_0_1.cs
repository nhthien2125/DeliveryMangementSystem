using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryMangementSystem.Migrations
{
    public partial class v1_0_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SHIPPER",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "SHIPPER");
        }
    }
}
