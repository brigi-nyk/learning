using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTransfer.Data.Migrations
{
    public partial class CreateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sender",
                columns: table => new
                {
                    CNP = table.Column<Int64>(nullable: false),
                    Age = table.Column<Int16>(nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sender_Id", x => x.CNP);
                });

            migrationBuilder.CreateTable(
                name: "Receiver",
                columns: table => new
                {
                    Id_Receiver = table.Column<Int16>(nullable: false),
                    IBAN = table.Column<string>(nullable: false, maxLength: 35),
                    Country = table.Column<string>(maxLength: 256, nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiver_Id", x => x.Id_Receiver);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id_Currency = table.Column<Int16>(nullable: false)
                    .Annotation("SqlServerValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency_Id", x => x.Id_Currency);
                });

            migrationBuilder.CreateTable(
                name: "Transaction_State",
                columns: table => new
                {
                    Id_State = table.Column<Int16>(nullable: false)
                     .Annotation("SqlServerValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State_Id", x => x.Id_State);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id_Transaction = table.Column<Int16>(nullable: false)
                     .Annotation("SqlServerValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_Sender = table.Column<Int16>(nullable: false),
                    Amount_Sender = table.Column<Int32>(nullable: false),
                    Id_Currency_Sender = table.Column<Int16>(nullable: false),
                    Id_Receiver = table.Column<Int16>(nullable: false),
                    Amount_Receiver = table.Column<Int32>(nullable: false),
                    Id_Currency_Receiver = table.Column<Int16>(nullable: false),
                    Token = table.Column<string>(maxLength: 50),
                    Id_Transaction_State = table.Column<Int16>(nullable: false),
                    Transaction_Date = table.Column<DateTime>(nullable: false)
                    .Annotation("Date", DateTime.Now)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction_Id", x => x.Id_Transaction);
                    table.ForeignKey(
                        name: "FK_Sender_Id",
                        column: x => x.Id_Sender,
                        principalTable: "Sender",
                        principalColumn: "CNP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receiver_Id",
                        column: x => x.Id_Receiver,
                        principalTable: "Receiver",
                        principalColumn: "Id_Receiver",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Currency_Sender_Id",
                        column: x => x.Id_Currency_Sender,
                        principalTable: "Currency",
                        principalColumn: "Id_Currency",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Currency_Receiver_Id",
                        column: x => x.Id_Currency_Receiver,
                        principalTable: "Currency",
                        principalColumn: "Id_Currency",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Status_Id",
                        column: x => x.Id_Transaction_State,
                        principalTable: "Transaction_State",
                        principalColumn: "Id_State",
                        onDelete: ReferentialAction.Cascade);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sender");
            migrationBuilder.DropTable(
                name: "Receiver");
            migrationBuilder.DropTable(
                name: "Currency");
            migrationBuilder.DropTable(
                name: "Transaction_State");
            migrationBuilder.DropTable(
                name: "Transaction");

        }

    }
}
