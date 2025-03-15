using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryMangementSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SHIPPER",
                columns: table => new
                {
                    Shipper_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Phone = table.Column<string>(maxLength: 10, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHIPPER", x => x.Shipper_ID);
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SHIPPER");
        }
    }
}
