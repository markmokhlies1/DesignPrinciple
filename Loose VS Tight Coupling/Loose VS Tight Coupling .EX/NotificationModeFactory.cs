namespace Loose_VS_Tight_Coupling_.EX
{
    class NotificationModeFactory
    {
        public static INotifactionMode Create(NotificationMode mode)
        {
            switch (mode)
            {
                case NotificationMode.EMAIL:
                    return new EmailServices();

                case NotificationMode.SMS:
                    return new SmsServices();

                case NotificationMode.WEIRD:
                    return new WeirdServices();

                default:
                    return new EmailServices();
            }
        }
    }
}
