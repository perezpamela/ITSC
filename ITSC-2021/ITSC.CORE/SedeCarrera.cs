using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITSC.CORE
{
    public class SedeCarrera
    {
        //En la lógica no se debe repetir la misma carrera, en la misma sede y el mismo turno
        public int id { get; set; }
        [Required]
        public int turno { get; set; }
        public int status { get; set; }


        public Sede sede { get; set; }
        public int sede_id { get; set; }

        public Carrera carrera { get; set; }
        public int carrera_id { get; set; }
    }
}
