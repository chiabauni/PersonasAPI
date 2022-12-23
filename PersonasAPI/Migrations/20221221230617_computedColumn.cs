using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonasAPI.Migrations
{
    public partial class computedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "CASE\r\n	WHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 11 THEN 'Niños' 	\r\n	WHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) >=11 AND FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 18 THEN 'Adolescentes'\r\n	WHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25)>=18 AND FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 80 THEN 'Adultos'\r\n	WHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) >=80 THEN 'Octogenario'\r\nEND ",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComputedColumnSql: "CASE\r\n	WHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 11 THEN 'Niños' 	\r\n	WHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) >=11 AND FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 18 THEN 'Adolescentes'\r\n	WHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25)>=18 AND FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) < 80 THEN 'Adultos'\r\n	WHEN FLOOR(DATEDIFF(DAY, FechaNacimiento, GETDATE())/365.25) >=80 THEN 'Octogenario'\r\nEND ");
        }
    }
}
