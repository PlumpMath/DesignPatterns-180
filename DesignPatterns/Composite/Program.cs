using System;
using Composite.Exemplo1;
using Composite.Exemplo2;
using Composite.Exemplo3;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1();
            //EX2();
            Ex3();

            Console.ReadKey();
        }

        #region Exemplo 1

        public static void EX1()
        {
            IComponent simpleComponent = new Component();
            simpleComponent.Operation();

            IComponent complexComponent = new Composite.Exemplo1.Composite();
            complexComponent.Operation();

            Composite.Exemplo1.Composite composite = new Exemplo1.Composite();
            composite.AddComponent(simpleComponent);
            composite.AddComponent(complexComponent);

            composite.GetComponents();
            composite.Operation2();
        }

        #endregion Exemplo 1

        #region Exemplo 2

        public static void EX2()
        {
            Pasta meuComputador = new Pasta("Meu Computador");

            Pasta unidadeC = new Pasta("C:");
            Pasta arquivosDeProgramas = new Pasta("Arquivos de Programas");
            Pasta windows = new Pasta("Windows");

            Pasta ditto = new Pasta("Ditto");
            Arquivo dittoSetup = new Arquivo("Ditto.exe");

            Pasta usuarios = new Pasta("Usuários");
            Pasta guilherme = new Pasta("Guilherme");
            Arquivo documento = new Arquivo("Documento.txt");

            meuComputador.Adicionar(unidadeC);

            unidadeC.Adicionar(arquivosDeProgramas);
            unidadeC.Adicionar(windows);

            unidadeC.Adicionar(ditto);
            ditto.Adicionar(dittoSetup);

            unidadeC.Adicionar(usuarios);
            usuarios.Adicionar(guilherme);
            guilherme.Adicionar(documento);

            meuComputador.Imprimir();
        }

        #endregion Exemplo 2

        #region Exemplo 3

        public static void Ex3()
        {
            Pote poteGrande = new Pote("Pote Grande");

            Pote poteMedio = new Pote("Pote Médio");

            Pote potePequeno = new Pote("Pote Pequeno");

            Biscoito biscoito = new Biscoito("Biscoito de Morango");

            Biscoito bolo = new Biscoito("Bolo de Chocolate");

            poteGrande.AdicionarConteudo(poteMedio);
            poteMedio.AdicionarConteudo(potePequeno);
            potePequeno.AdicionarConteudo(biscoito);
            potePequeno.AdicionarConteudo(bolo);
        }

        #endregion Exemplo 3
    }
}