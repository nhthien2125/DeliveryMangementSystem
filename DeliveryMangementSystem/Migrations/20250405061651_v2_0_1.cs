using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryMangementSystem.Migrations
{
    public partial class v2_0_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACCOUNT_SHIPPER_Shipper_ID",
                table: "ACCOUNT");

            migrationBuilder.DropIndex(
                name: "IX_ACCOUNT_Shipper_ID",
                table: "ACCOUNT");

            migrationBuilder.DropColumn(
                name: "Shipper_ID",
                table: "ACCOUNT");

            migrationBuilder.AddColumn<string>(
                name: "S_ID",
                table: "ACCOUNT",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ACCOUNT_S_ID",
                table: "ACCOUNT",
                column: "S_ID",
                unique: true,
                filter: "[S_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ACCOUNT_SHIPPER_S_ID",
                table: "ACCOUNT",
                column: "S_ID",
                principalTable: "SHIPPER",
                principalColumn: "Shipper_ID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACCOUNT_SHIPPER_S_ID",
                table: "ACCOUNT");

            migrationBuilder.DropIndex(
                name: "IX_ACCOUNT_S_ID",
                table: "ACCOUNT");

            migrationBuilder.DropColumn(
                name: "S_ID",
                table: "ACCOUNT");

            migrationBuilder.AddColumn<string>(
                name: "Shipper_ID",
                table: "ACCOUNT",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ACCOUNT_Shipper_ID",
                table: "ACCOUNT",
                column: "Shipper_ID",
                unique: true,
                filter: "[Shipper_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ACCOUNT_SHIPPER_Shipper_ID",
                table: "ACCOUNT",
                column: "Shipper_ID",
                principalTable: "SHIPPER",
                principalColumn: "Shipper_ID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
