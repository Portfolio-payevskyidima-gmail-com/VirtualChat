using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualChat.Repository.Migrations
{
    public partial class migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactStatus",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contactstatusid", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "NTEXT", nullable: false),
                    create_date = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_messageid", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatus",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "NVARCHAR(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_userstatusid", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "NVARCHAR(16)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "NVARCHAR(16)", nullable: false),
                    lastname = table.Column<string>(type: "NVARCHAR(16)", nullable: false),
                    patronymic = table.Column<string>(type: "NVARCHAR(16)", nullable: false),
                    create_date = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    update_date = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    birth_date = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    email = table.Column<string>(type: "NVARCHAR(32)", nullable: false),
                    phone_number = table.Column<string>(type: "NVARCHAR(12)", nullable: false),
                    status_id = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_userid", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_UserStatus_status_id",
                        column: x => x.status_id,
                        principalTable: "UserStatus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "NVARCHAR(32)", nullable: false),
                    created_date = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UserId = table.Column<int>(type: "INT", nullable: false),
                    CompanionUserId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_chatid", x => x.id);
                    table.ForeignKey(
                        name: "FK_Chat_User_CompanionUserId",
                        column: x => x.CompanionUserId,
                        principalTable: "User",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Chat_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contact_name = table.Column<string>(type: "NVARCHAR(32)", nullable: false),
                    StatusId = table.Column<int>(type: "INT", nullable: false),
                    UserId = table.Column<int>(type: "INT", nullable: false),
                    ContactUserId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contactid", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contact_ContactStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "ContactStatus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_User_ContactUserId",
                        column: x => x.ContactUserId,
                        principalTable: "User",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Contact_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatMessage",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatId = table.Column<int>(type: "INT", nullable: false),
                    MessageId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_chatmessageid", x => x.id);
                    table.ForeignKey(
                        name: "FK_ChatMessage_Chat_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chat",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatMessage_Message_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Message",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chat_CompanionUserId",
                table: "Chat",
                column: "CompanionUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_UserId",
                table: "Chat",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_ChatId",
                table: "ChatMessage",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_MessageId",
                table: "ChatMessage",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ContactUserId",
                table: "Contact",
                column: "ContactUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_StatusId",
                table: "Contact",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserId",
                table: "Contact",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_status_id",
                table: "User",
                column: "status_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMessage");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "ContactStatus");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserStatus");
        }
    }
}
