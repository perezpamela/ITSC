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
    public class ListModel : MBase//PageModel
    {
        public IEnumerable<Sede> sedes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string filtro { get; set; }
        [TempData]
        public string mensaje { get; set; }
        public void OnGet(string filtro)
        {
            sedes = ABMSede.Get(filtro);
        }
    }
}
