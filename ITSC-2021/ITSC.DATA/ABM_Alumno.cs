using ITSC.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSC.DATA
{
    public class ABM_Alumno
    {
        public static IEnumerable<Alumno> Get()
        {
            using (var db = new ITSCContext()) {
                return db.alumnos.ToList();
            }
        }

        public static Alumno Get(int id)
        {
            using (var db = new ITSCContext()) {
                return db.alumnos.Find(id); 
            }
        }

        public static IEnumerable<Alumno> Get(string filtroStr)
        {
            using (var db = new ITSCContext()) {
                IEnumerable<Alumno> alumnos = db.alumnos.ToList();
                if (!String.IsNullOrEmpty(filtroStr))
                {
                    //alumnos = alumnos.Where(al => al.nombre.Contains(filtroStr)); no diferencia mayus/minus

                    alumnos = from a in alumnos
                              let nombreUpper = a.nombre.ToUpper()
                              let apellidoUpper = a.apellido.ToUpper()
                              where nombreUpper.Contains(filtroStr.ToUpper()) || apellidoUpper.Contains(filtroStr.ToUpper())
                              orderby a.apellido, a.nombre
                              select a;
                }
                return alumnos.ToList();
            }
        }

        public static void Save(Alumno alumno)
        {
            using (var db = new ITSCContext()) {
            
                    if(alumno.id != 0)
                {
                    db.Entry(alumno).State = EntityState.Modified;
                } else
                {
                    db.alumnos.Add(alumno);
                }
                db.SaveChanges();
                    
            }
        }

        public static bool Delete(int id)
        {
            using(var db = new ITSCContext())
            {
                Alumno al = db.alumnos.Find(id);
                if(al != null)
                {
                    al.status = 1;// por defecto es 0
                    ABM_Alumno.Save(al);
                    return true;
                }
                return false;
            }
        }

    }
}
