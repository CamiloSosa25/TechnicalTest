using System;
using System.Collections.Generic;
using Xunit;
using Application.Services;
using Moq;
using Domain.Interfaces;
using Application.Services.MediaCalculation;

namespace Tests.Application.Test.MediaCalculationTests
{
    public class MediaCalculatorContextTests
    {
        [Fact]
        public void CalculateMedia_ShouldDelegateToIMediaCalculator()
        {
            // Arrange
            var mockCalculator = new Mock<IMediaCalculator>();
            var context = new MediaCalculatorContext(mockCalculator.Object);
            var numbers = new List<double> { 1, 2, 3, 4 };

            // Setup a mock behavior for GetMedia method
            mockCalculator.Setup(x => x.GetMedia(numbers)).Returns(2.5);

            // Act
            var result = context.CalculateMedia(numbers);

            // Assert
            Assert.Equal(2.5, result); // Ensure that the result matches the mocked value
            mockCalculator.Verify(x => x.GetMedia(numbers), Times.Once); // Verify that GetMedia was called once
        }
    }
}
