using System;

namespace Bridge.Exemplo2
{
    public class CalculadoraMath : ICalculadora
    {
        public double PI
        {
            get { return Math.PI; }
        }
    }
}