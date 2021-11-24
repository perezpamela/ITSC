using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITSC.WebApp.Pages.Sedes
{
    public class DetailModel : MBase//PageModel
    {
        [TempData]
        public string mensaje { get; set; }
        public void OnGet()
        {
        }
    }
}
