using Domain.Interfaces;
using System.Text;

namespace Application.Services.StaircaseGeneration
{
    public class CenterAlignedStaircaseGenerator : IStaircaseGenerator
    {
        public string GetStaircase(int n)
        {
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentException("El numero debe estar entre 1 y 99");
            }
            string staircase = "";
            int middle = n / 2 + n % 2; // Calcula el punto medio de la escalera

            // Construye la mitad superior de la escalera
            for (int i = 1; i <= middle; ++i)
            {
                // Añade espacios a la izquierda
                staircase += new string(' ', middle - i);
                // Añade los símbolos '#'
                staircase += new string('#', n + (i - 1) * 2);
                // Nueva línea después de cada fila
                staircase += "\n";
            }

            // Construye la mitad inferior de la escalera
            for (int i = middle - 1; i > 0; --i)
            {
                // Añade espacios a la izquierda
                staircase += new string(' ', middle - i);
                // Añade los símbolos '#'
                staircase += new string('#', n + (i - 1) * 2);
                // Nueva línea después de cada fila
                staircase += "\n";
            }

            return staircase.TrimEnd(); // Elimina el espacio en blanco final
        }
    }
}
