namespace VirtualChat.Domain.Models;

/// <summary>
/// User status
/// </summary>
public class UserStatus
{
    // Main properties
    public string Id { get; set; }
    public string Name { get; set; }

    // Many-Collections for Foreign keys
    public ICollection<User> Users { get; set; }
}