using Microsoft.EntityFrameworkCore.Migrations;

namespace CommonModels.Migrations
{
    public partial class ChangePropertyNamePartyInBattleClassToEnemysParty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Parties_PartyId",
                table: "Battles");

            migrationBuilder.DropIndex(
                name: "IX_Battles_PartyId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "Battles");

            migrationBuilder.AddColumn<int>(
                name: "EnemysPartyId",
                table: "Battles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Battles_EnemysPartyId",
                table: "Battles",
                column: "EnemysPartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Parties_EnemysPartyId",
                table: "Battles",
                column: "EnemysPartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Parties_EnemysPartyId",
                table: "Battles");

            migrationBuilder.DropIndex(
                name: "IX_Battles_EnemysPartyId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "EnemysPartyId",
                table: "Battles");

            migrationBuilder.AddColumn<int>(
                name: "PartyId",
                table: "Battles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Battles_PartyId",
                table: "Battles",
                column: "PartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Parties_PartyId",
                table: "Battles",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
