using Domain.Interfaces;
using System.Text;

namespace Application.Services.StaircaseGeneration
{
    public class InvertedRightAlignedStaircaseGenerator : IStaircaseGenerator
    {
        public string GetStaircase(int n)
        {
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentException("El numero debe de estar entre 1 y 99");
            }

            var staircase = new StringBuilder();

            for (int i = n; i >= 1; i--)
            {
                // Agrega espacios
                staircase.Append(' ', n - i);
                // Agrega '#'
                staircase.AppendLine(new string('#', i));
            }

            return staircase.ToString();
        }
    }
}