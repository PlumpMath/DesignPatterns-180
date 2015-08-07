using System;
using System.Collections.Generic;

namespace Composite.Exemplo1
{
    public class Composite : IComponent
    {
        private List<IComponent> Components;

        public Composite()
        {
            Components = new List<IComponent>();
        }

        public void Operation()
        {
            Console.WriteLine("I'm a complex object!");
        }

        public void Operation2()
        {
            Console.WriteLine("Composite");
        }

        public void AddComponent(IComponent component)
        {
            this.Components.Add(component);
        }

        public void GetComponents()
        {
            for (int i = 0; i < this.Components.Count; i++)
            {
                this.Components[i].Operation2();
            }
        }
    }
}