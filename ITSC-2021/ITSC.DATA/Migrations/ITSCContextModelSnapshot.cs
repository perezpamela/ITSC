﻿// <auto-generated />
using System;
using ITSC.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITSC.DATA.Migrations
{
    [DbContext(typeof(ITSCContext))]
    partial class ITSCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarreraSede", b =>
                {
                    b.Property<int>("Carrerasid")
                        .HasColumnType("int");

                    b.Property<int>("Sedesid")
                        .HasColumnType("int");

                    b.HasKey("Carrerasid", "Sedesid");

                    b.HasIndex("Sedesid");

                    b.ToTable("CarreraSede");
                });

            modelBuilder.Entity("ITSC.CORE.Alumno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("contacto_emergencia_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_barrio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_dpto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_localidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_nro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_piso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dni")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emergencia_tel_caracteristica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emergencia_tel_nro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("telefono_caracteristica")
                        .HasColumnType("int");

                    b.Property<int>("telefono_nro")
                        .HasColumnType("int");

                    b.Property<string>("usuario_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario_tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("alumnos");
                });

            modelBuilder.Entity("ITSC.CORE.Asistencia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("asisitio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("clase_id")
                        .HasColumnType("int");

                    b.Property<int?>("claseid")
                        .HasColumnType("int");

                    b.Property<int>("cursante_id")
                        .HasColumnType("int");

                    b.Property<int?>("cursanteid")
                        .HasColumnType("int");

                    b.Property<string>("justifico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("claseid");

                    b.HasIndex("cursanteid");

                    b.ToTable("asistencias");
                });

            modelBuilder.Entity("ITSC.CORE.Carrera", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("plan_end_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("plan_start_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("carreras");
                });

            modelBuilder.Entity("ITSC.CORE.Clase", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion_tema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("materiacarrera_idid")
                        .HasColumnType("int");

                    b.Property<int?>("materiacarreraid")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("materiacarrera_idid");

                    b.HasIndex("materiacarreraid");

                    b.ToTable("clases");
                });

            modelBuilder.Entity("ITSC.CORE.CooperadoraPago", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("inscripcion_id")
                        .HasColumnType("int");

                    b.Property<int?>("inscripcionid")
                        .HasColumnType("int");

                    b.Property<float>("monto")
                        .HasColumnType("real");

                    b.Property<float>("saldo")
                        .HasColumnType("real");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("inscripcionid");

                    b.ToTable("cooperadora_pagos");
                });

            modelBuilder.Entity("ITSC.CORE.Cursante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("alumno_id")
                        .HasColumnType("int");

                    b.Property<int?>("alumnoid")
                        .HasColumnType("int");

                    b.Property<string>("cursada_estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("materiacarrera_id")
                        .HasColumnType("int");

                    b.Property<int?>("materiacarreraid")
                        .HasColumnType("int");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("regularidad_end_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alumnoid");

                    b.HasIndex("materiacarreraid");

                    b.ToTable("cursantes");
                });

            modelBuilder.Entity("ITSC.CORE.Examen", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("etapa_nro")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("inst_ev_nro")
                        .HasColumnType("int");

                    b.Property<int>("materiacarrera_id")
                        .HasColumnType("int");

                    b.Property<int?>("materiacarreraid")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("materiacarreraid");

                    b.ToTable("examenes");
                });

            modelBuilder.Entity("ITSC.CORE.Horario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hora_fin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hora_inicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("materiacarrera_id")
                        .HasColumnType("int");

                    b.Property<int?>("materiacarreraid")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("materiacarreraid");

                    b.ToTable("horarios");
                });

            modelBuilder.Entity("ITSC.CORE.Inscripcion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("alumno_id")
                        .HasColumnType("int");

                    b.Property<int?>("alumnoid")
                        .HasColumnType("int");

                    b.Property<float>("cooperadora_saldo")
                        .HasColumnType("real");

                    b.Property<float>("cooperadora_total")
                        .HasColumnType("real");

                    b.Property<int>("doc_acta_nac")
                        .HasColumnType("int");

                    b.Property<int>("doc_analitico_sec")
                        .HasColumnType("int");

                    b.Property<int>("doc_dni")
                        .HasColumnType("int");

                    b.Property<int>("doc_titulo_sec")
                        .HasColumnType("int");

                    b.Property<int>("examen25")
                        .HasColumnType("int");

                    b.Property<int>("sedecarrera_id")
                        .HasColumnType("int");

                    b.Property<int?>("sedecarreraid")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alumnoid");

                    b.HasIndex("sedecarreraid");

                    b.ToTable("inscripciones");
                });

            modelBuilder.Entity("ITSC.CORE.Materia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("materias");
                });

            modelBuilder.Entity("ITSC.CORE.MateriaCarrera", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ciclo_lectivo")
                        .HasColumnType("int");

                    b.Property<int>("curso_anio")
                        .HasColumnType("int");

                    b.Property<string>("curso_division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("es_regularizable")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("materia_id")
                        .HasColumnType("int");

                    b.Property<int?>("materiaid")
                        .HasColumnType("int");

                    b.Property<int>("personal_id")
                        .HasColumnType("int");

                    b.Property<int?>("personalid")
                        .HasColumnType("int");

                    b.Property<int>("sedecarrera_id")
                        .HasColumnType("int");

                    b.Property<int?>("sedecarreraid")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("materiaid");

                    b.HasIndex("personalid");

                    b.HasIndex("sedecarreraid");

                    b.ToTable("materias_carreras");
                });

            modelBuilder.Entity("ITSC.CORE.Nota", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("examen_id")
                        .HasColumnType("int");

                    b.Property<int?>("examenid")
                        .HasColumnType("int");

                    b.Property<float>("nota")
                        .HasColumnType("real");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("examenid");

                    b.ToTable("notas");
                });

            modelBuilder.Entity("ITSC.CORE.Personal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("tel_caracteristica")
                        .HasColumnType("int");

                    b.Property<int>("tel_nro")
                        .HasColumnType("int");

                    b.Property<string>("usuario_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario_tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("personales");
                });

            modelBuilder.Entity("ITSC.CORE.Sede", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dia_desde")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dia_hasta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_barrio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_dpto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_localidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_nro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion_piso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horario_desde")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horario_hasta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("tel_caracteristica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tel_nro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("sedes");
                });

            modelBuilder.Entity("ITSC.CORE.SedeCarrera", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("carrera_id")
                        .HasColumnType("int");

                    b.Property<int?>("carreraid")
                        .HasColumnType("int");

                    b.Property<int>("sede_id")
                        .HasColumnType("int");

                    b.Property<int?>("sedeid")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("turno")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("carreraid");

                    b.HasIndex("sedeid");

                    b.ToTable("sedes_carreras");
                });

            modelBuilder.Entity("CarreraSede", b =>
                {
                    b.HasOne("ITSC.CORE.Carrera", null)
                        .WithMany()
                        .HasForeignKey("Carrerasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITSC.CORE.Sede", null)
                        .WithMany()
                        .HasForeignKey("Sedesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ITSC.CORE.Asistencia", b =>
                {
                    b.HasOne("ITSC.CORE.Clase", "clase")
                        .WithMany()
                        .HasForeignKey("claseid");

                    b.HasOne("ITSC.CORE.Cursante", "cursante")
                        .WithMany()
                        .HasForeignKey("cursanteid");

                    b.Navigation("clase");

                    b.Navigation("cursante");
                });

            modelBuilder.Entity("ITSC.CORE.Clase", b =>
                {
                    b.HasOne("ITSC.CORE.MateriaCarrera", "materiacarrera_id")
                        .WithMany()
                        .HasForeignKey("materiacarrera_idid");

                    b.HasOne("ITSC.CORE.MateriaCarrera", "materiacarrera")
                        .WithMany()
                        .HasForeignKey("materiacarreraid");

                    b.Navigation("materiacarrera");

                    b.Navigation("materiacarrera_id");
                });

            modelBuilder.Entity("ITSC.CORE.CooperadoraPago", b =>
                {
                    b.HasOne("ITSC.CORE.Inscripcion", "inscripcion")
                        .WithMany()
                        .HasForeignKey("inscripcionid");

                    b.Navigation("inscripcion");
                });

            modelBuilder.Entity("ITSC.CORE.Cursante", b =>
                {
                    b.HasOne("ITSC.CORE.Alumno", "alumno")
                        .WithMany()
                        .HasForeignKey("alumnoid");

                    b.HasOne("ITSC.CORE.MateriaCarrera", "materiacarrera")
                        .WithMany()
                        .HasForeignKey("materiacarreraid");

                    b.Navigation("alumno");

                    b.Navigation("materiacarrera");
                });

            modelBuilder.Entity("ITSC.CORE.Examen", b =>
                {
                    b.HasOne("ITSC.CORE.MateriaCarrera", "materiacarrera")
                        .WithMany()
                        .HasForeignKey("materiacarreraid");

                    b.Navigation("materiacarrera");
                });

            modelBuilder.Entity("ITSC.CORE.Horario", b =>
                {
                    b.HasOne("ITSC.CORE.MateriaCarrera", "materiacarrera")
                        .WithMany()
                        .HasForeignKey("materiacarreraid");

                    b.Navigation("materiacarrera");
                });

            modelBuilder.Entity("ITSC.CORE.Inscripcion", b =>
                {
                    b.HasOne("ITSC.CORE.Alumno", "alumno")
                        .WithMany()
                        .HasForeignKey("alumnoid");

                    b.HasOne("ITSC.CORE.SedeCarrera", "sedecarrera")
                        .WithMany()
                        .HasForeignKey("sedecarreraid");

                    b.Navigation("alumno");

                    b.Navigation("sedecarrera");
                });

            modelBuilder.Entity("ITSC.CORE.MateriaCarrera", b =>
                {
                    b.HasOne("ITSC.CORE.Materia", "materia")
                        .WithMany()
                        .HasForeignKey("materiaid");

                    b.HasOne("ITSC.CORE.Personal", "personal")
                        .WithMany()
                        .HasForeignKey("personalid");

                    b.HasOne("ITSC.CORE.SedeCarrera", "sedecarrera")
                        .WithMany()
                        .HasForeignKey("sedecarreraid");

                    b.Navigation("materia");

                    b.Navigation("personal");

                    b.Navigation("sedecarrera");
                });

            modelBuilder.Entity("ITSC.CORE.Nota", b =>
                {
                    b.HasOne("ITSC.CORE.Examen", "examen")
                        .WithMany()
                        .HasForeignKey("examenid");

                    b.Navigation("examen");
                });

            modelBuilder.Entity("ITSC.CORE.SedeCarrera", b =>
                {
                    b.HasOne("ITSC.CORE.Carrera", "carrera")
                        .WithMany()
                        .HasForeignKey("carreraid");

                    b.HasOne("ITSC.CORE.Sede", "sede")
                        .WithMany()
                        .HasForeignKey("sedeid");

                    b.Navigation("carrera");

                    b.Navigation("sede");
                });
#pragma warning restore 612, 618
        }
    }
}
