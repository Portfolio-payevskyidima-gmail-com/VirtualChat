using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualChat.Domain.Models;

namespace VirtualChat.Domain.EntityMapper;

/// <summary>
/// User mapper
/// </summary>
public class UserMapper : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Primary Key
        builder.HasKey(x => x.Id)
            .HasName("pk_userid");

        // Foreing References
        builder.HasMany(x => x.MyChats)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.ChatsWithMe)
            .WithOne(x => x.CompanionUser)
            .HasForeignKey(x => x.CompanionUserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.MyContacts)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.ContactsWithMe)
            .WithOne(x => x.ContactUser)
            .HasForeignKey(x => x.ContactUserId)
            .OnDelete(DeleteBehavior.NoAction);


        // Properties
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id")
            .HasColumnType("INT")
            .IsRequired();

        builder.Property(x => x.StatusId)
            .HasColumnName(@"status_id")
            .HasColumnType("INT")
            .IsRequired(false);

        builder.Property(x => x.Username)
            .HasColumnName(@"username")
            .HasColumnType("NVARCHAR(16)")
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName(@"name")
            .HasColumnType("NVARCHAR(16)");

        builder.Property(x => x.Lastname)
            .HasColumnName(@"lastname")
            .HasColumnType("NVARCHAR(16)");

        builder.Property(x => x.Patronymic)
            .HasColumnName(@"patronymic")
            .HasColumnType("NVARCHAR(16)");

        builder.Property(x => x.CreatedDate)
            .HasColumnName(@"create_date")
            .HasColumnType("DATETIME")
            .IsRequired();

        builder.Property(x => x.UpdatedDate)
            .HasColumnName(@"update_date")
            .HasColumnType("DATETIME")
            .IsRequired();

        builder.Property(x => x.BirthDate)
            .HasColumnName(@"birth_date")
            .HasColumnType("DATETIME");

        builder.Property(x => x.Email)
            .HasColumnName(@"email")
            .HasColumnType("NVARCHAR(32)")
            .IsRequired();

        builder.Property(x => x.PhoneNumber)
            .HasColumnName(@"phone_number")
            .HasColumnType("NVARCHAR(12)");
    }
}