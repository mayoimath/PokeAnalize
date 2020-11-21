using Microsoft.EntityFrameworkCore.Migrations;

namespace CommonModels.Migrations
{
    public partial class ChangePropertyNameEnemyPartyInBattleClassToMyParty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "MyPartyId",
                table: "Battles",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Parties_MyPartyId",
                table: "Battles");

            migrationBuilder.DropIndex(
                name: "IX_Battles_MyPartyId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "MyPartyId",
                table: "Battles");

            migrationBuilder.AddColumn<int>(
                name: "EnemysPartyId",
                table: "Battles",
                type: "int",
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
    }
}
