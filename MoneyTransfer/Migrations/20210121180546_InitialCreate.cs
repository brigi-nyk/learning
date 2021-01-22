using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoneyTransfer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id_Transaction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Sender = table.Column<int>(type: "int", nullable: false),
                    Amount_Sender = table.Column<int>(type: "int", nullable: false),
                    Currency_Sender = table.Column<int>(type: "int", nullable: false),
                    Id_Receiver = table.Column<int>(type: "int", nullable: false),
                    Amount_Receiver = table.Column<int>(type: "int", nullable: false),
                    Currency_Receiver = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transaction_State = table.Column<int>(type: "int", nullable: false),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id_Transaction);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
