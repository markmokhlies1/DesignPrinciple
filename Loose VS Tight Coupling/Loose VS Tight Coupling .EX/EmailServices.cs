namespace Loose_VS_Tight_Coupling_.EX
{
    public class EmailServices : INotifactionMode
    {
        public void Send()
        {
            Console.WriteLine("Email Send ");
        }
    }
}
