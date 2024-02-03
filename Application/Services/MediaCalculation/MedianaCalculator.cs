using Domain.Interfaces;

namespace Application.Services.MediaCalculation
{
    public class MedianaCalculator : IMediaCalculator
    {
        public double GetMedia(List<double> numeros)
        {
            var sortedList = numeros.OrderBy(x => x).ToList();
            int size = sortedList.Count;
            if (size % 2 == 0) // Even
            {
                return (sortedList[size / 2 - 1] + sortedList[size / 2]) / 2.0;
            }
            else // Odd
            {
                return sortedList[size / 2];
            }
        }
    }
}
