using System;

namespace Bridge.Exemplo1
{
    public class ImplementationB : IBridge
    {
        public void Operation()
        {
            Console.WriteLine("Operation called by B");
        }
    }
}