// Helper class to capture console output
namespace Tests.Presentation.Tests.Helpers
{
    public class ConsoleOutputCapture : IDisposable
    {
        private readonly StringWriter stringWriter;
        private readonly TextWriter originalOutput;

        public ConsoleOutputCapture()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOuput()
        {
            return stringWriter.ToString().Trim();
        }

        public void Dispose()
        {
            stringWriter.Dispose();
            Console.SetOut(originalOutput);
        }
    }
}