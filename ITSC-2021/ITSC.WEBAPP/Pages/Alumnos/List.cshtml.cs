using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.CORE;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITSC.WebApp.Pages.Alumnos
{
    public class ListModel : MBase//PageModel
    {
        public IEnumerable<Alumno> alumnos { get; set; }
        [BindProperty(SupportsGet =true)]
        public string strBusqueda { get; set; }
        [TempData]
        public string Mensaje { get; set; }

        
        public void OnGet()
        {
            
            alumnos = ABM_Alumno.Get(strBusqueda);
        }
    }
}
