using Application.Services.StaircaseGeneration;
using Domain.Interfaces;
using Presentation.Factory;

namespace Presentation.Funtionality
{
    public class StaircaseGeneration : IFunctionality
    {
        public void Execute(char agent)
        {
            Console.WriteLine("Ingrese el tamaño de la escalera entre 1 y 99:");
            int n = int.Parse(Console.ReadLine()!);

            var generator = StaircaseGeneratorFactory.GetStaircase(agent);
            var stairContext = new StaircaseGeneratorContext(generator);
            string staircase = stairContext.GenerateStaircase(n);
            Console.WriteLine("Escalera generada:");
            Console.WriteLine(staircase);
        }
    }
}
