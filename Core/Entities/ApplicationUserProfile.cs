namespace Carbon.Core.Entities;


public class ApplicationUserProfile
{
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
    public DateTime? BirthDate { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
}