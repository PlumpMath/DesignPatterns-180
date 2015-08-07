﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo2
{
    public class FiestaSedan : AbstractCarroSedan
    {
        public override void Detalhes()
        {
            Console.WriteLine("Fiesta Sedan");
        }
    }
}
