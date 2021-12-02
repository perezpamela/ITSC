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
    public class ListModel : MBase
    {
        [TempData]
        public string mensaje { get; set; }
        public IEnumerable<Inscripcion> ins { get; set; }

        public void OnGet()
        {
            ins = ABM_Inscripcion.Get();
            foreach(var x in ins)
            {
                x.sedecarrera = ABMSedeCarrera.Get(x.sedecarreraid);
                x.alumno = ABM_Alumno.Get(x.alumnoid);
            }
        }
    }
}
