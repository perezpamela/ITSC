using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITSC.CORE
{
    public class MateriaCarrera
    {
        public int id { get; set; }
        [Required]
        public int ciclo_lectivo { get; set; }
        [Required]
        public int curso_anio { get; set; }
        public string curso_division { get; set; }
        [Required]
        public string es_regularizable { get; set; } //¿Debería ir en materia?
        public int status { get; set; }

        public SedeCarrera sedecarrera { get; set; }
        public int sedecarrera_id { get; set; }
        public Materia materia { get; set; }
        public int materia_id { get; set; }
        public Personal personal { get; set; }
        public int personal_id { get; set; }
    }
}
