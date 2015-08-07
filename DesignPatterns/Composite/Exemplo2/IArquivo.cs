namespace Composite.Exemplo2
{
    public interface IArquivo
    {
        int Nivel { get; set; }
        string Nome { get; set; }

        // Este método poderia ficar aqui, e seria implementado em ambos Arquivo e Pasta, mas
        // não faria sentido em Arquivo.
        // Se for necessário que se conheça o tipo apenas em momento de execução
        // o método deve estar descomentado.

        //void Adicionar(IArquivo arquivo);

        void Imprimir();
    }
}