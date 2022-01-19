using Microsoft.AspNetCore.Identity;

namespace VirtualChat.Domain.Models;

/// <summary>
/// User
/// </summary>
public class User
{
    // Main properties
    // Identity 
    public string Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Patronymic { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    // Foreign key references
    public string StatusId { get; set; }
    public UserStatus Status { get; set; }

    // Many-Collections for Foreign keys
    public ICollection<Chat> MyChats { get; set; }
    public ICollection<Chat> ChatsWithMe { get; set; }
    public ICollection<Contact> MyContacts { get; set; }
    public ICollection<Contact> ContactsWithMe { get; set; }
}