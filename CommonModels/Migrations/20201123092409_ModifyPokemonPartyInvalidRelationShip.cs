using Microsoft.EntityFrameworkCore.Migrations;

namespace CommonModels.Migrations
{
    public partial class ModifyPokemonPartyInvalidRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonBattle_Parties_PartyId",
                table: "PokemonBattle");

            migrationBuilder.DropIndex(
                name: "IX_PokemonBattle_PartyId",
                table: "PokemonBattle");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "PokemonBattle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartyId",
                table: "PokemonBattle",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBattle_PartyId",
                table: "PokemonBattle",
                column: "PartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonBattle_Parties_PartyId",
                table: "PokemonBattle",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
