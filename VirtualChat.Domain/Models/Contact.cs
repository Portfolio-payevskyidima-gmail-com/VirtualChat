namespace VirtualChat.Domain.Models;

/// <summary>
/// Contact
/// </summary>
public class Contact
{
    // Main properties
    public int Id { get; set; }
    public string ContactName { get; set; }

    // Foreign key references
    public int StatusId { get; set; }
    public ContactStatus Status { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int ContactUserId { get; set; }
    public User ContactUser { get; set; }
}