using ITSC.CORE;
using ITSC.DATA;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carrera c1 = new Carrera();
            //c1.descripcion = "Enfermería";
            //c1.plan = "P1996";
            //c1.plan_start_date = DateTime.Now;
            //ABMCarrera.Save(c1);

            foreach(var c in ABMCarrera.Get(""))
            {
                Console.WriteLine($"Nombre: {c.descripcion}. Plan: {c.plan}");
            }
        }
    }
}
