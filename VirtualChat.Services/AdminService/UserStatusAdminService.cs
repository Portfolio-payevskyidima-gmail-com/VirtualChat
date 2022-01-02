using VirtualChat.Core.DTOs.UserStatusDTO;
using VirtualChat.Domain.Models;
using VirtualChat.Repository.Repository;
using VirtualChat.Services.DTOTranslaters;

namespace VirtualChat.Services.AdminService;

public class UserStatusAdminService : IUserStatusAdminService
{
    #region Properties
    private IRepository<UserStatus> _userStatus;
    #endregion

    #region Constructor
    public UserStatusAdminService(IRepository<UserStatus> repository)
    {
        _userStatus = repository;
    }
    #endregion

    #region Methods
    public void CreateUserStatus(BaseUserStatusDTO status)
    {
        CheckNull(status);
        IUserStatusTranslater translater = new UserStatusTranslater(status);
        UserStatus userStatus = translater.GetEntity();
        _userStatus.Create(userStatus);
        _userStatus.SaveChanges();
    }

    public void DeleteUserStatus(int? id)
    {
        if (id == null) throw new ArgumentNullException("id");
        UserStatus status = _userStatus.Get(id.Value);
        CheckNull(status);
        _userStatus.Delete(status.Id);
        _userStatus.SaveChanges();
    }

    public UserStatusDTO GetUserStatus(int? id)
    {
        if (id == null) throw new ArgumentNullException("id");
        UserStatus status = _userStatus.Get(id.Value);
        CheckNull(status);
        IUserStatusTranslater translater = new UserStatusTranslater(status);
        UserStatusDTO userStatus = translater.GetDTO();
        return userStatus;
    }

    public void UpdateUserStatus(UserStatusDTO status)
    {
        CheckNull(status);
        IUserStatusTranslater translater = new UserStatusTranslater(status);
        UserStatus userStatus = translater.GetEntity();
        _userStatus.Update(userStatus);
        _userStatus.SaveChanges();
    }

    public IEnumerable<UserStatusDTO> GetAllUserStatuses()
    {
        IList<UserStatusDTO> userStatusDTOs = new List<UserStatusDTO>();
        IEnumerable<UserStatus> userStatuses = _userStatus.GetAll();
        IUserStatusTranslater translater = null;
        foreach(var item in userStatuses)
        {
            translater = new UserStatusTranslater(item);
            UserStatusDTO userStatusDTO = translater.GetDTO();
            userStatusDTOs.Add(userStatusDTO);
        }
        return userStatusDTOs;
    }
    #endregion

    #region Private methods
    private void CheckNull(object status)
    {
        if (status == null)
        {
            throw new NullReferenceException("status");
        }
    }
    #endregion
}