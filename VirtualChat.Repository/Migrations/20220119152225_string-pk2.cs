using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualChat.Repository.Migrations
{
    public partial class stringpk2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chat_User_CompanionUserId",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_Chat_User_UserId",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_Chat_ChatId",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_Message_MessageId",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_ContactStatus_StatusId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_User_ContactUserId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_User_UserId",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Contact",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Contact",
                newName: "status_id");

            migrationBuilder.RenameColumn(
                name: "ContactUserId",
                table: "Contact",
                newName: "contactuser_id");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_UserId",
                table: "Contact",
                newName: "IX_Contact_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_StatusId",
                table: "Contact",
                newName: "IX_Contact_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_ContactUserId",
                table: "Contact",
                newName: "IX_Contact_contactuser_id");

            migrationBuilder.RenameColumn(
                name: "MessageId",
                table: "ChatMessage",
                newName: "message_id");

            migrationBuilder.RenameColumn(
                name: "ChatId",
                table: "ChatMessage",
                newName: "chat_id");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessage_MessageId",
                table: "ChatMessage",
                newName: "IX_ChatMessage_message_id");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessage_ChatId",
                table: "ChatMessage",
                newName: "IX_ChatMessage_chat_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Chat",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "CompanionUserId",
                table: "Chat",
                newName: "companionuser_id");

            migrationBuilder.RenameIndex(
                name: "IX_Chat_UserId",
                table: "Chat",
                newName: "IX_Chat_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Chat_CompanionUserId",
                table: "Chat",
                newName: "IX_Chat_companionuser_id");

            migrationBuilder.AlterColumn<string>(
                name: "status_id",
                table: "User",
                type: "NVARCHAR(36)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "User",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Message",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "ContactStatus",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Contact",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "Contact",
                type: "NVARCHAR(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "status_id",
                table: "Contact",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "contactuser_id",
                table: "Contact",
                type: "NVARCHAR(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "ChatMessage",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "message_id",
                table: "ChatMessage",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "chat_id",
                table: "ChatMessage",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Chat",
                type: "NVARCHAR(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "Chat",
                type: "NVARCHAR(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "companionuser_id",
                table: "Chat",
                type: "NVARCHAR(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR");

            migrationBuilder.AddForeignKey(
                name: "FK_Chat_User_companionuser_id",
                table: "Chat",
                column: "companionuser_id",
                principalTable: "User",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chat_User_user_id",
                table: "Chat",
                column: "user_id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_Chat_chat_id",
                table: "ChatMessage",
                column: "chat_id",
                principalTable: "Chat",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_Message_message_id",
                table: "ChatMessage",
                column: "message_id",
                principalTable: "Message",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_ContactStatus_status_id",
                table: "Contact",
                column: "status_id",
                principalTable: "ContactStatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_User_contactuser_id",
                table: "Contact",
                column: "contactuser_id",
                principalTable: "User",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_User_user_id",
                table: "Contact",
                column: "user_id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chat_User_companionuser_id",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_Chat_User_user_id",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_Chat_chat_id",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_Message_message_id",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_ContactStatus_status_id",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_User_contactuser_id",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_User_user_id",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Contact",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "status_id",
                table: "Contact",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "contactuser_id",
                table: "Contact",
                newName: "ContactUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_user_id",
                table: "Contact",
                newName: "IX_Contact_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_status_id",
                table: "Contact",
                newName: "IX_Contact_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_contactuser_id",
                table: "Contact",
                newName: "IX_Contact_ContactUserId");

            migrationBuilder.RenameColumn(
                name: "message_id",
                table: "ChatMessage",
                newName: "MessageId");

            migrationBuilder.RenameColumn(
                name: "chat_id",
                table: "ChatMessage",
                newName: "ChatId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessage_message_id",
                table: "ChatMessage",
                newName: "IX_ChatMessage_MessageId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatMessage_chat_id",
                table: "ChatMessage",
                newName: "IX_ChatMessage_ChatId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Chat",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "companionuser_id",
                table: "Chat",
                newName: "CompanionUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Chat_user_id",
                table: "Chat",
                newName: "IX_Chat_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Chat_companionuser_id",
                table: "Chat",
                newName: "IX_Chat_CompanionUserId");

            migrationBuilder.AlterColumn<string>(
                name: "status_id",
                table: "User",
                type: "NVARCHAR(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "User",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Message",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "ContactStatus",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Contact",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Contact",
                type: "NVARCHAR",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusId",
                table: "Contact",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactUserId",
                table: "Contact",
                type: "NVARCHAR",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "ChatMessage",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "MessageId",
                table: "ChatMessage",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "ChatId",
                table: "ChatMessage",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Chat",
                type: "NVARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Chat",
                type: "NVARCHAR",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanionUserId",
                table: "Chat",
                type: "NVARCHAR",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(36)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chat_User_CompanionUserId",
                table: "Chat",
                column: "CompanionUserId",
                principalTable: "User",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chat_User_UserId",
                table: "Chat",
                column: "UserId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_Chat_ChatId",
                table: "ChatMessage",
                column: "ChatId",
                principalTable: "Chat",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_Message_MessageId",
                table: "ChatMessage",
                column: "MessageId",
                principalTable: "Message",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_ContactStatus_StatusId",
                table: "Contact",
                column: "StatusId",
                principalTable: "ContactStatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_User_ContactUserId",
                table: "Contact",
                column: "ContactUserId",
                principalTable: "User",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_User_UserId",
                table: "Contact",
                column: "UserId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
