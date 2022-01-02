namespace VirtualChat.Domain.Models;

/// <summary>
/// Message 
/// </summary>
public class Message
{
    // Main properties
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedDate{ get; set; } = DateTime.Now;

    // Many-Collections for Foreign keys
    public ICollection<ChatMessage> ChatMessages { get; set;}
}