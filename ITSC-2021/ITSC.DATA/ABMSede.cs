using ITSC.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSC.DATA
{
    public class ABMSede
    {
        public static Sede Get(int sedeId)
        {
            using(var db = new ITSCContext())
            {
                return db.sedes.Find(sedeId);
            }
        }

        public static IEnumerable<Sede> Get(string filtro)
        {
            using (var db = new ITSCContext())
            {
                IEnumerable<Sede> listaSedes = db.sedes.Where(s=>s.status==0).ToList();
                if (!String.IsNullOrEmpty(filtro))
                {
                    listaSedes = from s in listaSedes
                                 let upperDesc = s.descripcion.ToUpper()
                                 where upperDesc.Contains(filtro.ToUpper())
                                 orderby s.descripcion
                                 select s;
                }
                return listaSedes.ToList();
            }
        }

        public static Sede Save(Sede sede)
        {
            using(var db = new ITSCContext())
            {
                if(sede.id != 0)
                {
                    db.Entry(sede).State = EntityState.Modified;
                } else
                {
                    db.sedes.Add(sede);
                }
                db.SaveChanges();
                return sede;
            }
        }

        public static bool Delete(int sedeId)
        {
            using(var db = new ITSCContext())
            {
                Sede s = db.sedes.Find(sedeId);
                if(s != null)
                {
                    s.status = 1;
                    ABMSede.Save(s);
                    return true;
                }
                return false;
            }
        }
    }
}
