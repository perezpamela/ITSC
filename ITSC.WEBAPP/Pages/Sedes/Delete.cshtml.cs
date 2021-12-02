using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.CORE;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITSC.WebApp.Pages.Sedes
{
    public class DeleteModel : MBase//PageModel
    {
        [BindProperty(SupportsGet =true)]
        public Sede sede { get; set; }
        public bool flag { get; set; }
        public IActionResult OnGet(int sedeId)
        {
            sede = ABMSede.Get(sedeId);
            return Page();
        }

        public IActionResult OnPost(int sedeId)
        {
            sede = ABMSede.Get(sedeId);
            flag = ABMSede.Delete(sedeId);
            if (flag)
            {
                TempData["mensaje"] = $"Se dio de baja {sede.descripcion} correctamente.";
            }else
            {
                TempData["mensaje"] = $"Error al dar de baja {sede.descripcion}. La operación no se completó.";
            }
            return RedirectToPage("./List");
        }
    }
}
