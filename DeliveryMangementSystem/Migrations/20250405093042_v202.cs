using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryMangementSystem.Migrations
{
    public partial class v202 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACCOUNT_SHIPPER_S_ID",
                table: "ACCOUNT");

            migrationBuilder.AddForeignKey(
                name: "FK_ACCOUNT_SHIPPER_S_ID",
                table: "ACCOUNT",
                column: "S_ID",
                principalTable: "SHIPPER",
                principalColumn: "Shipper_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACCOUNT_SHIPPER_S_ID",
                table: "ACCOUNT");

            migrationBuilder.AddForeignKey(
                name: "FK_ACCOUNT_SHIPPER_S_ID",
                table: "ACCOUNT",
                column: "S_ID",
                principalTable: "SHIPPER",
                principalColumn: "Shipper_ID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
