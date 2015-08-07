namespace Proxy.Exemplo1
{
    public class Proxy : ISubject
    {
        private Subject _subject;

        public Proxy()
        {
            _subject = new Subject();
        }

        public void Operation()
        {
            _subject.Operation();
        }
    }
}