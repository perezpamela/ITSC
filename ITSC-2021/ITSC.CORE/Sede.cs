using System;
using System.Collections.Generic;
using System.Text;

namespace ITSC.CORE
{
    public class Sede
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string tel_caracteristica { get; set; }
        public string tel_nro { get; set; }
        public string email { get; set; }
        public string direccion_calle { get; set; }
        public string direccion_nro { get; set; }
        public string direccion_piso { get; set; }
        public string direccion_dpto { get; set; }
        public string direccion_barrio { get; set; }
        public string direccion_localidad { get; set; }
        public string dia_desde { get; set; }
        public string dia_hasta { get; set; }
        public string horario_desde { get; set; }
        public string horario_hasta { get; set; }
        public int status { get; set; }

        //Relación con Carrera/s
        //public List<Carrera> Carreras { get; set; }

    }
}
