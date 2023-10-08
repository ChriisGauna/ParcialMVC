using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcialMVC.Migrations
{
    /// <inheritdoc />
    public partial class initial_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Edad = table.Column<decimal>(type: "TEXT", nullable: false),
                    Empresa = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Año = table.Column<int>(type: "INTEGER", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    EsNacional = table.Column<bool>(type: "INTEGER", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    Empresa = table.Column<string>(type: "TEXT", nullable: true),
                    Imagen = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libro_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libro_ClienteId",
                table: "Libro",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
