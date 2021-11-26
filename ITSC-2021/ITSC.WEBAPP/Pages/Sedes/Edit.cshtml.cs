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
    public class EditModel : MBase//PageModel
    {
        [BindProperty]

        public Sede S { get; set; }

        public IActionResult OnGet(int? sedeId)
        {
            if (    sedeId.HasValue)
            {
                S = ABMSede.Get(sedeId.Value);

            }
            else
            {
                S = new Sede();
               /* S.descripcion = S.descripcion;
                S.direccion_barrio = S.direccion_barrio; */
            }
            return Page();
        }

        /*Post*/

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return Page();
            }

            S = ABMSede.Save(S);
            TempData["MensajeSede"] = "se cambiaron los datos correctamente";
            return RedirectToPage("/Detail", new { sedeId = S.id });
        }


    }
}
