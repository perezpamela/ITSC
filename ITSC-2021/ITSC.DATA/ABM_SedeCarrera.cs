using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ITSC.CORE;

namespace ITSC.DATA
{
    public class ABM_sedecarrera
    {

        //Busca por int
        public static SedeCarrera Get(int id)
        {
            using (var db = new ITSCContext())
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
            using (var db = new ITSCContext())
            {
                IEnumerable<SedeCarrera> sedeCarrera = db.sedes_carreras.ToList();
                if (!String.IsNullOrEmpty(filtro))
                {
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

        public static bool Delete(int id)
        {
            using (var db = new ITSCContext())
            {
                SedeCarrera sc = db.sedes_carreras.Find(id);
                if (sc != null)
                {
                    sc.status = 1;// por defecto es 0 --habría que cambiar a un str más descriptivo o a un enum
                    ABM_sedecarrera.Save(sc);
                    //Momentaneamente borra de la base de datos en vez de dar de baja
                    //db.Entry(al).State = EntityState.Deleted;
                    //db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
