using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ITSC.DATA;
using ITSC.CORE;

namespace ITSC.WebApp.Pages.Sedes
{
    public class DetailModel : MBase//PageModel
    {
        public Sede sede { get; set; }
        //public string descripcion { get; set; }
        //public string tel_caracteristica { get; set; }
        //public string tel_nro { get; set; }
        //public string email { get; set; }
        //public string direccion_calle { get; set; }
        //public string direccion_nro { get; set; }
        //public string direccion_piso { get; set; }
        //public string direccion_dpto { get; set; }
        //public string direccion_barrio { get; set; }
        //public string direccion_localidad { get; set; }
        //public string dia_desde { get; set; }
        //public string dia_hasta { get; set; }
        //public string horario_desde { get; set; }
        //public string horario_hasta { get; set; }
        //public int status { get; set; }
        [TempData]
        public string mensaje { get; set; }
        public void OnGet(int sedeId)
        {
            sede = ABMSede.Get(sedeId);
            //descripcion = sede.descripcion;

            //tel_caracteristica = sede.tel_caracteristica;
            //tel_nro = sede.tel_nro;
            //email = sede.email;

            //direccion_calle = sede.direccion_calle;
            //direccion_nro = sede.direccion_nro;
            //direccion_piso = sede.direccion_piso;
            //direccion_dpto = sede.direccion_dpto;
            //direccion_barrio = sede.direccion_barrio;
            //direccion_localidad = sede.direccion_localidad;

            //dia_desde = sede.dia_desde.ToString("dd/mm/yyyy");
            //dia_hasta = sede.dia_hasta.ToString("dd/mm/yyyy");

            //horario_desde = sede.horario_desde;
            //horario_hasta = sede.horario_hasta;

            //status = sede.status;

        }
    }
}
