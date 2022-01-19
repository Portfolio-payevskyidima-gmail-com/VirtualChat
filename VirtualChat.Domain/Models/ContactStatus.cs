namespace VirtualChat.Domain.Models;

/// <summary>
/// Contact status
/// </summary>
public class ContactStatus
{
    // Main properties
    public string Id { get; set; }
    public string Name { get; set; }

    // Many-Collections for Foreign keys
    public ICollection<Contact> Contacts { get; set; }
}