namespace VirtualChat.Domain.Models;

/// <summary>
/// Contact
/// </summary>
public class Contact
{
    // Main properties
    public string Id { get; set; }
    public string ContactName { get; set; }

    // Foreign key references
    public string StatusId { get; set; }
    public ContactStatus Status { get; set; }

    public string UserId { get; set; }
    public User User { get; set; }

    public string ContactUserId { get; set; }
    public User ContactUser { get; set; }
}