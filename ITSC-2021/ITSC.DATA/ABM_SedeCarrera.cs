using ITSC.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace ITSC.DATA
{
    public class ABM_SedeCarrera
    {

        //prueba de combobox
     /*   public static List<string> GetNombres()
        {
            using(var db = new ITSCContext())
            {
                var nombres = from a in db.sedes select a.id.ToString();
                return nombres.ToList();
            }
        }*/

        public static SedeCarrera Get(int id)
        {
            using (var db = new ITSCContext()) {
                return db.sedes_carreras.Find(id); 
            }
        }

        public static IEnumerable<SedeCarrera> Get(string filtroStr)
        {
            using (var db = new ITSCContext()) {
                IEnumerable<SedeCarrera> ObjSede = db.sedes_carreras.ToList();
                if (!String.IsNullOrEmpty(filtroStr))
                {
                    //alumnos = alumnos.Where(al => al.nombre.Contains(filtroStr)); no diferencia mayus/minus

                    ObjSede = from a in ObjSede
                                  //let emailUpper = a.email.ToUpper()
                              let turnoUpper = a.turno.ToString()
                              let statusUpper = a.status.ToString()
                     
                              where 
                              turnoUpper.StartsWith(filtroStr.ToUpper())
                            || statusUpper.StartsWith(filtroStr.ToUpper()) 


                              orderby
                              a.id ,
                              a.turno ,
                              a.status 

                              
                  
                              select a;
                }
                return ObjSede.ToList();
            }
        }

        public static SedeCarrera Save(SedeCarrera ObjSedeCaSave)
        {
            using (var db = new ITSCContext()) {
            
                if(ObjSedeCaSave.id != 0)
                {
                    db.Entry(ObjSedeCaSave).State = EntityState.Modified;
                }
                else
                {
                    db.sedes_carreras.Add(ObjSedeCaSave);
                }
                db.SaveChanges();
                return ObjSedeCaSave;
                    
            }
        }

        public static bool Delete(int id)
        {
            using(var db = new ITSCContext())
            {
                SedeCarrera Obj_SedeCa_Del = db.sedes_carreras.Find(id);
                if(Obj_SedeCa_Del != null)
                {
                    //al.status = 1;// por defecto es 0 --habría que cambiar a un str más descriptivo o a un enum
                    //ABM_Alumno.Save(al);
                    //Momentaneamente borra de la base de datos en vez de dar de baja
                    db.Entry(Obj_SedeCa_Del).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

    }
}
