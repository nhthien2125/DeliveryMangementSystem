using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryMangementSystem.Migrations
{
    public partial class v2_0_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_SHIPPER_Shipper_ID",
                table: "Account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_Shipper_ID",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "ACCOUNT");

            migrationBuilder.RenameColumn(
                name: "Order_Date",
                table: "xORDER",
                newName: "OrderDate");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "SHIPPER",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SHIPPER",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "SHIPPER",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "CUSTOMER",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CUSTOMER",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "CUSTOMER",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BRANCH",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "BRANCH",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ACCOUNT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ACCOUNT",
                table: "ACCOUNT",
                column: "Account_ID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACCOUNT_SHIPPER_Shipper_ID",
                table: "ACCOUNT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ACCOUNT",
                table: "ACCOUNT");

            migrationBuilder.DropIndex(
                name: "IX_ACCOUNT_Shipper_ID",
                table: "ACCOUNT");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ACCOUNT");

            migrationBuilder.RenameTable(
                name: "ACCOUNT",
                newName: "Account");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "xORDER",
                newName: "Order_Date");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "SHIPPER",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SHIPPER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "SHIPPER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "CUSTOMER",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "CUSTOMER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BRANCH",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "BRANCH",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Account_ID");

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
    }
}
