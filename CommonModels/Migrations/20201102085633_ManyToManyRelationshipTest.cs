using Microsoft.EntityFrameworkCore.Migrations;

namespace CommonModels.Migrations
{
    public partial class ManyToManyRelationshipTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Parties_MyPartyId",
                table: "Battles");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Battles_BattleId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Parties_PartyId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_BattleId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_PartyId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Battles_MyPartyId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "MyPartyId",
                table: "Battles");

            migrationBuilder.AddColumn<int>(
                name: "PartyId",
                table: "Battles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PokemonBattle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(nullable: false),
                    BattleId = table.Column<int>(nullable: false),
                    PartyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonBattle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonBattle_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonBattle_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokemonBattle_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonParty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(nullable: false),
                    PartyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonParty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonParty_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonParty_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battles_PartyId",
                table: "Battles",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBattle_BattleId",
                table: "PokemonBattle",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBattle_PartyId",
                table: "PokemonBattle",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBattle_PokemonId",
                table: "PokemonBattle",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonParty_PartyId",
                table: "PokemonParty",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonParty_PokemonId",
                table: "PokemonParty",
                column: "PokemonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Parties_PartyId",
                table: "Battles",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Parties_PartyId",
                table: "Battles");

            migrationBuilder.DropTable(
                name: "PokemonBattle");

            migrationBuilder.DropTable(
                name: "PokemonParty");

            migrationBuilder.DropIndex(
                name: "IX_Battles_PartyId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "Battles");

            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartyId",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyPartyId",
                table: "Battles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_BattleId",
                table: "Pokemons",
                column: "BattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PartyId",
                table: "Pokemons",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_MyPartyId",
                table: "Battles",
                column: "MyPartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Parties_MyPartyId",
                table: "Battles",
                column: "MyPartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Battles_BattleId",
                table: "Pokemons",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Parties_PartyId",
                table: "Pokemons",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
