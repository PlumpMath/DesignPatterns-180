using System;

namespace Decorator.Exemplo1
{
    public class Decorator : IComponent
    {
        private IComponent Component;

        public Decorator(IComponent component)
        {
            this.Component = component;
        }

        public void Operation()
        {
            Console.WriteLine("Called by Decorator");

            Component.Operation();
        }
    }
}