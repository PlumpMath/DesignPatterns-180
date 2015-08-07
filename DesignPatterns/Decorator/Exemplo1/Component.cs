using System;

namespace Decorator.Exemplo1
{
    public sealed class Component : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Called by generic Component");
        }
    }
}