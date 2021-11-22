using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.DATA;
using ITSC.CORE;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ITSC.WebApp.Pages
{
    public class ClaseBase : PageModel
    {
        public int usuario { get; set; }
        public static string usuario_nombre { get; set; }
        public static string menu_opcion { get; set; }
        public static List<SelectListItem> DropdownOptions { get; set; }
        public string seleccion {get; set;}
    }
}
