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
        public static List<SelectListItem> dropdonwOptions { get; set; }
        public string seleccion { get; set; }
        public static int usrPermiso = 777;

        #region Base del menú

        public List<menu> menuOpts = new List<menu> { };
        
        #endregion

        public List<menu> generaMenu(int usrPermiso)
        {
            switch (usrPermiso)
            {
                case 1://Alumno
                    menuOpts.Add(new menu { textoBtn = "Materias", urlBtn = "#" });
                    menuOpts.Add(new menu { textoBtn = "Certificado de Regularidad", urlBtn = "#" });


                    return menuOpts;
                    
                case 2:
                    menuOpts.Add(new menu { textoBtn = "Alumnos", urlBtn = "#" });
                    menuOpts.Add(new menu { textoBtn = "Asistencia", urlBtn = "#" });
                    menuOpts.Add(new menu { textoBtn = "Exámenes", urlBtn = "#" });
                    menuOpts.Add(new menu { textoBtn = "Temario", urlBtn = "#" });


                    return menuOpts;

                    
                case 3: //Preceptor de la carrera - menu
                    menuOpts.Add(new menu { textoBtn = "Cursos", urlBtn = "#" });
                    menuOpts.Add(new menu { textoBtn = "Profesores", urlBtn = "#" });
                    menuOpts.Add(new menu { textoBtn = "Cooperadora", urlBtn = "#" });
                    menuOpts.Add(new menu { textoBtn = "Examenes", urlBtn = "#" });
                    menuOpts.Add(new menu { textoBtn = "(!)Alumnos", urlBtn = "/Alumnos/List" });
                    menuOpts.Add(new menu { textoBtn = "(!)Carreras", urlBtn = "/Carreras/List" });

                    return menuOpts;
                case 777:
                    menuOpts.Add(new menu { textoBtn = "(!)Alumnos", urlBtn = "/Alumnos/List" });
                    menuOpts.Add(new menu { textoBtn = "(!)Sedes", urlBtn = "/Sedes/List" });
                    menuOpts.Add(new menu { textoBtn = "(!)Carreras", urlBtn = "/Carreras/List" });
                    menuOpts.Add(new menu { textoBtn = "Materias", urlBtn = "/Carreras/List" });
                    menuOpts.Add(new menu { textoBtn = "Materias", urlBtn = "/Carreras/List" });


                    return menuOpts;
                default:

                    return menuOpts;

                    
                
            }
        }


    }

    public class menu
    {
        public string textoBtn { get; set; }
        public string urlBtn { get; set; }
    }



}

