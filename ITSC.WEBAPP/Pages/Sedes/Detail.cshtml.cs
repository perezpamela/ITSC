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
    public class DetailModel : MBase//PageModel
    {
        public Sede sede { get; set; }
       
        [TempData]
        public string mensaje { get; set; }
        public void OnGet(int sedeId)
        {
            sede = ABMSede.Get(sedeId);
        }
    }
}
