using KunsthausEventScanner.src.model.state;

public class Ticket
{
    public int TicketID { get; set; }
    public string TicketNumber { get; set; }
    public int EventID { get; set; }
    public Event Event { get; set; }
    public ITicketState Status { get; set; }
    public int Hash { get; private set; }


    public Ticket()
    {
        this.Status = new IsNotScannedState();
    }

    public void UpdateHash()
    {
        this.Hash = this.GetHashCode();
    }

    private int GetHashCode()
    {
        return this.TicketID.GetHashCode() ^ this.TicketNumber.GetHashCode() ^ this.EventID.GetHashCode();
    }

    public string GetStatus()
    {
        return this.Status.Handle();
    }

}
