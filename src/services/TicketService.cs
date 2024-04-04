using KunsthausEventScanner.src.model.state;
using QRCoder;
using System.Drawing;

public class TicketService
{
    private readonly MyDbContext _context;

    public TicketService(MyDbContext context)
    {
        _context = context;
    }

    public void ScanTicket(Ticket ticket)
    {
        ticket.Status = new IsScannedState();
        _context.SaveChanges();
    }

    public Ticket GetTicket(int id)
    {
        return _context.Tickets.Find(id);
    }

    public void AddTicket(Ticket ticket)
    {
        _context.Tickets.Add(ticket);
        _context.SaveChanges();
    }

    public Bitmap GenerateQrCode(Ticket ticket)
    {
        var qrGenerator = new QRCodeGenerator();
        var qrCodeData = qrGenerator.CreateQrCode(ticket.Hash.ToString(), QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        return qrCode.GetGraphic(20);
    }
}
