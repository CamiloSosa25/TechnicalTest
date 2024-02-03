using Application.Services.MediaCalculation;

namespace Tests.Application.Test.MediaCalculationTests
{
    public class MediaArmonicaCalculatorTests
    {
        [Fact]
        public void GetMedia_ShouldCalculateHarmonicMean()
        {
            // Arrange
            var calculator = new MediaArmonicaCalculator();
            var numbers = new List<double> { 1, 2, 3, 4 };

            // Act
            var result = calculator.GetMedia(numbers);

            // Assert
            Assert.Equal(1.920, Math.Round(result, 3)); // Expected harmonic mean rounded to 3 decimal places
        }

        [Fact]
        public void GetMedia_ShouldThrowArgumentExceptionForZeroValue()
        {
            // Arrange
            var calculator = new MediaArmonicaCalculator();
            var numbers = new List<double> { 1, 2, 0, 4 };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.GetMedia(numbers));
        }

        [Fact]
        public void GetMedia_ShouldThrowArgumentExceptionForEmptyList()
        {
            // Arrange
            var calculator = new MediaArmonicaCalculator();
            var numbers = new List<double>();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.GetMedia(numbers));
        }
    }
}
