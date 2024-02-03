using Application.Services.MediaCalculation;
using Domain.Interfaces;
using Presentation.Factory;

namespace Presentation.Funtionality
{
    public class MediaCalculation : IFunctionality
    {
        public void Execute(char agent)
        {
            IMediaCalculator calculator = MediaCalculatorFactory.GetCalculator(agent);

            Console.WriteLine("\nIngrese los números separados por espacio:");
            List<double> numeros = Console.ReadLine()!.Split(' ').Select(double.Parse).ToList();

            MediaCalculatorContext context = new(calculator);
            double resultado = context.CalculateMedia(numeros);

            Console.WriteLine($"El resultado es: {resultado}");
        }
    }

}