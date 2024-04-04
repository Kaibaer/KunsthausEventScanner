namespace KunsthausEventScanner.src.model.state
{
    public class IsNotScannedState : ITicketState
    {
        public string Handle()
        {
            return "IsNotScanned";
        }
    }
}
