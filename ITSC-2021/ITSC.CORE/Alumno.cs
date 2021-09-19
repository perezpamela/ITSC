using System;
using System.ComponentModel.DataAnnotations;

namespace ITSC.CORE
{
    public class Alumno
    {
        public int id { get; set; }
        [Required, MaxLength(100)]
        public string nombre { get; set; }
        [Required, MaxLength(100)]
        public string apellido { get; set; }
        public  DateTime fechaNacimiento { get; set; }
        [Required, MaxLength(10)]
        public int dni { get; set; } 
        public string usuario_password { get; set; }
        public string usuario_tipo { get; set; }
        public int telefono_caracteristica { get; set; }
        public int telefono_nro { get; set; }
        public string direccion_calle { get; set; }
        public string direccion_nro { get; set; }
        public string direccion_piso { get; set; }
        public string direccion_dpto { get; set; }
        public string direccion_barrio { get; set; }
        public string direccion_localidad { get; set; }
        public string email { get; set; }
        public string contacto_emergencia_nombre { get; set; }
        public string emergencia_tel_caracteristica { get; set; }
        public string emergencia_tel_nro { get; set; }
        public int status { get; set; }
    }
}


