using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITSC.CORE
{
    public class Clase
    {
        public int id { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public string descripcion_tema { get; set; }
        public int status { get; set; }

        public MateriaCarrera materiacarrera { get; set; }
        public MateriaCarrera materiacarrera_id { get; set; }
    }
}
