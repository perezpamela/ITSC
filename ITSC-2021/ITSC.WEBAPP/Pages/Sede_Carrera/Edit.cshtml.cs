using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ITSC.DATA;
using ITSC.CORE;

namespace ITSC.WebApp.Pages.SedeCarrera
{
    public class EditModel : MBase
    {
        [BindProperty]
        public ITSC.CORE.SedeCarrera sc { get; set; }

        public IActionResult OnGet ( int? SedeCarreraId)
        {
            if (SedeCarreraId.HasValue)
            {
                sc= abm
            }
        }
        

    }
}
