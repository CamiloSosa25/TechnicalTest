using System;
using Presentation.Funtionality;
using Tests.Presentation.Tests.Helpers;
using Xunit;

namespace Tests.Presentation.Tests.FunctionalityTests
{
    public class ExitTests
    {
        [Fact]
        public void Execute_Should_PrintExitMessage()
        {
            // Arrange
            var exitFunctionality = new Exit();
            char agent = 'A';
            var expectedOutput = $"Gracias por utilizar el programa agente {agent} , saliendo...";

            // Redirect console output to capture it
            using var consoleOutput = new ConsoleOutputCapture();
            // Act
            exitFunctionality.Execute(agent);
            var consoleText = consoleOutput.GetOuput();

            // Assert
            Assert.Equal(expectedOutput, consoleText);
        }
    }


}
