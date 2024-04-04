namespace KunsthausEventScanner.src.model.state
{
    public class IsScannedState : ITicketState
    {
        public string Handle()
        {
            return "IsScanned";
        }
    }
}
