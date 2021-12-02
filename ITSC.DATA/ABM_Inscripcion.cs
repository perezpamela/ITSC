using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITSC.CORE;
using Microsoft.EntityFrameworkCore;

namespace ITSC.DATA
{
   public class ABM_Inscripcion
    {
        public static IEnumerable<Inscripcion> Get()
        {
            using (var db = new ITSCContext())
            {
                return db.inscripciones.ToList();
            }
        }

        public static Inscripcion get(int id)
        {
            using (var db = new ITSCContext())
            {
                return db.inscripciones.Find(id);
            }
        }

        public static Inscripcion Save(Inscripcion objInscripcion)
        {
            using (var db = new ITSCContext())
            {
                if(objInscripcion.id != 0)
                {
                    db.Entry(objInscripcion).State = EntityState.Modified;
                }
                else
                {
                    db.inscripciones.Add(objInscripcion);
                }
                db.SaveChanges();
                return objInscripcion;
            }
        }

        public static bool Delete (Inscripcion objInscripcion)
        {
            using (var db = new ITSCContext())
            {
                if(objInscripcion != null)
                {
                    objInscripcion.status = 1;
                    ABM_Inscripcion.Save(objInscripcion);
                    return true;
                }
            }
                return false;
        }
    }
}
