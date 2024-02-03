using Domain.Interfaces;
using System.Text;

namespace Application.Services.StaircaseGeneration
{
    public class RightAlignedStaircaseGenerator : IStaircaseGenerator
    {
        public string GetStaircase(int n)
        {
            var staircase = new StringBuilder();

            if (n <= 0 || n >= 100)
            {
                throw new ArgumentOutOfRangeException("El valor de 'n' debe de estar en el rango 1 y 99.");
            }

            for (int i = 1; i <= n; i++)
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