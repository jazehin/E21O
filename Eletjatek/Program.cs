namespace Eletjatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EletjatekSzimulator sz = new(10, 10);
            do
            {
                sz.Run();
            } while (!Console.KeyAvailable);
        }
    }
}