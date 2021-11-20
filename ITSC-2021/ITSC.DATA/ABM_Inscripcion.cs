using ITSC.CORE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace ITSC.DATA
{
    public class ABM_Inscripciones
    {

     /*   //prueba de combobox
        public static List<string> GetNombres()
        {
            using(var db = new ITSCContext())
            {
                var nombres = from a in db.alumnos select a.id.ToString();
                return nombres.ToList();
            }
        }*/

        public static Inscripcion Get(int id)
        {
            using (var db = new ITSCContext()) {
                return db.inscripciones.Find(id); 
            }
        }

        public static IEnumerable<Inscripcion> Get(string filtroStr)
        {
            using (var db = new ITSCContext()) {
                IEnumerable<Inscripcion> ObjInscripcion = db.inscripciones.ToList();
                if (!String.IsNullOrEmpty(filtroStr))
                {
                    //alumnos = alumnos.Where(al => al.nombre.Contains(filtroStr)); no diferencia mayus/minus

                    ObjInscripcion = from a in ObjInscripcion
                              let dniUpper = a.doc_dni.ToString()
                              where 
                              dniUpper.StartsWith(filtroStr.ToUpper()) 
                              

                              orderby 
                              a.doc_dni,
                              a.doc_acta_nac,
                              a.doc_titulo_sec,
                              a.doc_analitico_sec,
                              a.examen25,
                             a.cooperadora_total,
                             a.cooperadora_saldo,
                             a.status,
                             a.alumno_id,
                             a.sedecarrera_id
                              select a;
                }
                return ObjInscripcion.ToList();
            }
        }

        public static Inscripcion Save(Inscripcion OBJinscripcion)
        {
            using (var db = new ITSCContext()) {
            
                    if(OBJinscripcion.id != 0)
                {
                    db.Entry(OBJinscripcion).State = EntityState.Modified;
                } else
                {
                    db.inscripciones.Add(OBJinscripcion);
                }
                db.SaveChanges();
                return OBJinscripcion;
                    
            }
        }

        public static bool Delete(int id)
        {
            using(var db = new ITSCContext())
            {
                Inscripcion al = db.inscripciones.Find(id);
                if(al != null)
                {
                    //al.status = 1;// por defecto es 0 --habría que cambiar a un str más descriptivo o a un enum
                    //ABM_Alumno.Save(al);
                    //Momentaneamente borra de la base de datos en vez de dar de baja
                    db.Entry(al).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

    }
}
