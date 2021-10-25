using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.CORE;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ITSC.WebApp.Pages.Alumnos
{
    public class EditModel : PageModel
    {
        //public List<SelectListItem> localidades { get; set; }
        //public string localidad = "";


        [BindProperty]
        public Alumno alumno { get; set; }
        
        public IActionResult OnGet(int? alumnoId)
        {
            //localidades = new List<SelectListItem>();

            //foreach(var n in ABM_Alumno.GetNombres())
            //{
            //    localidades.Add(new SelectListItem { Text = n, Value = n });

            //}

            if (alumnoId.HasValue)
            {
                alumno = ABM_Alumno.Get(alumnoId.Value);

            } else
            {
                alumno = new Alumno();
                //Acá podrían ir algunos defaults ¿?
            }

            return Page();
        } //fin del OnGet

        public IActionResult OnPost()
        {

            //para que se llene de nuevo el combo box hay que llenarlo en el get y el post
            //ModelState[alumno.nombre].AttemptedValue  ---ejemplos utiles
           // ModelState[alumno.nombre].ValidationState  -----------------
            if (!ModelState.IsValid)
            {
                return Page();
            }
            alumno = ABM_Alumno.Save(alumno);
            TempData["Mensaje"] = "Se guardaron los cambios correctamente.";
            return RedirectToPage("./Detail", new { alumnoId = alumno.id });


        }//fin del OnPost

    }
}
