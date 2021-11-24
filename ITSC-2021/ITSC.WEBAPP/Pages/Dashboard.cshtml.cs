using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSC.CORE;
using ITSC.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ITSC.WebApp.Pages
{
    public class DashboardModel : MBase//PageModel
    {
        public string strFilter { get; set; }
        public int carrera { get; set; }
        public string permisos { get; set; }

        public List<SelectListItem> carreras { get; set; }
        public SedeCarrera sc { get; set; }  //debería ser por materias en el caso del profesor

        public void OnGet(int usuario)
        {
            Alumno al = ABM_Alumno.GetAlumnoDni(usuario);
            carreras = new List<SelectListItem>(); 
            foreach (var c in GetUsuarios.GetCarreras(usuario))
            {
                carreras.Add(new SelectListItem
                {
                    Text = c.carrera + " "+c.carrera, Value=c.id+"_P"+al.usuario_tipo
                }) ;
            }
            //........................................................................
            usuario_nombre = al.apellido+" "+al.nombre;
            dropdonwOptions = carreras;
            strFilter = "0091_p1";
            carrera = Convert.ToInt32(strFilter.Substring(0, strFilter.IndexOf("_")));
            permisos = strFilter.Substring(strFilter.IndexOf("_") + 1);
            //menuOptions = carrera.ToString()+permisos;
            
        }
    }
}
