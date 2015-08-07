using Facade.Exemplo1.SubSystem;

namespace Facade.Exemplo1
{
    public static class Facade
    {
        private static SubSystemClassA SubSystemClassA = new SubSystemClassA();
        private static SubSystemClassB SubSystemClassB = new SubSystemClassB();

        public static void Operation()
        {
            SubSystemClassA.Operation1();
            SubSystemClassB.Operation2();
            SubSystemClassA.Operation3();
            SubSystemClassB.Operation4();
            SubSystemClassA.Operation5();
            SubSystemClassB.Operation6();
            SubSystemClassA.Operation7();
            SubSystemClassB.Operation8();
            SubSystemClassA.Operation9();
            SubSystemClassB.Operation10();
        }
    }
}