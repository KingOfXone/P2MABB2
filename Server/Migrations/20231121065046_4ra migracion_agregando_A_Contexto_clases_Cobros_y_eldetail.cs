using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P2MABB.Server.Migrations
{
    /// <inheritdoc />
    public partial class _4ramigracion_agregando_A_Contexto_clases_Cobros_y_eldetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cobros",
                columns: table => new
                {
                    CobroId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobros", x => x.CobroId);
                });

            migrationBuilder.CreateTable(
                name: "CobrosDetalle",
                columns: table => new
                {
                    CobradoDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CobradoId = table.Column<int>(type: "INTEGER", nullable: false),
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false),
                    montoCobrado = table.Column<double>(type: "REAL", nullable: false),
                    EntradaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CobrosDetalle", x => x.CobradoDetailId);
                    table.ForeignKey(
                        name: "FK_CobrosDetalle_Cobros_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Cobros",
                        principalColumn: "CobroId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CobrosDetalle_EntradaId",
                table: "CobrosDetalle",
                column: "EntradaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CobrosDetalle");

            migrationBuilder.DropTable(
                name: "Cobros");
        }
    }
}
