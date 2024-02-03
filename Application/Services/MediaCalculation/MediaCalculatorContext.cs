using Domain.Interfaces;

namespace Application.Services.MediaCalculation
{
    public class MediaCalculatorContext(IMediaCalculator calculator)
    {
        private readonly IMediaCalculator _calculator = calculator;

        public double CalculateMedia(List<double> numeros)
        {
            return _calculator.GetMedia(numeros);
        }
    }

}