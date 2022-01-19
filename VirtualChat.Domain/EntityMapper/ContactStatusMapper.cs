using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualChat.Domain.Models;

namespace VirtualChat.Domain.EntityMapper;

/// <summary>
/// ContactStatus Mapper
/// </summary>
public class ContactStatusMapper : IEntityTypeConfiguration<ContactStatus>
{
    public void Configure(EntityTypeBuilder<ContactStatus> builder)
    {
        // Primary Key
        builder.HasKey(x => x.Id)
            .HasName("pk_contactstatusid");

        // Foreing References
        builder.HasMany(x => x.Contacts)
            .WithOne(x => x.Status)
            .HasForeignKey(x => x.StatusId);

        // Properties
        builder.Property(x => x.Id)
            .HasColumnName(@"id")
            .HasColumnType("NVARCHAR(36)")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName(@"Name")
            .HasColumnType("NVARCHAR(10)")
            .IsRequired();
    }
}