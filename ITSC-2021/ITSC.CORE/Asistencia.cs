using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITSC.CORE
{
    public class Asistencia
    {
        public int id { get; set; }
        [Required, DefaultValue('S')]
        public string asisitio { get; set; }
        public string justifico { get; set; }
        public string observaciones { get; set; }
        public int status { get; set; }

        public Clase clase { get; set; }
        public int clase_id { get; set; }
        public Cursante cursante { get; set; }
        public int cursante_id { get; set; } 
    }
}
