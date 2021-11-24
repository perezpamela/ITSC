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
    public class DeleteModel : MBase//PageModel
    {
        
        public Carrera carrera { get; set; }
        public bool flag { get; set; }

        public IActionResult OnGet(int carreraId)
        {
            carrera = ABMCarrera.Get(carreraId);
            return Page();
        }

        public IActionResult OnPost(int carreraId)
        {
            carrera = ABMCarrera.Get(carreraId);
            flag = ABMCarrera.Delete(carreraId);
            if (flag)
            {
                TempData["mensaje"] = $"Se dio de baja la carrera {carrera.descripcion}. Plan: {carrera.plan}.";
            } else
            {
                TempData["mensaje"] = $"No se pudo dar de baja la carrera.";
            }
            return RedirectToPage("./List");
        }
    }
}
