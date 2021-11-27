using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ITSC.CORE;

namespace ITSC.WebApp.Pages.SedeCarrera
{
    public class ListModel : MBase//PageModel
    {
        [TempData]
        public string Mensaje { get; set; }
        public string strBusqueda { get; set; }
        public IEnumerable<ITSC.CORE.SedeCarrera> sc { get; set; }
        public List<Carrera> c { get; set; }
        public List<Sede> s { get; set; }

        public void OnGet(string strBusqueda)
        {
            sc = ABMSedeCarrera.Get(strBusqueda);

            foreach(var sc in sc)
            {
                sc.carrera = new Carrera();
                sc.sede = new Sede();
                sc.carrera = ABMCarrera.Get(sc.carrera_id);
                sc.sede = ABMSede.Get(sc.sede_id);
            }

        }
    }
}
