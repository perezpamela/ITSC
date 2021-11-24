using ITSC.CORE;
using ITSC.DATA;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Sede s1 = new Sede();
            Sede s2 = new Sede();
            Sede s3 = new Sede();

            s1.descripcion = "Sede Centro";
            s2.descripcion = "Sede Libertador";
            s3.descripcion = "Sede Gral Paz";

            s1.dia_desde = Dias.Lunes;
            s1.dia_hasta = Dias.Jueves;
            s1.horario_desde = "08";
            s1.horario_hasta = "16";
            s1.email = "scentral@itsc.edu";


            s2.dia_desde = Dias.Lunes;
            s2.dia_hasta = Dias.Jueves;
            s2.horario_desde = "09";
            s2.horario_hasta = "18";
            s2.email = "sLibertador@itsc.edu";

            s3.dia_desde = Dias.Lunes;
            s3.dia_hasta = Dias.Viernes;
            s3.horario_desde = "19";
            s3.horario_hasta = "22";
            s3.email = "sGralPaz@itsc.edu";

            ABMSede.Save(s1);
            ABMSede.Save(s2);
            ABMSede.Save(s3);
            foreach (var s in ABMSede.Get(""))
            {
                Console.WriteLine($"Nombre: {s.descripcion}. Contacto: {s.email}");
            }
        }
    }
}
