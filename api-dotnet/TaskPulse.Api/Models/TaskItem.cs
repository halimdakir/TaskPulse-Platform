namespace TaskPulse.Api.Models;

public class TaskItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Ttile{get;set;} = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueTime { get; set; }
    public string Status { get; set; } = "Open";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
}

