using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryMangementSystem.Migrations
{
    public partial class RemodelShipper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "SHIPPER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SHIPPER_AccountId",
                table: "SHIPPER",
                column: "AccountId",
                unique: true,
                filter: "[AccountId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_SHIPPER_Account_AccountId",
                table: "SHIPPER",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Account_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SHIPPER_Account_AccountId",
                table: "SHIPPER");

            migrationBuilder.DropIndex(
                name: "IX_SHIPPER_AccountId",
                table: "SHIPPER");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "SHIPPER");
        }
    }
}
