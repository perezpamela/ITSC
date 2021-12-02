using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITSC.WebApp.Pages.SedeCarrera
{
    public class DetailModel : MBase//PageModel
    {
        [TempData]
        public string mensaje { get; set; }
        public ITSC.CORE.SedeCarrera sc { get; set; }
        public string strTurno { get; set; }
        public IActionResult OnGet(int SedeCarreraId)
        {
            sc = ABMSedeCarrera.Get(SedeCarreraId);
            sc.carrera = ABMCarrera.Get(sc.carreraid);
            sc.sede = ABMSede.Get(sc.sedeid);
            switch (sc.turno)
            {
                case 1:
                    strTurno = "Mañana";
                    break;
                case 2:
                    strTurno = "Tarde";
                    break;
                case 3:
                    strTurno = "Noche";
                    break;
                default:
                    strTurno = "";
                    break;
            }

            return Page();
        }
    }
}
