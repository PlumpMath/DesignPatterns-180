namespace State.Exemplo1
{
    public class Estado2 : IComportamento
    {
        public IComportamento MudaComportamento()
        {
            return new Estado1();
        }
    }
}