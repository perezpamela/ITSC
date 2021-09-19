using System;
using System.Collections.Generic;
using System.Text;

namespace ITSC.CORE
{
    public class Personal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int dni { get; set; }
        public string usuario_tipo { get; set; }
        public string usuario_password { get; set; }
        public string email { get; set; }
        public int tel_caracteristica { get; set; }
        public int tel_nro { get; set; }
        public int status { get; set; }
    }
}
