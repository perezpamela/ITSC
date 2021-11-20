using ITSC.DATA;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITSC.WebApp.Pages
{
    public class MBase : PageModel
    {
        public int usuario { get; set; }
        public static string usuario_nombre { get; set; }
        public static string menuOptions { get; set; }
        public static List<SelectListItem> dropdonwOptions { get; set; }
        public string seleccion { get; set; }

        

        

    }
}
