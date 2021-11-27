using ITSC.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSC.DATA
{
    public class ABMSedeCarrera
    {

        public static SedeCarrera Get(int id)
        {
            using(var db = new ITSCContext())
            {
                SedeCarrera sc = db.sedes_carreras
               .Include(i => i.sede)
               .Include(i => i.carrera)
               .FirstOrDefault(x => x.id == id);

                return sc;
            }
        }

        public static IEnumerable<SedeCarrera> Get(string filtro)
        {
            using(var db = new ITSCContext())
            {
                IEnumerable<SedeCarrera> sedeCarrera = db.sedes_carreras.ToList();
                if (!String.IsNullOrEmpty(filtro)) {
                    sedeCarrera = from sc in sedeCarrera
                                      //join c in db.carreras on sc.carrera_id equals c.id
                                      //join s in db.sedes on sc.sede_id equals s.id
                                  where sc.turno == Convert.ToInt32(filtro)
                                  select sc;
                }

                return sedeCarrera.ToList();

            }
        }


        public static SedeCarrera Save(SedeCarrera sedeCa)
        {
            using (var db = new ITSCContext())
            {

                if (sedeCa.id != 0)
                {
                    db.Entry(sedeCa).State = EntityState.Modified;
                }
                else
                {
                    db.sedes_carreras.Add(sedeCa);
                }
                db.SaveChanges();
                return sedeCa;
            }
        }





    }
}
