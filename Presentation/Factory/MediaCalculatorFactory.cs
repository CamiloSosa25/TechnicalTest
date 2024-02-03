using Application.Services.MediaCalculation;
using Domain.Interfaces;

namespace Presentation.Factory
{
    public static class MediaCalculatorFactory
    {
        public static IMediaCalculator GetCalculator(char agent)
        {
            return agent switch
            {
                'A' => new MediaAritmeticaCalculator(),
                'B' => new MediaArmonicaCalculator(),
                'C' => new MedianaCalculator(),
                _ => throw new InvalidOperationException("Selección no válida."),
            };
        }
    }
}
