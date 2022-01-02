using VirtualChat.Core.DTOs.UserStatusDTO;

namespace VirtualChat.Services.Services.UserStatusAdminService;

/// <summary>
/// Adminitration service
/// </summary>
public interface IUserStatusAdminService
{
    /// <summary>
    /// Create new user status
    /// </summary>
    /// <param name="status">UserStatus entity</param>
    void CreateUserStatus(BaseUserStatusDTO status);
    /// <summary>
    /// Update existing user status
    /// </summary>
    /// <param name="status">UserStatus entity</param>
    void UpdateUserStatus(UserStatusDTO status);
    /// <summary>
    /// Delete existig users status
    /// </summary>
    /// <param name="status">User status</param>
    void DeleteUserStatus(int? id);
    /// <summary>
    /// Get UserStatus by Id
    /// </summary>
    /// <param name="id">UserStatus Id</param>
    /// <returns>UserStatus</returns>
    UserStatusDTO GetUserStatus(int? id);
    /// <summary>
    /// Get all UserStatuses
    /// </summary>
    /// <returns>Enumerable of UserStatus</returns>
    IEnumerable<UserStatusDTO> GetAllUserStatuses();
}