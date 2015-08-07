using System;
using Adapter.Exemplo1;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1();

            Console.ReadKey();
        }

        #region Exemplo1

        public static void EX1()
        {
            ImagemJPG imagemDoFTP = new ImagemJPG();
            imagemDoFTP.Altura = 100;
            imagemDoFTP.Largura = 200;

            ImagemAdapter adaptador = new ImagemAdapter();

            Foto fotoDoUsuario = adaptador.ConverteImagem(imagemDoFTP);
        }

        #endregion Exemplo1
    }
}