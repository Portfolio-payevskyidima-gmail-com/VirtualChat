using VirtualChat.Domain.Models;
using VirtualChat.Repository.Repository;

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
    public void CreateUserStatus(UserStatus status)
    {
        UserStatusCheckNull(status);
        _userStatus.Create(status);
        _userStatus.SaveChanges();
    }

    public void DeleteUserStatus(int? id)
    {
        if (id == null) throw new ArgumentNullException("id");
        UserStatus status = _userStatus.Get(id.Value);
        UserStatusCheckNull(status);
        _userStatus.Delete(status.Id);
        _userStatus.SaveChanges();
    }

    public UserStatus GetUserStatus(int? id)
    {
        if (id == null) throw new ArgumentNullException("id");
        UserStatus status = _userStatus.Get(id.Value);
        UserStatusCheckNull(status);
        return status;
    }

    public void UpdateUserStatus(UserStatus status)
    {
        UserStatusCheckNull(status);
        _userStatus.Update(status);
        _userStatus.SaveChanges();
    }

    public IEnumerable<UserStatus> GetAllUserStatuses()
    {
        return _userStatus.GetAll();
    }
    #endregion

    #region Private methods
    private void UserStatusCheckNull(UserStatus status)
    {
        if (status == null)
        {
            throw new NullReferenceException("status");
        }
    }
    #endregion
}