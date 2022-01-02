using Microsoft.AspNetCore.Mvc;
using VirtualChat.Core.DTOs.UserStatusDTO;
using VirtualChat.Services.Services.UserStatusAdminService;

namespace VirtualChat.API.Controllers;

/// <summary>
/// User Status Admin Controller
/// </summary>
[Route("virtualChatAPI/[controller]")]
[ApiController]
public class UserStatusAdminController : ControllerBase
{
    #region Properties
    private readonly IUserStatusAdminService _userStatusAdminService;
    #endregion

    #region Constructor
    public UserStatusAdminController(IUserStatusAdminService userStatusAdminService)
    {
        _userStatusAdminService = userStatusAdminService;
    }
    #endregion

    #region API Controllers
    /// <summary>
    /// Get user status by id
    /// </summary>
    /// <param name="id">Id of user status</param>
    /// <returns>JSON UserStatusDTO</returns>
    [HttpGet(nameof(GetUserStatus))]
    public IActionResult GetUserStatus(int? id)
    {
        UserStatusDTO status;
        try
        {
            status = _userStatusAdminService.GetUserStatus(id);
        }
        catch (Exception e)
        {
            return BadRequest($"ERROR: {e.Message}");
        }
        return Ok(status);
    }

    /// <summary>
    /// Get all user statuses
    /// </summary>
    /// <returns>ARRAY of JSON objects of UserStatusDTOs</returns>
    [HttpGet(nameof(GetAllUsersStatus))]
    public IActionResult GetAllUsersStatus()
    {
        IEnumerable<UserStatusDTO> statuses;
        try
        {
            statuses = _userStatusAdminService.GetAllUserStatuses();
        }
        catch (Exception e)
        {
            return BadRequest($"ERROR: {e.Message}");
        }
        return Ok(statuses);
    }

    /// <summary>
    /// Add UserStatus to db
    /// </summary>
    /// <param name="status">BaseUserStatusDTO</param>
    /// <returns></returns>
    [HttpPost(nameof(CreateUserStatus))]
    public IActionResult CreateUserStatus(BaseUserStatusDTO status)
    {
        try
        {
            _userStatusAdminService.CreateUserStatus(status);
        }
        catch (Exception e)
        {
            return BadRequest($"ERROR: {e.Message}");
        }
        return Ok();
    }

    /// <summary>
    /// Delete UserStatus from db
    /// </summary>
    /// <param name="id">Id of deleting UserStatus</param>
    /// <returns></returns>
    [HttpDelete(nameof(DeleteUserStatus))]
    public IActionResult DeleteUserStatus(int? id)
    {
        try
        {
            _userStatusAdminService.DeleteUserStatus(id);
        }
        catch (Exception e)
        {
            return BadRequest($"ERROR: {e.Message}");
        }
        return Ok();
    }

    /// <summary>
    /// Update field of UserStatus
    /// </summary>
    /// <param name="status">UserStatusDTO</param>
    /// <returns></returns>
    [HttpPut(nameof(UpdateUserStatus))]
    public IActionResult UpdateUserStatus(UserStatusDTO status)
    {
        try
        {
            _userStatusAdminService.UpdateUserStatus(status);
        }
        catch (Exception e)
        {
            return BadRequest($"ERROR: {e.Message}");
        }
        return Ok();
    }
    #endregion
}