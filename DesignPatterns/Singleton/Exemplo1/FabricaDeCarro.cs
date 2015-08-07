using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton.Exemplo1
{
    public class FabricaDeCarro
    {
        private List<CarroPopular> _carrosPopulares;

        private static FabricaDeCarro _instance;
        public static FabricaDeCarro Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FabricaDeCarro();

                return _instance;
            }
        }

        private FabricaDeCarro()
        {
            _carrosPopulares = new List<CarroPopular>();
        }

        public CarroPopular CriaCarroPopular()
        {
            CarroPopular carro = new CarroPopular();
            _carrosPopulares.Add(carro);

            return carro;
        }

        public void GerarRelatorio()
        {
            for (int i = 0; i < _carrosPopulares.Count; i++)
            {
                Console.WriteLine("Carro: {0}", _carrosPopulares[i].Nome);
            }
        }
    }
}
