using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VirtualChat.Domain.EntityMapper;

namespace VirtualChat.Repository;

/// <summary>
/// Data context of virtual chat
/// </summary>
public class VirtalChatDbContext : DbContext
{
    /// <summary>
    /// Constructor of virtual chat db context
    /// </summary>
    /// <param name="options">Option with connetction string or others configuration of connection</param>
    public VirtalChatDbContext(DbContextOptions options) : base(options) { }

    /// <summary>
    /// Model creator by mappers
    /// </summary>
    /// <param name="builder">Model builder</param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ChatMapper());
        builder.ApplyConfiguration(new ChatMessageMapper());
        builder.ApplyConfiguration(new ContactMapper());
        builder.ApplyConfiguration(new ContactStatusMapper());
        builder.ApplyConfiguration(new MessageMapper());
        builder.ApplyConfiguration(new UserMapper());
        builder.ApplyConfiguration(new UserStatusMapper());
        
        base.OnModelCreating(builder);
    }
}