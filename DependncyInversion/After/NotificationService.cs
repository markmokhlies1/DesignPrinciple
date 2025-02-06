namespace After
{
    internal class NotificationService
    {
        public readonly List<IMessageService> _services;

        // Constructor Injection
        public NotificationService(List<IMessageService> services)
        {
            _services = services;
        }
        public void Notify()
        {

            foreach (var service in _services)
            {
                service.Send();
            }
        }
    }
}
