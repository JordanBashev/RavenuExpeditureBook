using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormsApp1.Migrations
{
    /// <summary>
    /// Main initial partial class
    /// Countains ovveride methods used to create the database
    /// </summary>
    public partial class initial : Migration
    {
        /// <summary>
        /// Creates the tables
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonBookTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookType = table.Column<string>(nullable: false),
                    PersonAccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonBookTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonRegisters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonRegisters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonAccounts",
                columns: table => new
                {
                    PersonRegistersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonBookTypesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAccounts", x => x.PersonRegistersId);
                    table.ForeignKey(
                        name: "FK_PersonAccounts_PersonBookTypes_PersonBookTypesId",
                        column: x => x.PersonBookTypesId,
                        principalTable: "PersonBookTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RevenueExpenditureBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Income = table.Column<decimal>(nullable: false),
                    RawMaterials = table.Column<decimal>(nullable: false),
                    Expense = table.Column<decimal>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    Counted = table.Column<decimal>(nullable: false),
                    CheckOutPlusAndMinus = table.Column<decimal>(nullable: false),
                    AccountRavenueBookId = table.Column<int>(nullable: false),
                    UserRegisteredId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevenueExpenditureBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RevenueExpenditureBooks_PersonBookTypes_AccountRavenueBookId",
                        column: x => x.AccountRavenueBookId,
                        principalTable: "PersonBookTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RevenueExpenditureBooks_PersonRegisters_UserRegisteredId",
                        column: x => x.UserRegisteredId,
                        principalTable: "PersonRegisters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonAccounts_PersonBookTypesId",
                table: "PersonAccounts",
                column: "PersonBookTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_RevenueExpenditureBooks_AccountRavenueBookId",
                table: "RevenueExpenditureBooks",
                column: "AccountRavenueBookId");

            migrationBuilder.CreateIndex(
                name: "IX_RevenueExpenditureBooks_UserRegisteredId",
                table: "RevenueExpenditureBooks",
                column: "UserRegisteredId");
        }

        /// <summary>
        /// Drops the tablse if they exist
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonAccounts");

            migrationBuilder.DropTable(
                name: "RevenueExpenditureBooks");

            migrationBuilder.DropTable(
                name: "PersonBookTypes");

            migrationBuilder.DropTable(
                name: "PersonRegisters");
        }
    }
}
