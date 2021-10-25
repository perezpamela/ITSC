using ITSC.CORE;
using ITSC.DATA;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno al1 = new Alumno();
            al1.nombre = "Pamela";
            al1.apellido = "Perez";
            al1.dni = 30000589;
            Alumno al2 = new Alumno();
            al2.nombre = "Juan";
            al2.apellido = "Perez";
            al2.dni = 12678990;

            ABM_Alumno.Save(al1);
            ABM_Alumno.Save(al2);

            foreach(var al in ABM_Alumno.Get("Pere"))
            {
                Console.WriteLine($"Nombre: {al.nombre}. Apellido: {al.apellido}. DNI: {al.dni}.");
            }
        }
    }
}
