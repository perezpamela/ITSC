using ITSC.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSC.DATA
{
    public class ABMCarrera
    {
        public static Carrera Get(int id)
        {
            using(var db = new ITSCContext())
            {
                return db.carreras.Find(id); 
            }
        }

        public static IEnumerable<Carrera> Get(string filtro)
        {
            using(var db = new ITSCContext())
            {
                IEnumerable<Carrera> carreras = db.carreras.ToList().Where(c => c.status == 0); //Solo las activas.
                if (!String.IsNullOrEmpty(filtro))
                {
                    carreras = from c in carreras
                               let descripcionUpper = c.descripcion.ToUpper()
                               let planUpper = c.plan.ToUpper()
                               where
                               (descripcionUpper.Contains(filtro.ToUpper())
                               ||
                               planUpper.Contains(filtro.ToUpper())
                               )
                               orderby c.descripcion, c.plan_start_date
                               select c;             
                }
                return carreras.ToList();
            }
        }

        public static Carrera Save(Carrera carrera)
        {
            using(var db = new ITSCContext())
            {
                if(carrera.id != 0)
                {
                    db.Entry(carrera).State = EntityState.Modified;
                } else
                {
                    db.carreras.Add(carrera);
                }

                db.SaveChanges();
                return carrera;
            }
        }

        public static bool Delete(int id)
        {
            using(var db = new ITSCContext())
            {
                Carrera c = db.carreras.Find(id);
                if(c != null)
                {
                    c.status = 1;
                    ABMCarrera.Save(c);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
