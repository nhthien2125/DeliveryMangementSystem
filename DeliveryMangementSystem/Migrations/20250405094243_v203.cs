using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryMangementSystem.Migrations
{
    public partial class v203 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_xORDER_SHIPPER_Shipper_ID",
                table: "xORDER");

            migrationBuilder.AlterColumn<string>(
                name: "Shipper_ID",
                table: "xORDER",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddForeignKey(
                name: "FK_xORDER_SHIPPER_Shipper_ID",
                table: "xORDER",
                column: "Shipper_ID",
                principalTable: "SHIPPER",
                principalColumn: "Shipper_ID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_xORDER_SHIPPER_Shipper_ID",
                table: "xORDER");

            migrationBuilder.AlterColumn<string>(
                name: "Shipper_ID",
                table: "xORDER",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_xORDER_SHIPPER_Shipper_ID",
                table: "xORDER",
                column: "Shipper_ID",
                principalTable: "SHIPPER",
                principalColumn: "Shipper_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
