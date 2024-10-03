using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rounds_Games_Id_GameId",
                table: "Rounds");

            migrationBuilder.DropForeignKey(
                name: "FK_RoundsGames_Options_Id_OptionsId",
                table: "RoundsGames");

            migrationBuilder.DropForeignKey(
                name: "FK_RoundsGames_Players_Id_PlayersId",
                table: "RoundsGames");

            migrationBuilder.DropForeignKey(
                name: "FK_RoundsGames_Rounds_Id_RoundsId",
                table: "RoundsGames");

            migrationBuilder.RenameColumn(
                name: "Id_RoundsId",
                table: "RoundsGames",
                newName: "Id_Rounds");

            migrationBuilder.RenameColumn(
                name: "Id_PlayersId",
                table: "RoundsGames",
                newName: "Id_Players");

            migrationBuilder.RenameColumn(
                name: "Id_OptionsId",
                table: "RoundsGames",
                newName: "Id_Options");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_RoundsId",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_Rounds");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_PlayersId",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_Players");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_OptionsId",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_Options");

            migrationBuilder.RenameColumn(
                name: "Id_GameId",
                table: "Rounds",
                newName: "Id_Game");

            migrationBuilder.RenameIndex(
                name: "IX_Rounds_Id_GameId",
                table: "Rounds",
                newName: "IX_Rounds_Id_Game");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Rounds_Games_Id_Game",
                table: "Rounds",
                column: "Id_Game",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundsGames_Options_Id_Options",
                table: "RoundsGames",
                column: "Id_Options",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundsGames_Players_Id_Players",
                table: "RoundsGames",
                column: "Id_Players",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundsGames_Rounds_Id_Rounds",
                table: "RoundsGames",
                column: "Id_Rounds",
                principalTable: "Rounds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rounds_Games_Id_Game",
                table: "Rounds");

            migrationBuilder.DropForeignKey(
                name: "FK_RoundsGames_Options_Id_Options",
                table: "RoundsGames");

            migrationBuilder.DropForeignKey(
                name: "FK_RoundsGames_Players_Id_Players",
                table: "RoundsGames");

            migrationBuilder.DropForeignKey(
                name: "FK_RoundsGames_Rounds_Id_Rounds",
                table: "RoundsGames");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "Id_Rounds",
                table: "RoundsGames",
                newName: "Id_RoundsId");

            migrationBuilder.RenameColumn(
                name: "Id_Players",
                table: "RoundsGames",
                newName: "Id_PlayersId");

            migrationBuilder.RenameColumn(
                name: "Id_Options",
                table: "RoundsGames",
                newName: "Id_OptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_Rounds",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_RoundsId");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_Players",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_PlayersId");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_Options",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_OptionsId");

            migrationBuilder.RenameColumn(
                name: "Id_Game",
                table: "Rounds",
                newName: "Id_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Rounds_Id_Game",
                table: "Rounds",
                newName: "IX_Rounds_Id_GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rounds_Games_Id_GameId",
                table: "Rounds",
                column: "Id_GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundsGames_Options_Id_OptionsId",
                table: "RoundsGames",
                column: "Id_OptionsId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundsGames_Players_Id_PlayersId",
                table: "RoundsGames",
                column: "Id_PlayersId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundsGames_Rounds_Id_RoundsId",
                table: "RoundsGames",
                column: "Id_RoundsId",
                principalTable: "Rounds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
