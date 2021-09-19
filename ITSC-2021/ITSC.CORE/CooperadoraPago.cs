using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITSC.CORE
{
    public class CooperadoraPago
    {
        public int id { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public float monto { get; set; }
        [Required]
        public float saldo { get; set; } // Calculado
        public int status { get; set; }

        public Inscripcion inscripcion { get; set; }
        public int inscripcion_id { get; set; }
    }
}
