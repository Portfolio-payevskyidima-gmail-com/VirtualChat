using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualChat.Domain.Models;

namespace VirtualChat.Domain.EntityMapper;

/// <summary>
/// Message mapper
/// </summary>
public class MessageMapper : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        // Primary Key
        builder.HasKey(x => x.Id)
            .HasName("pk_messageid");

        // Foreing References
        builder.HasMany(x => x.ChatMessages)
            .WithOne(x => x.Message)
            .HasForeignKey(x => x.MessageId)
            .OnDelete(DeleteBehavior.NoAction);


        // Properties
        builder.Property(x => x.Id)
            .HasColumnName(@"id")
            .HasColumnType("NVARCHAR(36)")
            .IsRequired();

        builder.Property(x => x.Text)
            .HasColumnName(@"text")
            .HasColumnType("NTEXT")
            .IsRequired();

        builder.Property(x => x.CreatedDate)
            .HasColumnName(@"create_date")
            .HasColumnType("DATETIME")
            .IsRequired();
    }
}