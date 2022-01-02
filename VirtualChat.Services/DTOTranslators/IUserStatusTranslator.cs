using VirtualChat.Domain.Models;
using VirtualChat.Core.DTOs.UserStatusDTO;

namespace VirtualChat.Services.DTOTranslators;

/// <summary>
/// Tranlate user status entity to DTO and vice versa
/// </summary>
public interface IUserStatusTranslator
{
    UserStatusDTO GetDTO();
    BaseUserStatusDTO GetBaseDTO();
    UserStatus GetEntity();
}