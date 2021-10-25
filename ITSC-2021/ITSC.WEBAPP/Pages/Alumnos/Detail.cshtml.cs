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
    public class DetailModel : PageModel
    {
        public Alumno alumno { get; set; }
        [TempData]
        public string Mensaje { get; set; }
        public void OnGet(int alumnoId)
        {
            alumno = ABM_Alumno.Get(alumnoId);
        }
    }
}
