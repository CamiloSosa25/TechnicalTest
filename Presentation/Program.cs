using Application.Services;
using Domain.Interfaces;
using Presentation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de utilidades");
            Console.WriteLine("Seleccione el agente (A, B, C):");
            char mainAgent = char.Parse(Console.ReadLine()!);
            try
            {
                var functionality = FunctionalityFactory.GetFunctionality();
                functionality.Execute(mainAgent);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
