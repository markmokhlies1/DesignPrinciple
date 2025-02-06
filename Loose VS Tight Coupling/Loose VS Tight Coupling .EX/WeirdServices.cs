namespace Loose_VS_Tight_Coupling_.EX
{
    public class WeirdServices : INotifactionMode
    {
        public void Send()
        {
            Console.WriteLine("WeirdServices send ");
        }
    }
}
