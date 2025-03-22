using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryMangementSystem.Migrations
{
    public partial class FKShipper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shipper_ID",
                table: "Account",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Account_Shipper_ID",
                table: "Account",
                column: "Shipper_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_SHIPPER_Shipper_ID",
                table: "Account",
                column: "Shipper_ID",
                principalTable: "SHIPPER",
                principalColumn: "Shipper_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_SHIPPER_Shipper_ID",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_Shipper_ID",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "Shipper_ID",
                table: "Account");
        }
    }
}
