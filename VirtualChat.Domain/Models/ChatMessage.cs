namespace VirtualChat.Domain.Models;

/// <summary>
/// Chat Messanger
/// </summary>
public class ChatMessage
{
    // Main properties
    public int Id { get; set; }

    // Foreign key references
    public int ChatId { get; set; }
    public Chat Chat { get; set; }

    public int MessageId { get; set; }
    public Message Message { get; set; }
}