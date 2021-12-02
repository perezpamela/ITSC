using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ITSC.DATA;
using ITSC.CORE;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ITSC.WebApp.Pages.SedeCarrera
{
    public class EditModel : MBase//MBase
    {
        [BindProperty(SupportsGet =true)]
        public ITSC.CORE.SedeCarrera SC { get; set; }

        /*[BindProperty(SupportsGet = true)]
        public List<SelectListItem> CarreraList { get; set; }*/

        [BindProperty(SupportsGet =true)]
        public IEnumerable<Carrera> carreras { get; set; }

        [BindProperty(SupportsGet = true)]
        public IEnumerable<Sede> sedes { get; set; }


        public IActionResult OnGet(int? sedeCarreraId)
        {
            carreras = ABMCarrera.Get("");
            sedes = ABMSede.Get("");
            
            if (sedeCarreraId.HasValue)
            {
                SC = ABMSedeCarrera.Get(sedeCarreraId.Value);
            } else
            {
                SC = new CORE.SedeCarrera();
            }

            SC.carrera = ABMCarrera.Get(SC.carreraid);
            SC.sede = ABMSede.Get(SC.sedeid);
              //CarreraList = new List<SelectListItem>();
            foreach (var n in ABMCarrera.Get(""))
            {
              //CarreraList.Add(new SelectListItem { Text = n.descripcion, Value = n.id.ToString() });   
                
            }

            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            SC = ABMSedeCarrera.Save(SC);
            TempData["Mensaje"] = "Se guardó la sede/carrera exitosamente.";
            return RedirectToPage("./Detail", new {sedeCarreraId = SC.id });
        }


    }
}
