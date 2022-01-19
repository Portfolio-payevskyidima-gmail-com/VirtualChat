using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualChat.Domain.Models;

namespace VirtualChat.Domain.EntityMapper;

/// <summary>
/// Contact mapper
/// </summary>
public class ContactMapper : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        // Primary Key
        builder.HasKey(x => x.Id)
            .HasName("pk_contactid");

        // Foreing References

        // Properties
        builder.Property(x => x.Id)
            .HasColumnName(@"id")
            .HasColumnType("NVARCHAR(36)")
            .IsRequired();

        builder.Property(x => x.StatusId)
            .HasColumnName(@"status_id")
            .HasColumnType("NVARCHAR(36)")
            .IsRequired();

        builder.Property(x => x.UserId)
            .HasColumnName(@"user_id")
            .HasColumnType("NVARCHAR(36)")
            .IsRequired(false);

        builder.Property(x => x.ContactUserId)
            .HasColumnName(@"contactuser_id")
            .HasColumnType("NVARCHAR(36)")
            .IsRequired(false);

        builder.Property(x => x.ContactName)
            .HasColumnName(@"contact_name")
            .HasColumnType("NVARCHAR(32)")
            .IsRequired();
    }
}