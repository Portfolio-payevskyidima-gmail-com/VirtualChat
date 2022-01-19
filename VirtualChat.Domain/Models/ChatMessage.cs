namespace VirtualChat.Domain.Models;

/// <summary>
/// Chat Messanger
/// </summary>
public class ChatMessage
{
    // Main properties
    public string Id { get; set; }

    // Foreign key references
    public string ChatId { get; set; }
    public Chat Chat { get; set; }

    public string MessageId { get; set; }
    public Message Message { get; set; }
}