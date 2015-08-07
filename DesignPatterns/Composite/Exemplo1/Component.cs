using System;

namespace Composite.Exemplo1
{
    public class Component : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("I'm a simple object!");
        }

        public void Operation2()
        {
            Console.WriteLine("Component");
        }
    }
}