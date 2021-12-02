using System;
using System.Collections.Generic;
using System.Text;

namespace ITSC.CORE
{
    public class Nota
    {
        public int id { get; set; }
        public float nota { get; set; }
        public string observaciones { get; set; }
        public int status { get; set; }

        public Examen examen { get; set; }
        public int examenid { get; set; }
    }
}
