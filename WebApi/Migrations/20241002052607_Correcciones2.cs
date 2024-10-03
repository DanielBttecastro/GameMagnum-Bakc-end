using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Correcciones2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rondas_Juegos_Id_GameId",
                table: "Rondas");

            migrationBuilder.DropForeignKey(
                name: "FK_RondasJugadas_Jugadores_Id_PlayersId",
                table: "RondasJugadas");

            migrationBuilder.DropForeignKey(
                name: "FK_RondasJugadas_Opciones_Id_OptionsId",
                table: "RondasJugadas");

            migrationBuilder.DropForeignKey(
                name: "FK_RondasJugadas_Rondas_Id_RoundsId",
                table: "RondasJugadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RondasJugadas",
                table: "RondasJugadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rondas",
                table: "Rondas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opciones",
                table: "Opciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Juegos",
                table: "Juegos");

            migrationBuilder.RenameTable(
                name: "RondasJugadas",
                newName: "RoundsGames");

            migrationBuilder.RenameTable(
                name: "Rondas",
                newName: "Rounds");

            migrationBuilder.RenameTable(
                name: "Opciones",
                newName: "Options");

            migrationBuilder.RenameTable(
                name: "Jugadores",
                newName: "Players");

            migrationBuilder.RenameTable(
                name: "Juegos",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_RoundsId",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_RoundsId");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_PlayersId",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_PlayersId");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_OptionsId",
                table: "RoundsGames",
                newName: "IX_RoundsGames_Id_OptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Rondas_Id_GameId",
                table: "Rounds",
                newName: "IX_Rounds_Id_GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoundsGames",
                table: "RoundsGames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rounds",
                table: "Rounds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Options",
                table: "Options",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoundsGames",
                table: "RoundsGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rounds",
                table: "Rounds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Options",
                table: "Options");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "RoundsGames",
                newName: "RondasJugadas");

            migrationBuilder.RenameTable(
                name: "Rounds",
                newName: "Rondas");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Jugadores");

            migrationBuilder.RenameTable(
                name: "Options",
                newName: "Opciones");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Juegos");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_RoundsId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_RoundsId");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_PlayersId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_PlayersId");

            migrationBuilder.RenameIndex(
                name: "IX_RoundsGames_Id_OptionsId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_OptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Rounds_Id_GameId",
                table: "Rondas",
                newName: "IX_Rondas_Id_GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RondasJugadas",
                table: "RondasJugadas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rondas",
                table: "Rondas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opciones",
                table: "Opciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Juegos",
                table: "Juegos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rondas_Juegos_Id_GameId",
                table: "Rondas",
                column: "Id_GameId",
                principalTable: "Juegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RondasJugadas_Jugadores_Id_PlayersId",
                table: "RondasJugadas",
                column: "Id_PlayersId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RondasJugadas_Opciones_Id_OptionsId",
                table: "RondasJugadas",
                column: "Id_OptionsId",
                principalTable: "Opciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RondasJugadas_Rondas_Id_RoundsId",
                table: "RondasJugadas",
                column: "Id_RoundsId",
                principalTable: "Rondas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
