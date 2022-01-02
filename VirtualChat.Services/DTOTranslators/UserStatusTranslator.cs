using VirtualChat.Domain.Models;
using VirtualChat.Core.DTOs.UserStatusDTO;

namespace VirtualChat.Services.DTOTranslators;

/// <summary>
/// User status translator from DTO to entity and from entity to DTO
/// </summary>
public class UserStatusTranslator : IUserStatusTranslator
{
    #region Properties
    private UserStatus _userStatusEntity;
    private UserStatusDTO _userStatusDTO;
    private BaseUserStatusDTO _baseUserStatusDTO;
    #endregion

    #region Constructors
    public UserStatusTranslator(UserStatus entity)
    {
        _userStatusEntity = entity;
        _userStatusDTO = new UserStatusDTO
        {
            Id = entity.Id,
            Name = entity.Name
        };
        _baseUserStatusDTO = new BaseUserStatusDTO
        {
            Name = entity.Name
        };
    }

    public UserStatusTranslator(UserStatusDTO DTO)
    {
        _userStatusDTO = DTO;
        _userStatusEntity = new UserStatus
        {
            Id = DTO.Id,
            Name = DTO.Name
        };
        _baseUserStatusDTO = new BaseUserStatusDTO
        {
            Name = DTO.Name
        };
    }

    public UserStatusTranslator(BaseUserStatusDTO baseDTO)
    {
        _baseUserStatusDTO = baseDTO;
        _userStatusDTO = new UserStatusDTO
        {
            Name = baseDTO.Name
        };
        _userStatusEntity = new UserStatus
        {
            Name = baseDTO.Name
        };
    }
    #endregion

    #region Public Methods
    public UserStatusDTO GetDTO()
    {
        if (_userStatusDTO == null) throw new NullReferenceException(nameof(_userStatusEntity));
        return _userStatusDTO;
    }
    public BaseUserStatusDTO GetBaseDTO()
    {
        if (_userStatusDTO == null) throw new NullReferenceException(nameof(_userStatusEntity));
        return _baseUserStatusDTO;
    }
    public UserStatus GetEntity()
    {
        if (_userStatusEntity == null) throw new NullReferenceException(nameof(_userStatusEntity));
        return _userStatusEntity;
    }
    #endregion
}