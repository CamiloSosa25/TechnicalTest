using Domain.Interfaces;

namespace Application.Services.MediaCalculation
{
    public class MediaArmonicaCalculator : IMediaCalculator
    {
        public double GetMedia(List<double> numeros)
        {
            if (numeros == null)
            {
                throw new ArgumentException("No se ha ingresado ningún numero");
            }
            if (numeros.Count == 0) throw new ArgumentException("Debe de ingresar al menos 1 numero");

            if (numeros.Any(n => n == 0.0))
            {
                throw new ArgumentException("La lista no puede contener el número cero");
            }
            return numeros.Count / numeros.Sum(x => 1 / x);
        }
    }

}
