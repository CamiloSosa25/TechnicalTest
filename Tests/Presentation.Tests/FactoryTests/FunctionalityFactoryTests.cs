using System;
using Presentation.Factory;
using Presentation.Funtionality;
using Xunit;

namespace Tests.Presentation.Tests.FactoryTests
{
    public class FunctionalityFactoryTests
    {


        [Theory]
        [InlineData('4')] // Invalid input
        public void GetFunctionality_Should_ThrowExceptionForInvalidInput(char input)
        {
            // Arrange
            using var stringReader = new StringReader(input + "\n"); // Simulate user input
            Console.SetIn(stringReader);

            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => FunctionalityFactory.GetFunctionality(input));
        }
    }
}
