﻿using ITSC.CORE;
using ITSC.DATA;
using System;
using static System.Console;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SedeCarrera sc = ABMSedeCarrera.Get(1);
            sc.carrera = ABMCarrera.Get(sc.carreraid);
            sc.sede = ABMSede.Get(sc.sedeid);

           
            WriteLine(sc.turno);
            WriteLine(sc.status);
            WriteLine(sc.carrera.descripcion);
            WriteLine(sc.sede.descripcion);
            foreach (var s in ABMSedeCarrera.Get("1"))
            {
                Console.WriteLine($"Turno: {s.turno}. Carrera_id: {s.carreraid}");
            }
        }
    }
}
