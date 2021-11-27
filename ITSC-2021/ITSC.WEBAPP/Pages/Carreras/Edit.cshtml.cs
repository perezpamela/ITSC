using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.CORE;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITSC.WebApp.Pages.Carreras
{
    public class EditModel : MBase//PageModel
    {
        [BindProperty]
        public Carrera c { get; set; }
        public IActionResult OnGet(int? carreraId)
        {
            if (carreraId.HasValue)
            {
                c = ABMCarrera.Get(carreraId.Value);
            }
            else {
                c = new Carrera();
                c.plan_start_date = DateTime.Now;
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            } 
            c = ABMCarrera.Save(c);
            TempData["mensaje"] = "Se guardaron los cambios correctamente.";
            return RedirectToPage("./Detail", new { carreraId = c.id });
            
        }
    }
}
