using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ITSC.CORE;
using ITSC.DATA;

namespace ITSC.WebApp.Pages.Inscripciones
{
    public class lista_alumnosModel : PageModel
    {
        //Alumno
        public IEnumerable<Alumno> OBJalumnos { get; set; }
        [BindProperty(SupportsGet = true)]

        //Carrera
        public IEnumerable<Carrera> OBJcarrera { get; set; }
        [BindProperty(SupportsGet = true)]

        public string strBusqueda { get; set; }
        [TempData]
        public string Mensaje { get; set; }
        public void OnGet()
        {
            OBJalumnos = ABM_Alumno.Get(strBusqueda);
        }
    }
}
