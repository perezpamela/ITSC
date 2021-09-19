using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITSC.CORE
{
    public class Carrera
    {
        public int id { get; set; }
        [Required]
        public string descripcion { get; set; }
        [Required]
        public string plan { get; set; }
        [Required]
        public DateTime plan_start_date { get; set; }
        public DateTime plan_end_date { get; set; }
        public int status { get; set; }

        //Relación con Sede/s
        public List<Sede> Sedes { get; set; } 
    }
}
