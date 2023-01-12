using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGameScore.Infrastructure.Persistence.Migrations
{
    public partial class AddSeasonTableAndConfigureAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdSeason",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeasonStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SeasonEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdPlayer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_Players_IdPlayer",
                        column: x => x.IdPlayer,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_IdSeason",
                table: "Matches",
                column: "IdSeason");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_IdPlayer",
                table: "Seasons",
                column: "IdPlayer");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Seasons_IdSeason",
                table: "Matches",
                column: "IdSeason",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Seasons_IdSeason",
                table: "Matches");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropIndex(
                name: "IX_Matches_IdSeason",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "IdSeason",
                table: "Matches");
        }
    }
}
