using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.CORE;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ITSC.WebApp.Pages.Alumnos
{
    public class DetailModel : MBase//PageModel
    {
        public Alumno alumno { get; set; }
        public string str_fecha_nacimiento { get; set; }
        public string str_status { get; set; }

        

        public int edad;
        [TempData]
        public string Mensaje { get; set; }
        public void OnGet(int alumnoId)
        {
            

            alumno = ABM_Alumno.Get(alumnoId);
            str_fecha_nacimiento = alumno.fechaNacimiento.ToString("dd/MM/yyyy");
            str_status = Convert.ToString((Estado)alumno.status);
            edad = DateTime.Now.Year - alumno.fechaNacimiento.Year;
        }
    }

    
    

}
