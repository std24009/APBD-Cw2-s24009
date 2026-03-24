namespace APBD_Cw2_s24009.Models;

public class Reservation(WorkTool workTool, User user, DateTime from, DateTime to)
{
    private static int _nextId = 1;

    public int Id { get; set; } = _nextId++;
    public WorkTool WorkTool { get; set; } = workTool;
    public User User { get; set; } = user;
    public DateTime From { get; set; } = from >= to ? throw new ArgumentException("Invalid date") : from;
    public DateTime To { get; set; } = to;
    
}