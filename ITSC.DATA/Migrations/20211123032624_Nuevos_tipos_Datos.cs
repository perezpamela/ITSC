using Microsoft.EntityFrameworkCore.Migrations;

namespace ITSC.DATA.Migrations
{
    public partial class Nuevos_tipos_Datos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarreraSede");

            migrationBuilder.AlterColumn<int>(
                name: "dia_hasta",
                table: "sedes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "dia_desde",
                table: "sedes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "usuario_password",
                table: "alumnos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "dia_hasta",
                table: "sedes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "dia_desde",
                table: "sedes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "usuario_password",
                table: "alumnos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CarreraSede",
                columns: table => new
                {
                    Carrerasid = table.Column<int>(type: "int", nullable: false),
                    Sedesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarreraSede", x => new { x.Carrerasid, x.Sedesid });
                    table.ForeignKey(
                        name: "FK_CarreraSede_carreras_Carrerasid",
                        column: x => x.Carrerasid,
                        principalTable: "carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarreraSede_sedes_Sedesid",
                        column: x => x.Sedesid,
                        principalTable: "sedes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarreraSede_Sedesid",
                table: "CarreraSede",
                column: "Sedesid");
        }
    }
}
