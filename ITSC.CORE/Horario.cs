using System;
using System.Collections.Generic;
using System.Text;

namespace ITSC.CORE
{
    public class Horario
    {
        public int id { get; set; }
        public string hora_inicio { get; set; }
        public string hora_fin { get; set; }
        public string dia { get; set; }
        public int status { get; set; }

        public MateriaCarrera materiacarrera { get; set; }
        public int materiacarreraid { get; set; }
    }
}
