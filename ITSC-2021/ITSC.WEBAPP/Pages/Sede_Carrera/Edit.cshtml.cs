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
        public ITSC.CORE.SedeCarrera SC { get; set; }

    }
}
