using System;

namespace Bridge.Exemplo1
{
    public class ImplementationA : IBridge
    {
        public void Operation()
        {
            Console.WriteLine("Operation called by A");
        }
    }
}