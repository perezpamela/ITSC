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
    public class ListModel : MBase //PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string strBusqueda { get; set; }
        public IEnumerable<Carrera> carreras { get; set; }
        [TempData]
        public string mensaje { get; set; }
        public void OnGet(string strBusqueda)
        {
            carreras = ABMCarrera.Get(strBusqueda);
        }
    }
}
