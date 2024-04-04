using Microsoft.EntityFrameworkCore;

public class EventService
{
    private readonly MyDbContext _context;

    public EventService(MyDbContext context)
    {
        _context = context;
    }

    public Event GetEvent(int id)
    {
        return _context.Events.Find(id);
    }

    public void CreateEvent(Event eventEntity)
    {
        _context.Events.Add(eventEntity);
        _context.SaveChanges();
    }

    // Other methods to handle event operations...
}
