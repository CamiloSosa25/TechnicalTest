using Domain.Interfaces;

namespace Application.Services.MediaCalculation
{
    public class MediaAritmeticaCalculator : IMediaCalculator
    {
        public double GetMedia(List<double> numeros)
        {
            ArgumentNullException.ThrowIfNull(numeros);
            if (numeros.Count == 0)
            {
                return 0.0;
            }
            return numeros.Average();
        }
    }
}
