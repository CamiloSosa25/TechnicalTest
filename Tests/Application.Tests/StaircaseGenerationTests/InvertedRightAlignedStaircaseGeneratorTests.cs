using Application.Services.StaircaseGeneration;

namespace Tests.Application.Test.StaircaseGenerationTests
{
    public class InvertedRightAlignedStaircaseGeneratorTests
    {
        [Theory]
        [InlineData(4, "####\r\n ###\r\n  ##\r\n   #\r\n")] // Ejemplo con n = 4
        [InlineData(3, "###\r\n ##\r\n  #\r\n")] // Ejemplo con n = 3
        [InlineData(5, "#####\r\n ####\r\n  ###\r\n   ##\r\n    #\r\n")] // Ejemplo con n = 5
        public void ShouldGenerateInvertedRightAlignedStaircase(int n, string expectedStaircase)
        {
            // Arrange
            var generator = new InvertedRightAlignedStaircaseGenerator();

            // Act
            var result = generator.GetStaircase(n);

            // Assert
            Assert.Equal(expectedStaircase, result);
        }

        [Theory]
        [InlineData(0)]  // Debe lanzar una excepción para n = 0
        [InlineData(100)]  // Debe lanzar una excepción para n = 100
        [InlineData(-1)]  // Debe lanzar una excepción para n = -1
        public void ShouldThrowExceptionForInvalidNValues(int n)
        {
            // Arrange
            var generator = new InvertedRightAlignedStaircaseGenerator();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => generator.GetStaircase(n));
        }
    }
}