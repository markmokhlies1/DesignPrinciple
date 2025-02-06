namespace Loose_VS_Tight_Coupling_.EX
{
    public class SmsServices : INotifactionMode
    {
        public void Send()
        {
            Console.WriteLine("Sms Send ");
        }
    }
}
