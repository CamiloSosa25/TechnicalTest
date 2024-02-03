using Application.Services.StaircaseGeneration;
using Domain.Interfaces;

namespace Presentation.Factory
{
    public static class StaircaseGeneratorFactory
    {
        public static IStaircaseGenerator GetStaircase(char agent)
        {
            return agent switch
            {
                'A' => new RightAlignedStaircaseGenerator(),
                'B' => new InvertedRightAlignedStaircaseGenerator(),
                'C' => new CenterAlignedStaircaseGenerator(),
                _ => throw new InvalidOperationException("Selección no válida."),
            };
        }
    }
}
