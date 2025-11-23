namespace Carbon.Core.Entities;


public class Activity
{
public int Id { get; set; }
public string UserId { get; set; } = null!; 
public ActivityCategory Category { get; set; }
public string Title { get; set; } = null!;
public DateTime Date { get; set; } = DateTime.UtcNow;
public double Quantity { get; set; }
public string? Unit { get; set; }
public double EmissionsKgCO2 { get; set; } 
public string? Notes { get; set; }
}