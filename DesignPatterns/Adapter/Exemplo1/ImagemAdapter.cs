namespace Adapter.Exemplo1
{
    public class ImagemAdapter
    {
        public Foto ConverteImagem(IImagem imagemAPI)
        {
            Foto imagemAplicacao = new Foto();

            imagemAplicacao.Dimensao = new double[] { imagemAPI.Largura, imagemAPI.Altura };

            return imagemAplicacao;
        }
    }
}