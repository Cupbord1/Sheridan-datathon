using Carbon.Core.Entities;


namespace Carbon.Core.DTOs;
public class ActivityDto
{
public ActivityCategory Category { get; set; }
public string Title { get; set; } = null!;
public DateTime Date { get; set; } = DateTime.UtcNow;
public double Quantity { get; set; }
public string? Unit { get; set; }
public string? Notes { get; set; }
}