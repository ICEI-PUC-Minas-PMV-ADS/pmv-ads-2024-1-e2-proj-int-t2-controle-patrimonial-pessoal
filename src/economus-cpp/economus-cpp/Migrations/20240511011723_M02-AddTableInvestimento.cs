using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace economus_cpp.Migrations
{
    /// <inheritdoc />
    public partial class M02AddTableInvestimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investimento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    valorInvestido = table.Column<double>(type: "float", nullable: false),
                    taxaRendimento = table.Column<double>(type: "float", nullable: false),
                    taxaImposto = table.Column<double>(type: "float", nullable: false),
                    dataFinal = table.Column<DateOnly>(type: "date", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investimento", x => x.id);
                    table.ForeignKey(
                        name: "FK_Investimento_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investimento_usuarioId",
                table: "Investimento",
                column: "usuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investimento");
        }
    }
}
