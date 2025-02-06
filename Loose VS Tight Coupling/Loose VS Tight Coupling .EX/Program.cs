namespace Loose_VS_Tight_Coupling_.EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceMode = NotificationModeFactory.Create(NotificationMode.WEIRD);
            NotifactionServices notificationService = new NotifactionServices(serviceMode);
            notificationService.Notify();
            Console.ReadKey();
        }
    }
}
