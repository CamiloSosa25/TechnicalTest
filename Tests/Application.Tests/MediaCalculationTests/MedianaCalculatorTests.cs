using Application.Services.MediaCalculation;

namespace Tests.Application.Test.MediaCalculationTests
{
    public class MedianaCalculatorTests
    {
        [Fact]
        public void GetMedia_ShouldReturnMedianForEvenCount()
        {
            // Arrange
            var calculator = new MedianaCalculator();
            var numbers = new List<double> { 1, 2, 3, 4 };

            // Act
            var result = calculator.GetMedia(numbers);

            // Assert
            Assert.Equal(2.5, result); // Expected median for the given list
        }

        [Fact]
        public void GetMedia_ShouldReturnMedianForOddCount()
        {
            // Arrange
            var calculator = new MedianaCalculator();
            var numbers = new List<double> { 1, 2, 3, 4, 5 };

            // Act
            var result = calculator.GetMedia(numbers);

            // Assert
            Assert.Equal(3.0, result); // Expected median for the given list
        }

        [Fact]
        public void GetMedia_ShouldReturnMedianForSingleValue()
        {
            // Arrange
            var calculator = new MedianaCalculator();
            var numbers = new List<double> { 1 };

            // Act
            var result = calculator.GetMedia(numbers);

            // Assert
            Assert.Equal(1.0, result); // Expected median for a single value
        }

        [Fact]
        public void GetMedia_ShouldThrowArgumentExceptionForEmptyList()
        {
            // Arrange
            var calculator = new MedianaCalculator();
            var numbers = new List<double>();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.GetMedia(numbers));
        }
    }
}
