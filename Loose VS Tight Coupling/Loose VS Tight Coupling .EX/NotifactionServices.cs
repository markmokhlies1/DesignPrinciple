namespace Loose_VS_Tight_Coupling_.EX
{
    public class NotifactionServices
    {
        private INotifactionMode _mode;
        public NotifactionServices(INotifactionMode mode )
        {
            _mode = mode;
        }
        public void Notify()
        {
            _mode.Send();
        }
    }
}
