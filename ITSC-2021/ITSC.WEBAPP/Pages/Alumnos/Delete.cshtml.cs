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
    public class DeleteModel : MBase//PageModel
    {
        
        
        public Alumno alumno{ get; set; }
        
        public IActionResult OnGet(int alumnoId)
        {
            alumno = ABM_Alumno.Get(alumnoId);
            return Page();
        }
        public IActionResult OnPost(int alumnoId)
        {
            alumno = ABM_Alumno.Get(alumnoId);
            bool flag = ABM_Alumno.Delete(alumno.id);
            if (flag)
            {
                TempData["Mensaje"] = $"Se dio de baja al alumno {alumno.apellido}, {alumno.nombre}.";
            } else
            {
                TempData["Mensaje"] = $"Error al dar de baja al alumno {alumno.apellido}, {alumno.nombre}.";

            }
            return RedirectToPage("./List");
        }
    }
}
