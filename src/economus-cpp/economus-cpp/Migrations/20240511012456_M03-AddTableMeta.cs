using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace economus_cpp.Migrations
{
    /// <inheritdoc />
    public partial class M03AddTableMeta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valorAplicado = table.Column<double>(type: "float", nullable: false),
                    valorFinal = table.Column<double>(type: "float", nullable: false),
                    DeadLine = table.Column<DateOnly>(type: "date", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meta", x => x.id);
                    table.ForeignKey(
                        name: "FK_Meta_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meta_usuarioId",
                table: "Meta",
                column: "usuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meta");
        }
    }
}
