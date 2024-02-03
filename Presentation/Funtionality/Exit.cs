using Domain.Interfaces;

namespace Presentation.Funtionality
{
    public class Exit : IFunctionality
    {
        public void Execute(char agent)
        {
            Console.WriteLine($"Gracias por utilizar el programa agente {agent} , saliendo...");
        }
    }
}
