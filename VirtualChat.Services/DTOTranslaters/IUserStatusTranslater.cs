using VirtualChat.Domain.Models;
using VirtualChat.Core.DTOs.UserStatusDTO;

namespace VirtualChat.Services.DTOTranslaters;

/// <summary>
/// Tranlate user status entity to DTO and vice versa
/// </summary>
public interface IUserStatusTranslater
{
    UserStatusDTO GetDTO();
    BaseUserStatusDTO GetBaseDTO();
    UserStatus GetEntity();
}