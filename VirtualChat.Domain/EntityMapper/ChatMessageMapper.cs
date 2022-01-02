using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualChat.Domain.Models;

namespace VirtualChat.Domain.EntityMapper;

/// <summary>
/// Chat Message Mapper
/// </summary>
public class ChatMessageMapper : IEntityTypeConfiguration<ChatMessage>
{
    public void Configure(EntityTypeBuilder<ChatMessage> builder)
    {
        // Primary Key
        builder.HasKey(x => x.Id)
            .HasName("pk_chatmessageid");

        // Foreing References

        // Properties
        builder.Property(x => x.Id)
            .HasColumnName(@"id")
            .HasColumnType("INT")
            .IsRequired();
    }
}