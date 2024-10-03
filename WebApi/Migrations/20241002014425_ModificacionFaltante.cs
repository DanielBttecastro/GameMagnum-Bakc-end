using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionFaltante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RondasJugadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_RondasId = table.Column<int>(type: "int", nullable: false),
                    Id_JugadoresId = table.Column<int>(type: "int", nullable: false),
                    Id_OpcionId = table.Column<int>(type: "int", nullable: false),
                    Victoria = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RondasJugadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RondasJugadas_Jugadores_Id_JugadoresId",
                        column: x => x.Id_JugadoresId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RondasJugadas_Opciones_Id_OpcionId",
                        column: x => x.Id_OpcionId,
                        principalTable: "Opciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RondasJugadas_Rondas_Id_RondasId",
                        column: x => x.Id_RondasId,
                        principalTable: "Rondas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RondasJugadas_Id_JugadoresId",
                table: "RondasJugadas",
                column: "Id_JugadoresId");

            migrationBuilder.CreateIndex(
                name: "IX_RondasJugadas_Id_OpcionId",
                table: "RondasJugadas",
                column: "Id_OpcionId");

            migrationBuilder.CreateIndex(
                name: "IX_RondasJugadas_Id_RondasId",
                table: "RondasJugadas",
                column: "Id_RondasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RondasJugadas");

            migrationBuilder.DropTable(
                name: "Opciones");
        }
    }
}
