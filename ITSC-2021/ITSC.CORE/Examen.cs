using System;
using System.Collections.Generic;
using System.Text;

namespace ITSC.CORE
{
    public class Examen
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public int inst_ev_nro { get; set; }
        public int etapa_nro { get; set; }
        public string tipo { get; set; } 
        public string status { get; set; }

        public MateriaCarrera materiacarrera { get; set; }
        public int materiacarrera_id { get; set; }

    }
}
