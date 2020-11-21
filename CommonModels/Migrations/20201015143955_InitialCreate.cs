using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommonModels.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ranking = table.Column<int>(nullable: true),
                    MyPartyId = table.Column<int>(nullable: false),
                    MyFirstElection = table.Column<int>(nullable: false),
                    MySecondElection = table.Column<int>(nullable: false),
                    MyThirdElection = table.Column<int>(nullable: false),
                    EnemysFirstElection = table.Column<int>(nullable: false),
                    EnemysSecondElection = table.Column<int>(nullable: true),
                    EnemysThirdElection = table.Column<int>(nullable: true),
                    Win = table.Column<bool>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Battles_Parties_MyPartyId",
                        column: x => x.MyPartyId,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<decimal>(type: "decimal(3,0)", nullable: false),
                    Name = table.Column<string>(maxLength: 6, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Type2 = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    HP = table.Column<byte>(type: "tinyint", nullable: true),
                    Attack = table.Column<byte>(type: "tinyint", nullable: true),
                    Defense = table.Column<byte>(type: "tinyint", nullable: true),
                    SpAtk = table.Column<byte>(type: "tinyint", nullable: true),
                    SpDef = table.Column<byte>(type: "tinyint", nullable: true),
                    Speed = table.Column<byte>(type: "tinyint", nullable: true),
                    BattleId = table.Column<int>(nullable: true),
                    PartyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemons_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battles_MyPartyId",
                table: "Battles",
                column: "MyPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_BattleId",
                table: "Pokemons",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PartyId",
                table: "Pokemons",
                column: "PartyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "Parties");
        }
    }
}
