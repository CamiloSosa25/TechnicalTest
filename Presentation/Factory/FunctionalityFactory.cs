using Domain.Interfaces;
using Presentation.Funtionality;

namespace Presentation.Factory
{
    public static class FunctionalityFactory
    {
        public static IFunctionality GetFunctionality()
        {
            Console.WriteLine("Seleccione la funcionalidad: ");
            Console.WriteLine("1: Generador de escaleras");
            Console.WriteLine("2: Cálculo de medias");
            Console.WriteLine("3: Salir");
            Console.Write("Opción: ");
            int selection = int.Parse(Console.ReadLine()!);
            return selection switch
            {
                1 => new StaircaseGeneration(),
                2 => new MediaCalculation(),
                3 => new Exit(),
                _ => throw new InvalidOperationException("Selección no válida."),
            };
        }
    }
}
