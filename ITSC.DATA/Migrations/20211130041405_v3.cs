using Microsoft.EntityFrameworkCore.Migrations;

namespace ITSC.DATA.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asistencias_clases_claseid",
                table: "asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_asistencias_cursantes_cursanteid",
                table: "asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_clases_materias_carreras_materiacarrera_idid",
                table: "clases");

            migrationBuilder.DropForeignKey(
                name: "FK_clases_materias_carreras_materiacarreraid",
                table: "clases");

            migrationBuilder.DropForeignKey(
                name: "FK_cooperadora_pagos_inscripciones_inscripcionid",
                table: "cooperadora_pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_cursantes_alumnos_alumnoid",
                table: "cursantes");

            migrationBuilder.DropForeignKey(
                name: "FK_cursantes_materias_carreras_materiacarreraid",
                table: "cursantes");

            migrationBuilder.DropForeignKey(
                name: "FK_examenes_materias_carreras_materiacarreraid",
                table: "examenes");

            migrationBuilder.DropForeignKey(
                name: "FK_horarios_materias_carreras_materiacarreraid",
                table: "horarios");

            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_alumnos_alumnoid",
                table: "inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_sedes_carreras_sedecarreraid",
                table: "inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_materias_carreras_materias_materiaid",
                table: "materias_carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_materias_carreras_personales_personalid",
                table: "materias_carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_materias_carreras_sedes_carreras_sedecarreraid",
                table: "materias_carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_notas_examenes_examenid",
                table: "notas");

            migrationBuilder.DropForeignKey(
                name: "FK_sedes_carreras_carreras_carreraid",
                table: "sedes_carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_sedes_carreras_sedes_sedeid",
                table: "sedes_carreras");

            migrationBuilder.DropColumn(
                name: "carrera_id",
                table: "sedes_carreras");

            migrationBuilder.DropColumn(
                name: "sede_id",
                table: "sedes_carreras");

            migrationBuilder.DropColumn(
                name: "examen_id",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "materia_id",
                table: "materias_carreras");

            migrationBuilder.DropColumn(
                name: "personal_id",
                table: "materias_carreras");

            migrationBuilder.DropColumn(
                name: "sedecarrera_id",
                table: "materias_carreras");

            migrationBuilder.DropColumn(
                name: "alumno_id",
                table: "inscripciones");

            migrationBuilder.DropColumn(
                name: "sedecarrera_id",
                table: "inscripciones");

            migrationBuilder.DropColumn(
                name: "materiacarrera_id",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "materiacarrera_id",
                table: "examenes");

            migrationBuilder.DropColumn(
                name: "alumno_id",
                table: "cursantes");

            migrationBuilder.DropColumn(
                name: "materiacarrera_id",
                table: "cursantes");

            migrationBuilder.DropColumn(
                name: "inscripcion_id",
                table: "cooperadora_pagos");

            migrationBuilder.DropColumn(
                name: "clase_id",
                table: "asistencias");

            migrationBuilder.DropColumn(
                name: "cursante_id",
                table: "asistencias");

            migrationBuilder.RenameColumn(
                name: "materiacarreraid",
                table: "clases",
                newName: "materiacarreraidid");

            migrationBuilder.RenameColumn(
                name: "materiacarrera_idid",
                table: "clases",
                newName: "materiacarreraid1");

            migrationBuilder.RenameIndex(
                name: "IX_clases_materiacarreraid",
                table: "clases",
                newName: "IX_clases_materiacarreraidid");

            migrationBuilder.RenameIndex(
                name: "IX_clases_materiacarrera_idid",
                table: "clases",
                newName: "IX_clases_materiacarreraid1");

            migrationBuilder.AlterColumn<int>(
                name: "sedeid",
                table: "sedes_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "carreraid",
                table: "sedes_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "examenid",
                table: "notas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "sedecarreraid",
                table: "materias_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "personalid",
                table: "materias_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "materiaid",
                table: "materias_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "sedecarreraid",
                table: "inscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "alumnoid",
                table: "inscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "materiacarreraid",
                table: "horarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "materiacarreraid",
                table: "examenes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "materiacarreraid",
                table: "cursantes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "alumnoid",
                table: "cursantes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "inscripcionid",
                table: "cooperadora_pagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cursanteid",
                table: "asistencias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "claseid",
                table: "asistencias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_asistencias_clases_claseid",
                table: "asistencias",
                column: "claseid",
                principalTable: "clases",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asistencias_cursantes_cursanteid",
                table: "asistencias",
                column: "cursanteid",
                principalTable: "cursantes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clases_materias_carreras_materiacarreraid1",
                table: "clases",
                column: "materiacarreraid1",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_clases_materias_carreras_materiacarreraidid",
                table: "clases",
                column: "materiacarreraidid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cooperadora_pagos_inscripciones_inscripcionid",
                table: "cooperadora_pagos",
                column: "inscripcionid",
                principalTable: "inscripciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cursantes_alumnos_alumnoid",
                table: "cursantes",
                column: "alumnoid",
                principalTable: "alumnos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cursantes_materias_carreras_materiacarreraid",
                table: "cursantes",
                column: "materiacarreraid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_examenes_materias_carreras_materiacarreraid",
                table: "examenes",
                column: "materiacarreraid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_horarios_materias_carreras_materiacarreraid",
                table: "horarios",
                column: "materiacarreraid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_alumnos_alumnoid",
                table: "inscripciones",
                column: "alumnoid",
                principalTable: "alumnos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_sedes_carreras_sedecarreraid",
                table: "inscripciones",
                column: "sedecarreraid",
                principalTable: "sedes_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_materias_carreras_materias_materiaid",
                table: "materias_carreras",
                column: "materiaid",
                principalTable: "materias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_materias_carreras_personales_personalid",
                table: "materias_carreras",
                column: "personalid",
                principalTable: "personales",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_materias_carreras_sedes_carreras_sedecarreraid",
                table: "materias_carreras",
                column: "sedecarreraid",
                principalTable: "sedes_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_notas_examenes_examenid",
                table: "notas",
                column: "examenid",
                principalTable: "examenes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sedes_carreras_carreras_carreraid",
                table: "sedes_carreras",
                column: "carreraid",
                principalTable: "carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sedes_carreras_sedes_sedeid",
                table: "sedes_carreras",
                column: "sedeid",
                principalTable: "sedes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asistencias_clases_claseid",
                table: "asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_asistencias_cursantes_cursanteid",
                table: "asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_clases_materias_carreras_materiacarreraid1",
                table: "clases");

            migrationBuilder.DropForeignKey(
                name: "FK_clases_materias_carreras_materiacarreraidid",
                table: "clases");

            migrationBuilder.DropForeignKey(
                name: "FK_cooperadora_pagos_inscripciones_inscripcionid",
                table: "cooperadora_pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_cursantes_alumnos_alumnoid",
                table: "cursantes");

            migrationBuilder.DropForeignKey(
                name: "FK_cursantes_materias_carreras_materiacarreraid",
                table: "cursantes");

            migrationBuilder.DropForeignKey(
                name: "FK_examenes_materias_carreras_materiacarreraid",
                table: "examenes");

            migrationBuilder.DropForeignKey(
                name: "FK_horarios_materias_carreras_materiacarreraid",
                table: "horarios");

            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_alumnos_alumnoid",
                table: "inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_inscripciones_sedes_carreras_sedecarreraid",
                table: "inscripciones");

            migrationBuilder.DropForeignKey(
                name: "FK_materias_carreras_materias_materiaid",
                table: "materias_carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_materias_carreras_personales_personalid",
                table: "materias_carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_materias_carreras_sedes_carreras_sedecarreraid",
                table: "materias_carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_notas_examenes_examenid",
                table: "notas");

            migrationBuilder.DropForeignKey(
                name: "FK_sedes_carreras_carreras_carreraid",
                table: "sedes_carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_sedes_carreras_sedes_sedeid",
                table: "sedes_carreras");

            migrationBuilder.RenameColumn(
                name: "materiacarreraidid",
                table: "clases",
                newName: "materiacarreraid");

            migrationBuilder.RenameColumn(
                name: "materiacarreraid1",
                table: "clases",
                newName: "materiacarrera_idid");

            migrationBuilder.RenameIndex(
                name: "IX_clases_materiacarreraidid",
                table: "clases",
                newName: "IX_clases_materiacarreraid");

            migrationBuilder.RenameIndex(
                name: "IX_clases_materiacarreraid1",
                table: "clases",
                newName: "IX_clases_materiacarrera_idid");

            migrationBuilder.AlterColumn<int>(
                name: "sedeid",
                table: "sedes_carreras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "carreraid",
                table: "sedes_carreras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "carrera_id",
                table: "sedes_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sede_id",
                table: "sedes_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "examenid",
                table: "notas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "examen_id",
                table: "notas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "sedecarreraid",
                table: "materias_carreras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "personalid",
                table: "materias_carreras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "materiaid",
                table: "materias_carreras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "materia_id",
                table: "materias_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "personal_id",
                table: "materias_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sedecarrera_id",
                table: "materias_carreras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "sedecarreraid",
                table: "inscripciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "alumnoid",
                table: "inscripciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "alumno_id",
                table: "inscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sedecarrera_id",
                table: "inscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "materiacarreraid",
                table: "horarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "materiacarrera_id",
                table: "horarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "materiacarreraid",
                table: "examenes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "materiacarrera_id",
                table: "examenes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "materiacarreraid",
                table: "cursantes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "alumnoid",
                table: "cursantes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "alumno_id",
                table: "cursantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "materiacarrera_id",
                table: "cursantes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "inscripcionid",
                table: "cooperadora_pagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "inscripcion_id",
                table: "cooperadora_pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "cursanteid",
                table: "asistencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "claseid",
                table: "asistencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "clase_id",
                table: "asistencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cursante_id",
                table: "asistencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_asistencias_clases_claseid",
                table: "asistencias",
                column: "claseid",
                principalTable: "clases",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asistencias_cursantes_cursanteid",
                table: "asistencias",
                column: "cursanteid",
                principalTable: "cursantes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_clases_materias_carreras_materiacarrera_idid",
                table: "clases",
                column: "materiacarrera_idid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_clases_materias_carreras_materiacarreraid",
                table: "clases",
                column: "materiacarreraid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cooperadora_pagos_inscripciones_inscripcionid",
                table: "cooperadora_pagos",
                column: "inscripcionid",
                principalTable: "inscripciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cursantes_alumnos_alumnoid",
                table: "cursantes",
                column: "alumnoid",
                principalTable: "alumnos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cursantes_materias_carreras_materiacarreraid",
                table: "cursantes",
                column: "materiacarreraid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_examenes_materias_carreras_materiacarreraid",
                table: "examenes",
                column: "materiacarreraid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_horarios_materias_carreras_materiacarreraid",
                table: "horarios",
                column: "materiacarreraid",
                principalTable: "materias_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_alumnos_alumnoid",
                table: "inscripciones",
                column: "alumnoid",
                principalTable: "alumnos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_inscripciones_sedes_carreras_sedecarreraid",
                table: "inscripciones",
                column: "sedecarreraid",
                principalTable: "sedes_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_materias_carreras_materias_materiaid",
                table: "materias_carreras",
                column: "materiaid",
                principalTable: "materias",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_materias_carreras_personales_personalid",
                table: "materias_carreras",
                column: "personalid",
                principalTable: "personales",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_materias_carreras_sedes_carreras_sedecarreraid",
                table: "materias_carreras",
                column: "sedecarreraid",
                principalTable: "sedes_carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_notas_examenes_examenid",
                table: "notas",
                column: "examenid",
                principalTable: "examenes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sedes_carreras_carreras_carreraid",
                table: "sedes_carreras",
                column: "carreraid",
                principalTable: "carreras",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sedes_carreras_sedes_sedeid",
                table: "sedes_carreras",
                column: "sedeid",
                principalTable: "sedes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
