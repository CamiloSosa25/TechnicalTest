using Application.Services.StaircaseGeneration;


namespace Tests.Application.Test.StaircaseGenerationTests
{
    public class RightAlignedStaircaseGeneratorTests
    {
        [Fact]
        public void ShouldGenerateRightAlignedStaircase()
        {
            // Arrange
            var generator = new RightAlignedStaircaseGenerator();
            int n = 4;
            var expectedStaircase = "   #\r\n  ##\r\n ###\r\n####\r\n";

            // Act
            var result = generator.GetStaircase(n);

            // Assert
            Assert.Equal(expectedStaircase, result);
        }

        [Fact]
        public void ShouldThrowExceptionForInvalidNValues()
        {
            // Arrange
            var generator = new RightAlignedStaircaseGenerator();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => generator.GetStaircase(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => generator.GetStaircase(100));
            Assert.Throws<ArgumentOutOfRangeException>(() => generator.GetStaircase(-1));
        }
    }
}