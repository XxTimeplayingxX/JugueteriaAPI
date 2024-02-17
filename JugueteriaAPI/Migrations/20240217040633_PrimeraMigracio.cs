using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JugueteriaAPI.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Juguetes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juguetes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JugueteDetalles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JugueteDetalles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JugueteDetalles_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JugueteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categorias_Juguetes_JugueteID",
                        column: x => x.JugueteID,
                        principalTable: "Juguetes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ID", "Direccion", "Email", "NombreCompleto" },
                values: new object[,]
                {
                    { 1, "Calle 123", "juan@example.com", "Juan Perez" },
                    { 2, "Avenida 456", "maria@example.com", "María García" }
                });

            migrationBuilder.InsertData(
                table: "Juguetes",
                columns: new[] { "ID", "Descripcion", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Muñeca de porcelana", "Muñeca", 25m },
                    { 2, "Carro a control remoto", "Carro de Juguete", 30m }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "ID", "JugueteID", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Juguetes para niñas" },
                    { 2, 2, "Juguetes para niños" }
                });

            migrationBuilder.InsertData(
                table: "JugueteDetalles",
                columns: new[] { "ID", "ClienteID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_JugueteID",
                table: "Categorias",
                column: "JugueteID");

            migrationBuilder.CreateIndex(
                name: "IX_JugueteDetalles_ClienteID",
                table: "JugueteDetalles",
                column: "ClienteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "JugueteDetalles");

            migrationBuilder.DropTable(
                name: "Juguetes");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
