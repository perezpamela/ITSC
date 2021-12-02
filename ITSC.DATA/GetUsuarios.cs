using ITSC.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSC.DATA
{
    public class GetUsuarios
    {
        public static IEnumerable<SedeCarrera> GetCarreras(int dni)
        {
            using(var db = new ITSCContext())
            {

                Alumno a = db.alumnos.ToList().Where(a => a.dni == dni).FirstOrDefault();

                IEnumerable<SedeCarrera> carreras_al = from c in db.sedes_carreras
                                             join m in db.materias_carreras on c.id equals m.sedecarreraid
                                             join cr in db.cursantes on m.id equals cr.materiacarreraid
                                             join al in db.alumnos on cr.alumnoid equals al.id
                                             where al.dni == dni
                                             select c;
                return carreras_al.ToList();

                                                //from post in database.Posts
                                                //join meta in database.Post_Metas on post.ID equals meta.Post_ID
                                                //where post.ID == id
                                                //select new { Post = post, Meta = meta };
            }
        }
    }
}
