using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Correcciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rondas_Juegos_Id_JuegoId",
                table: "Rondas");

            migrationBuilder.DropForeignKey(
                name: "FK_RondasJugadas_Jugadores_Id_JugadoresId",
                table: "RondasJugadas");

            migrationBuilder.DropForeignKey(
                name: "FK_RondasJugadas_Opciones_Id_OpcionId",
                table: "RondasJugadas");

            migrationBuilder.DropForeignKey(
                name: "FK_RondasJugadas_Rondas_Id_RondasId",
                table: "RondasJugadas");

            migrationBuilder.RenameColumn(
                name: "Victoria",
                table: "RondasJugadas",
                newName: "Victory");

            migrationBuilder.RenameColumn(
                name: "Id_RondasId",
                table: "RondasJugadas",
                newName: "Id_RoundsId");

            migrationBuilder.RenameColumn(
                name: "Id_OpcionId",
                table: "RondasJugadas",
                newName: "Id_PlayersId");

            migrationBuilder.RenameColumn(
                name: "Id_JugadoresId",
                table: "RondasJugadas",
                newName: "Id_OptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_RondasId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_RoundsId");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_OpcionId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_PlayersId");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_JugadoresId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_OptionsId");

            migrationBuilder.RenameColumn(
                name: "Id_JuegoId",
                table: "Rondas",
                newName: "Id_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Rondas_Id_JuegoId",
                table: "Rondas",
                newName: "IX_Rondas_Id_GameId");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Jugadores",
                newName: "Name");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Victory",
                table: "RondasJugadas",
                newName: "Victoria");

            migrationBuilder.RenameColumn(
                name: "Id_RoundsId",
                table: "RondasJugadas",
                newName: "Id_RondasId");

            migrationBuilder.RenameColumn(
                name: "Id_PlayersId",
                table: "RondasJugadas",
                newName: "Id_OpcionId");

            migrationBuilder.RenameColumn(
                name: "Id_OptionsId",
                table: "RondasJugadas",
                newName: "Id_JugadoresId");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_RoundsId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_RondasId");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_PlayersId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_OpcionId");

            migrationBuilder.RenameIndex(
                name: "IX_RondasJugadas_Id_OptionsId",
                table: "RondasJugadas",
                newName: "IX_RondasJugadas_Id_JugadoresId");

            migrationBuilder.RenameColumn(
                name: "Id_GameId",
                table: "Rondas",
                newName: "Id_JuegoId");

            migrationBuilder.RenameIndex(
                name: "IX_Rondas_Id_GameId",
                table: "Rondas",
                newName: "IX_Rondas_Id_JuegoId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Jugadores",
                newName: "Nombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Rondas_Juegos_Id_JuegoId",
                table: "Rondas",
                column: "Id_JuegoId",
                principalTable: "Juegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RondasJugadas_Jugadores_Id_JugadoresId",
                table: "RondasJugadas",
                column: "Id_JugadoresId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RondasJugadas_Opciones_Id_OpcionId",
                table: "RondasJugadas",
                column: "Id_OpcionId",
                principalTable: "Opciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RondasJugadas_Rondas_Id_RondasId",
                table: "RondasJugadas",
                column: "Id_RondasId",
                principalTable: "Rondas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
