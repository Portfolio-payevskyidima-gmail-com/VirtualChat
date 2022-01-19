﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualChat.Repository;

#nullable disable

namespace VirtualChat.Repository.Migrations
{
    [DbContext(typeof(VirtalChatDbContext))]
    [Migration("20220119152225_string-pk2")]
    partial class stringpk2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VirtualChat.Domain.Models.Chat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("id");

                    b.Property<string>("CompanionUserId")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("companionuser_id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("created_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(32)")
                        .HasColumnName("name");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_chatid");

                    b.HasIndex("CompanionUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.ChatMessage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("id");

                    b.Property<string>("ChatId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("chat_id");

                    b.Property<string>("MessageId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("message_id");

                    b.HasKey("Id")
                        .HasName("pk_chatmessageid");

                    b.HasIndex("ChatId");

                    b.HasIndex("MessageId");

                    b.ToTable("ChatMessage");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("id");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(32)")
                        .HasColumnName("contact_name");

                    b.Property<string>("ContactUserId")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("contactuser_id");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("status_id");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_contactid");

                    b.HasIndex("ContactUserId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.ContactStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("Name");

                    b.HasKey("Id")
                        .HasName("pk_contactstatusid");

                    b.ToTable("ContactStatus");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.Message", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("create_date");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("NTEXT")
                        .HasColumnName("text");

                    b.HasKey("Id")
                        .HasName("pk_messageid");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("birth_date");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("create_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(32)")
                        .HasColumnName("email");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(16)")
                        .HasColumnName("lastname");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(16)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(16)")
                        .HasColumnName("patronymic");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(12)")
                        .HasColumnName("phone_number");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("status_id");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("DATETIME")
                        .HasColumnName("update_date");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(16)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_userid");

                    b.HasIndex("StatusId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.UserStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR(36)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_userstatusid");

                    b.ToTable("UserStatus");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.Chat", b =>
                {
                    b.HasOne("VirtualChat.Domain.Models.User", "CompanionUser")
                        .WithMany("ChatsWithMe")
                        .HasForeignKey("CompanionUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VirtualChat.Domain.Models.User", "User")
                        .WithMany("MyChats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanionUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.ChatMessage", b =>
                {
                    b.HasOne("VirtualChat.Domain.Models.Chat", "Chat")
                        .WithMany("ChatMessages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualChat.Domain.Models.Message", "Message")
                        .WithMany("ChatMessages")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Message");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.Contact", b =>
                {
                    b.HasOne("VirtualChat.Domain.Models.User", "ContactUser")
                        .WithMany("ContactsWithMe")
                        .HasForeignKey("ContactUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VirtualChat.Domain.Models.ContactStatus", "Status")
                        .WithMany("Contacts")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualChat.Domain.Models.User", "User")
                        .WithMany("MyContacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContactUser");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.User", b =>
                {
                    b.HasOne("VirtualChat.Domain.Models.UserStatus", "Status")
                        .WithMany("Users")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.Chat", b =>
                {
                    b.Navigation("ChatMessages");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.ContactStatus", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.Message", b =>
                {
                    b.Navigation("ChatMessages");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.User", b =>
                {
                    b.Navigation("ChatsWithMe");

                    b.Navigation("ContactsWithMe");

                    b.Navigation("MyChats");

                    b.Navigation("MyContacts");
                });

            modelBuilder.Entity("VirtualChat.Domain.Models.UserStatus", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
