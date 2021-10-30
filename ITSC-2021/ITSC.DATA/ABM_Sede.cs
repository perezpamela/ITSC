using ITSC.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace ITSC.DATA
{
    public class ABM_Sede
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

        public static Sede Get(int id)
        {
            using (var db = new ITSCContext()) {
                return db.sedes.Find(id); 
            }
        }

        public static IEnumerable<Sede> Get(string filtroStr)
        {
            using (var db = new ITSCContext()) {
                IEnumerable<Sede> ObjSede = db.sedes.ToList();
                if (!String.IsNullOrEmpty(filtroStr))
                {
                    //alumnos = alumnos.Where(al => al.nombre.Contains(filtroStr)); no diferencia mayus/minus

                    ObjSede = from a in ObjSede
                              let emailUpper = a.email.ToUpper()
                              let barrioUpper = a.direccion_barrio.ToUpper()
                              let CalleUpper = a.direccion_calle.ToUpper()
                              let localidadUpper  = a.direccion_localidad.ToString()
                              let nroUpper = a.direccion_nro.ToUpper()
                              where 
                                 emailUpper.StartsWith(filtroStr.ToUpper()) 
                              || CalleUpper.StartsWith(filtroStr.ToUpper()) 
                              || localidadUpper.StartsWith(filtroStr)
                              || nroUpper.StartsWith(filtroStr)
                              orderby
                              a.descripcion, 
                              a.tel_caracteristica, 
                              a.tel_nro, a.email, 
                              a.direccion_calle,
                              a.direccion_nro,
                              a.direccion_piso,
                              a.direccion_dpto,
                              a.direccion_barrio,
                              a.direccion_localidad,
                              a.dia_desde,
                              a.dia_hasta,
                              a.status
                  
                              select a;
                }
                return ObjSede.ToList();
            }
        }

        public static Sede Save(Sede ObjSedeSave)
        {
            using (var db = new ITSCContext()) {
            
                if(ObjSedeSave.id != 0)
                {
                    db.Entry(ObjSedeSave).State = EntityState.Modified;
                }
                else
                {
                    db.sedes.Add(ObjSedeSave);
                }
                db.SaveChanges();
                return ObjSedeSave;
                    
            }
        }

        public static bool Delete(int id)
        {
            using(var db = new ITSCContext())
            {
                Sede ObjsedeDel = db.sedes.Find(id);
                if(ObjsedeDel != null)
                {
                    //al.status = 1;// por defecto es 0 --habría que cambiar a un str más descriptivo o a un enum
                    //ABM_Alumno.Save(al);
                    //Momentaneamente borra de la base de datos en vez de dar de baja
                    db.Entry(ObjsedeDel).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

    }
}
