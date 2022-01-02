using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualChat.Domain.Models;

namespace VirtualChat.Domain.EntityMapper;

/// <summary>
/// User status mapper
/// </summary>
public class UserStatusMapper : IEntityTypeConfiguration<UserStatus>
{
    public void Configure(EntityTypeBuilder<UserStatus> builder)
    {
        // Primary Key
        builder.HasKey(x => x.Id)
            .HasName("pk_userstatusid");

        // Foreing References
        builder.HasMany(x => x.Users)
            .WithOne(x => x.Status)
            .HasForeignKey(x => x.StatusId)
            .OnDelete(DeleteBehavior.SetNull);

        // Properties
        builder.Property(x => x.Id)
            .HasColumnName(@"id")
            .HasColumnType("INT")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName(@"name")
            .HasColumnType("NVARCHAR(10)")
            .IsRequired();
    }
}