using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITSC.CORE
{
    public class Carrera
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Debe ingresar una descripción de la carrea.")]
        public string descripcion { get; set; }
        [Required(ErrorMessage ="Debe ingresar el plan de la carrera")]
        public string plan { get; set; }
        [Required(ErrorMessage = "Debe ingresar una fecha de inicio para el plan de la carrera.")]
        [DataType(DataType.Date)]
        public DateTime plan_start_date { get; set; }
        [DataType(DataType.Date)]
        public DateTime plan_end_date { get; set; }
        public int status { get; set; }


        //Relación con Sede/s
        //public List<Sede> Sedes { get; set; } 
    }
}
