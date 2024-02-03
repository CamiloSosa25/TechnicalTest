using Application.Services.MediaCalculation;

namespace Tests.Application.Test.MediaCalculationTests
{
    public class MediaAritmeticaCalculatorTests
    {
        [Fact]
        public void GetMedia_ShouldCalculateMedian()
        {
            // Arrange
            var calculator = new MediaAritmeticaCalculator();
            var numbers = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };

            // Act
            var media = calculator.GetMedia(numbers);

            // Assert
            Assert.Equal(3.0, media);
        }

        [Fact]
        public void GetMedia_ShouldReturnZeroEmptyList()
        {
            // Arrange
            var calculator = new MediaAritmeticaCalculator();
            var numbers = new List<double>();

            // Act
            var media = calculator.GetMedia(numbers);

            // Assert
            Assert.Equal(0.0, media); // Verificar que la media de una lista vacía sea 0
        }

        [Fact]
        public void GetMedia_ShouldThrowArgumentExceptionForEmptyList()
        {
            // Arrange
            var calculator = new MediaAritmeticaCalculator();
            List<double>? numbers = null;

            // Act y Assert
            Assert.Throws<ArgumentNullException>(() => calculator.GetMedia(numbers));
        }
    }
}
