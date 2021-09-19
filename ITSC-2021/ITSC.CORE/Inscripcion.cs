using System;
using System.Collections.Generic;
using System.Text;

namespace ITSC.CORE
{
    public class Inscripcion
    {
        public int id { get; set; }
        public int doc_dni { get; set; }
        public int doc_acta_nac { get; set; }
        public int doc_titulo_sec { get; set; }
        public int doc_analitico_sec { get; set; }
        public int examen25 { get; set; }
        public float cooperadora_total { get; set; }
        public float cooperadora_saldo { get; set; }
        public int status { get; set; }

        public Alumno alumno { get; set; }
        public int alumno_id { get; set; }

        public SedeCarrera sedecarrera { get; set; }
        public int sedecarrera_id { get; set; }

    }
}
