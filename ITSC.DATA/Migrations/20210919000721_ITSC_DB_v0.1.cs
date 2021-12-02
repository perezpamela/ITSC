using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITSC.DATA.Migrations
{
    public partial class ITSC_DB_v01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alumnos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dni = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    usuario_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usuario_tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono_caracteristica = table.Column<int>(type: "int", nullable: false),
                    telefono_nro = table.Column<int>(type: "int", nullable: false),
                    direccion_calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_piso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_dpto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_localidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contacto_emergencia_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emergencia_tel_caracteristica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emergencia_tel_nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alumnos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "carreras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plan_start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    plan_end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carreras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "materias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false),
                    usuario_tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usuario_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel_caracteristica = table.Column<int>(type: "int", nullable: false),
                    tel_nro = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personales", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sedes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel_caracteristica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel_nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_calle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_piso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_dpto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_localidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dia_desde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dia_hasta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horario_desde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horario_hasta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sedes", x => x.id);
                });

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

            migrationBuilder.CreateTable(
                name: "sedes_carreras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    turno = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    sedeid = table.Column<int>(type: "int", nullable: true),
                    sede_id = table.Column<int>(type: "int", nullable: false),
                    carreraid = table.Column<int>(type: "int", nullable: true),
                    carrera_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sedes_carreras", x => x.id);
                    table.ForeignKey(
                        name: "FK_sedes_carreras_carreras_carreraid",
                        column: x => x.carreraid,
                        principalTable: "carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sedes_carreras_sedes_sedeid",
                        column: x => x.sedeid,
                        principalTable: "sedes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "inscripciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doc_dni = table.Column<int>(type: "int", nullable: false),
                    doc_acta_nac = table.Column<int>(type: "int", nullable: false),
                    doc_titulo_sec = table.Column<int>(type: "int", nullable: false),
                    doc_analitico_sec = table.Column<int>(type: "int", nullable: false),
                    examen25 = table.Column<int>(type: "int", nullable: false),
                    cooperadora_total = table.Column<float>(type: "real", nullable: false),
                    cooperadora_saldo = table.Column<float>(type: "real", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    alumnoid = table.Column<int>(type: "int", nullable: true),
                    alumno_id = table.Column<int>(type: "int", nullable: false),
                    sedecarreraid = table.Column<int>(type: "int", nullable: true),
                    sedecarrera_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscripciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_inscripciones_alumnos_alumnoid",
                        column: x => x.alumnoid,
                        principalTable: "alumnos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_inscripciones_sedes_carreras_sedecarreraid",
                        column: x => x.sedecarreraid,
                        principalTable: "sedes_carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "materias_carreras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ciclo_lectivo = table.Column<int>(type: "int", nullable: false),
                    curso_anio = table.Column<int>(type: "int", nullable: false),
                    curso_division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    es_regularizable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    sedecarreraid = table.Column<int>(type: "int", nullable: true),
                    sedecarrera_id = table.Column<int>(type: "int", nullable: false),
                    materiaid = table.Column<int>(type: "int", nullable: true),
                    materia_id = table.Column<int>(type: "int", nullable: false),
                    personalid = table.Column<int>(type: "int", nullable: true),
                    personal_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias_carreras", x => x.id);
                    table.ForeignKey(
                        name: "FK_materias_carreras_materias_materiaid",
                        column: x => x.materiaid,
                        principalTable: "materias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_materias_carreras_personales_personalid",
                        column: x => x.personalid,
                        principalTable: "personales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_materias_carreras_sedes_carreras_sedecarreraid",
                        column: x => x.sedecarreraid,
                        principalTable: "sedes_carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cooperadora_pagos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    monto = table.Column<float>(type: "real", nullable: false),
                    saldo = table.Column<float>(type: "real", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    inscripcionid = table.Column<int>(type: "int", nullable: true),
                    inscripcion_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cooperadora_pagos", x => x.id);
                    table.ForeignKey(
                        name: "FK_cooperadora_pagos_inscripciones_inscripcionid",
                        column: x => x.inscripcionid,
                        principalTable: "inscripciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "clases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    descripcion_tema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    materiacarreraid = table.Column<int>(type: "int", nullable: true),
                    materiacarrera_idid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clases", x => x.id);
                    table.ForeignKey(
                        name: "FK_clases_materias_carreras_materiacarrera_idid",
                        column: x => x.materiacarrera_idid,
                        principalTable: "materias_carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_clases_materias_carreras_materiacarreraid",
                        column: x => x.materiacarreraid,
                        principalTable: "materias_carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cursantes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cursada_estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regularidad_end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    materiacarreraid = table.Column<int>(type: "int", nullable: true),
                    materiacarrera_id = table.Column<int>(type: "int", nullable: false),
                    alumnoid = table.Column<int>(type: "int", nullable: true),
                    alumno_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursantes", x => x.id);
                    table.ForeignKey(
                        name: "FK_cursantes_alumnos_alumnoid",
                        column: x => x.alumnoid,
                        principalTable: "alumnos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cursantes_materias_carreras_materiacarreraid",
                        column: x => x.materiacarreraid,
                        principalTable: "materias_carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "examenes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inst_ev_nro = table.Column<int>(type: "int", nullable: false),
                    etapa_nro = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    materiacarreraid = table.Column<int>(type: "int", nullable: true),
                    materiacarrera_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examenes", x => x.id);
                    table.ForeignKey(
                        name: "FK_examenes_materias_carreras_materiacarreraid",
                        column: x => x.materiacarreraid,
                        principalTable: "materias_carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "horarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hora_inicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hora_fin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    materiacarreraid = table.Column<int>(type: "int", nullable: true),
                    materiacarrera_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_horarios_materias_carreras_materiacarreraid",
                        column: x => x.materiacarreraid,
                        principalTable: "materias_carreras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asistencias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asisitio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    justifico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    claseid = table.Column<int>(type: "int", nullable: true),
                    clase_id = table.Column<int>(type: "int", nullable: false),
                    cursanteid = table.Column<int>(type: "int", nullable: true),
                    cursante_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asistencias", x => x.id);
                    table.ForeignKey(
                        name: "FK_asistencias_clases_claseid",
                        column: x => x.claseid,
                        principalTable: "clases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asistencias_cursantes_cursanteid",
                        column: x => x.cursanteid,
                        principalTable: "cursantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "notas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nota = table.Column<float>(type: "real", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    examenid = table.Column<int>(type: "int", nullable: true),
                    examen_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notas", x => x.id);
                    table.ForeignKey(
                        name: "FK_notas_examenes_examenid",
                        column: x => x.examenid,
                        principalTable: "examenes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_asistencias_claseid",
                table: "asistencias",
                column: "claseid");

            migrationBuilder.CreateIndex(
                name: "IX_asistencias_cursanteid",
                table: "asistencias",
                column: "cursanteid");

            migrationBuilder.CreateIndex(
                name: "IX_CarreraSede_Sedesid",
                table: "CarreraSede",
                column: "Sedesid");

            migrationBuilder.CreateIndex(
                name: "IX_clases_materiacarrera_idid",
                table: "clases",
                column: "materiacarrera_idid");

            migrationBuilder.CreateIndex(
                name: "IX_clases_materiacarreraid",
                table: "clases",
                column: "materiacarreraid");

            migrationBuilder.CreateIndex(
                name: "IX_cooperadora_pagos_inscripcionid",
                table: "cooperadora_pagos",
                column: "inscripcionid");

            migrationBuilder.CreateIndex(
                name: "IX_cursantes_alumnoid",
                table: "cursantes",
                column: "alumnoid");

            migrationBuilder.CreateIndex(
                name: "IX_cursantes_materiacarreraid",
                table: "cursantes",
                column: "materiacarreraid");

            migrationBuilder.CreateIndex(
                name: "IX_examenes_materiacarreraid",
                table: "examenes",
                column: "materiacarreraid");

            migrationBuilder.CreateIndex(
                name: "IX_horarios_materiacarreraid",
                table: "horarios",
                column: "materiacarreraid");

            migrationBuilder.CreateIndex(
                name: "IX_inscripciones_alumnoid",
                table: "inscripciones",
                column: "alumnoid");

            migrationBuilder.CreateIndex(
                name: "IX_inscripciones_sedecarreraid",
                table: "inscripciones",
                column: "sedecarreraid");

            migrationBuilder.CreateIndex(
                name: "IX_materias_carreras_materiaid",
                table: "materias_carreras",
                column: "materiaid");

            migrationBuilder.CreateIndex(
                name: "IX_materias_carreras_personalid",
                table: "materias_carreras",
                column: "personalid");

            migrationBuilder.CreateIndex(
                name: "IX_materias_carreras_sedecarreraid",
                table: "materias_carreras",
                column: "sedecarreraid");

            migrationBuilder.CreateIndex(
                name: "IX_notas_examenid",
                table: "notas",
                column: "examenid");

            migrationBuilder.CreateIndex(
                name: "IX_sedes_carreras_carreraid",
                table: "sedes_carreras",
                column: "carreraid");

            migrationBuilder.CreateIndex(
                name: "IX_sedes_carreras_sedeid",
                table: "sedes_carreras",
                column: "sedeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asistencias");

            migrationBuilder.DropTable(
                name: "CarreraSede");

            migrationBuilder.DropTable(
                name: "cooperadora_pagos");

            migrationBuilder.DropTable(
                name: "horarios");

            migrationBuilder.DropTable(
                name: "notas");

            migrationBuilder.DropTable(
                name: "clases");

            migrationBuilder.DropTable(
                name: "cursantes");

            migrationBuilder.DropTable(
                name: "inscripciones");

            migrationBuilder.DropTable(
                name: "examenes");

            migrationBuilder.DropTable(
                name: "alumnos");

            migrationBuilder.DropTable(
                name: "materias_carreras");

            migrationBuilder.DropTable(
                name: "materias");

            migrationBuilder.DropTable(
                name: "personales");

            migrationBuilder.DropTable(
                name: "sedes_carreras");

            migrationBuilder.DropTable(
                name: "carreras");

            migrationBuilder.DropTable(
                name: "sedes");
        }
    }
}
