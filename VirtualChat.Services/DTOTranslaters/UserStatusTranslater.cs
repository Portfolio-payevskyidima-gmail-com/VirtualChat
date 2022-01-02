using VirtualChat.Domain.Models;
using VirtualChat.Core.DTOs.UserStatusDTO;

namespace VirtualChat.Services.DTOTranslaters;

/// <summary>
/// User status translator from DTO to entity and from entity to DTO
/// </summary>
public class UserStatusTranslater : IUserStatusTranslater
{
    #region Properties
    private UserStatus UserStatusEntity;
    private UserStatusDTO UserStatusDTO;
    #endregion

    #region Constructors
    public UserStatusTranslater(UserStatus entity)
    {
        UserStatusEntity = entity;
        UserStatusDTO = new UserStatusDTO
        {
            Id = entity.Id,
            Name = entity.Name
        };
    }

    public UserStatusTranslater(UserStatusDTO DTO)
    {
        UserStatusDTO = DTO;
        UserStatusEntity = new UserStatus
        {
            Id = DTO.Id,
            Name = DTO.Name
        };
    }

    public UserStatusTranslater(BaseUserStatusDTO baseDTO)
    {
        UserStatusDTO = (UserStatusDTO)baseDTO;
        UserStatusEntity = new UserStatus
        {
            Name = baseDTO.Name
        };
    }
    #endregion

    #region Public Methods
    public UserStatusDTO GetDTO()
    {
        if (UserStatusDTO == null) throw new NullReferenceException(nameof(UserStatusEntity));
        return UserStatusDTO;
    }
    public BaseUserStatusDTO GetBaseDTO()
    {
        if (UserStatusDTO == null) throw new NullReferenceException(nameof(UserStatusEntity));
        return (BaseUserStatusDTO)UserStatusDTO;
    }
    public UserStatus GetEntity()
    {
        if (UserStatusEntity == null) throw new NullReferenceException(nameof(UserStatusEntity));
        return UserStatusEntity;
    }
    #endregion
}