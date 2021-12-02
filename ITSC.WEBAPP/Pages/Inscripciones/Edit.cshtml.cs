using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ITSC.CORE;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ITSC.WebApp.Pages.Inscripciones
{
    public class EditModel : MBase
    {
        [BindProperty(SupportsGet =true)]
        public IEnumerable<Alumno> alumnos{get; set;}
        public IEnumerable<ITSC.CORE.SedeCarrera> Sc { get; set; }
        public Carrera Objcarrera { get; set; }

        [BindProperty(SupportsGet = true)]
        public Inscripcion ins { get; set; }

        public IActionResult OnGet (int? inscripcionId)
        {
            alumnos = ABM_Alumno.Get("");
            Sc = ABMSedeCarrera.Get("");
            
            foreach(var x in Sc)
            {
                x.carrera = ABMCarrera.Get(x.carreraid);
                x.sede = ABMSede.Get(x.sedeid);
            }

            if (inscripcionId.HasValue)
            {
                ins = ABM_Inscripcion.get(inscripcionId.Value);
            }
            else
            {
                ins = new Inscripcion();
                //ins.Fecha de inscripcion
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ins = ABM_Inscripcion.Save(ins);
            TempData["mensaje"] = "se guardaron los cambios correctamente.";
            return RedirectToPage("./Detail", new { inscripcionId = ins.id }); 
        }

    }
}
