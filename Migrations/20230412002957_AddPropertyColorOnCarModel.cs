using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase5.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyColorOnCarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) // Se ejecutará cuando hagamos un database update
        {
            migrationBuilder.AddColumn<string>(// agrega columna
                name: "Color",
                table: "Car",
                type: "TEXT",
                nullable: false,
                defaultValue: "Gris");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) // Poder movernos entre migraciones (deshacer los cambios) 
        {
            migrationBuilder.DropColumn(// eliminar columna color
                name: "Color",
                table: "Car");
        }
    }
}
