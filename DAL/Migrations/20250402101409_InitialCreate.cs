using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BRANCH",
                columns: table => new
                {
                    Branch_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRANCH", x => x.Branch_ID);
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                columns: table => new
                {
                    Customer_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Phone = table.Column<string>(maxLength: 10, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => x.Customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "SHIPPER",
                columns: table => new
                {
                    Shipper_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Phone = table.Column<string>(maxLength: 10, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHIPPER", x => x.Shipper_ID);
                });

            migrationBuilder.CreateTable(
                name: "ACCOUNT",
                columns: table => new
                {
                    Account_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Shipper_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCOUNT", x => x.Account_ID);
                    table.ForeignKey(
                        name: "FK_ACCOUNT_SHIPPER_Shipper_Id",
                        column: x => x.Shipper_Id,
                        principalTable: "SHIPPER",
                        principalColumn: "Shipper_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "xORDER",
                columns: table => new
                {
                    Order_ID = table.Column<string>(nullable: false),
                    Branch_ID = table.Column<string>(maxLength: 10, nullable: true),
                    Customer_ID = table.Column<string>(maxLength: 10, nullable: true),
                    Shipper_ID = table.Column<string>(maxLength: 10, nullable: true),
                    Order_Date = table.Column<DateTime>(nullable: false),
                    Delivery_Date = table.Column<DateTime>(nullable: true),
                    Total_Amount = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Payment_Method = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xORDER", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_xORDER_BRANCH_Branch_ID",
                        column: x => x.Branch_ID,
                        principalTable: "BRANCH",
                        principalColumn: "Branch_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_xORDER_CUSTOMER_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "CUSTOMER",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_xORDER_SHIPPER_Shipper_ID",
                        column: x => x.Shipper_ID,
                        principalTable: "SHIPPER",
                        principalColumn: "Shipper_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACCOUNT_Shipper_Id",
                table: "ACCOUNT",
                column: "Shipper_Id",
                unique: true,
                filter: "[Shipper_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_xORDER_Branch_ID",
                table: "xORDER",
                column: "Branch_ID");

            migrationBuilder.CreateIndex(
                name: "IX_xORDER_Customer_ID",
                table: "xORDER",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_xORDER_Shipper_ID",
                table: "xORDER",
                column: "Shipper_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCOUNT");

            migrationBuilder.DropTable(
                name: "xORDER");

            migrationBuilder.DropTable(
                name: "BRANCH");

            migrationBuilder.DropTable(
                name: "CUSTOMER");

            migrationBuilder.DropTable(
                name: "SHIPPER");
        }
    }
}
