using System;
using System.ComponentModel.DataAnnotations;

namespace ITSC.CORE
{
    public class Alumno
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Debe ingresar el nombre."), MaxLength(100)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el apellido."), MaxLength(100)]
        public string apellido { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaNacimiento { get; set; }
        [Range(1000000, int.MaxValue, ErrorMessage ="Debe ingresar un DNI.")]
        public int dni { get; set; } 
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage ="La contraseña debe tener al menos 8 caracteres.", MinimumLength =8)]
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


