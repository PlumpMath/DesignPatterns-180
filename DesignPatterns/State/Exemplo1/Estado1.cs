namespace State.Exemplo1
{
    public class Estado1 : IComportamento
    {
        public IComportamento MudaComportamento()
        {
            return new Estado2();
        }
    }
}