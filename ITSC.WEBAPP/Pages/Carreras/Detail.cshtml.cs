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
    public class DetailModel : MBase//PageModel
    {
        public Carrera carrera { get; set; }
        public string estado { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        [TempData]
        public String mensaje { get; set; }
        public void OnGet(int carreraId)
        {
            carrera = ABMCarrera.Get(carreraId);
            fecha_inicio=carrera.plan_start_date.ToString("dd/mm/yyyy");
            fecha_fin=carrera.plan_end_date.ToString("dd/mm/yyyy");
            estado = Convert.ToString((Estado)carrera.status);
            
        }
    }
}
