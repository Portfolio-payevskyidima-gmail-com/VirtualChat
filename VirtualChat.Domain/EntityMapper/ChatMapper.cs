using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualChat.Domain.Models;

namespace VirtualChat.Domain.EntityMapper;

/// <summary>
/// Chat Mapper
/// </summary>
public class ChatMapper : IEntityTypeConfiguration<Chat>
{
    public void Configure(EntityTypeBuilder<Chat> builder)
    {
        // Primary Key
        builder.HasKey(x => x.Id)
            .HasName("pk_chatid");

        // Foreign References
        builder.HasMany(x => x.ChatMessages)
            .WithOne(x => x.Chat)
            .HasForeignKey(x => x.ChatId)
            .OnDelete(DeleteBehavior.Cascade);

        // Properies
        builder.Property(x => x.Id)
            .HasColumnName(@"id")
            .HasColumnType("INT")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName(@"name")
            .HasColumnType("NVARCHAR(32)")
            .IsRequired();

        builder.Property(x => x.CreatedDate)
            .HasColumnName(@"created_date")
            .HasColumnType("DATETIME")
            .IsRequired();
    }
}