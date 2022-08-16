using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericRPGBlazor.Server.Migrations
{
    public partial class someChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "HPModifier",
                table: "Races",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MPModifier",
                table: "Races",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "PlayerSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSkills_SkillId",
                table: "PlayerSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSkills_Skills_SkillId",
                table: "PlayerSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSkills_Skills_SkillId",
                table: "PlayerSkills");

            migrationBuilder.DropIndex(
                name: "IX_PlayerSkills_SkillId",
                table: "PlayerSkills");

            migrationBuilder.DropColumn(
                name: "HPModifier",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "MPModifier",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "PlayerSkills");
        }
    }
}
