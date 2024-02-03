using Domain.Interfaces;

namespace Application.Services.StaircaseGeneration
{
    public class StaircaseGeneratorContext
    {
        private readonly IStaircaseGenerator _generator;

        public StaircaseGeneratorContext(IStaircaseGenerator generator)
        {
            _generator = generator;
        }

        public string GenerateStaircase(int n)
        {
            return _generator.GetStaircase(n);
        }
    }
}
