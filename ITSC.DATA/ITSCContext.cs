using ITSC.CORE;
using Microsoft.EntityFrameworkCore;
using System;

namespace ITSC.DATA
{
    public class ITSCContext : DbContext
    {
        public DbSet<Alumno> alumnos { get; set; }
        public DbSet<Asistencia> asistencias { get; set; }
        public DbSet<Carrera> carreras { get; set; }
        public DbSet<Clase> clases { get; set; }
        public DbSet<CooperadoraPago> cooperadora_pagos { get; set; }
        public DbSet<Cursante> cursantes { get; set; }
        public DbSet<Examen> examenes { get; set; }
        public DbSet<Horario> horarios { get; set; }
        public DbSet<Inscripcion> inscripciones { get; set; }
        public DbSet<Materia> materias { get; set; }
        public DbSet<MateriaCarrera> materias_carreras { get; set; }
        public DbSet<Nota> notas { get; set; }
        public DbSet<Personal> personales { get; set; }
        public DbSet<Sede> sedes { get; set; }
        public DbSet<SedeCarrera> sedes_carreras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OpsBuilder)
        {
            OpsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog = ITSC_DB_v3; Integrated Security = True");
        }

    }
}
