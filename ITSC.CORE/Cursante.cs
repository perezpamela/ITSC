using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITSC.CORE
{
    public class Cursante
    {
        public int id { get; set; }
        [Required, DefaultValue("REGULAR")]
        public string cursada_estado { get; set; }
        public DateTime regularidad_end_date { get; set; }
        public string observaciones { get; set; }
        public int status { get; set; }

        public MateriaCarrera materiacarrera { get; set; }
        public int materiacarreraid { get; set; }
        public Alumno alumno { get; set; }
        public int alumnoid { get; set; }
    }
}
