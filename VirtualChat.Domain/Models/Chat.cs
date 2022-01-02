namespace VirtualChat.Domain.Models;

/// <summary>
/// Chat
/// </summary>
public class Chat
{
    // Main properties
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }

    // Foreign key references
    public int UserId { get; set; }
    public User User { get; set; }

    public int CompanionUserId { get; set; }
    public User CompanionUser { get; set; }


    // Many-Collections for Foreign keys
    public ICollection<ChatMessage> ChatMessages { get; set; }
}