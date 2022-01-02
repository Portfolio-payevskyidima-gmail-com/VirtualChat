using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualChat.Domain.Models;
using VirtualChat.Services.AdminService;

namespace VirtualChat.API.Controllers
{
    [Route("api/[controller]")]
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

        [HttpGet(nameof(GetUserStatus))]
        public IActionResult GetUserStatus(int? id)
        {
            UserStatus status = null;
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

        [HttpGet(nameof(GetAllUsersStatus))]
        public IActionResult GetAllUsersStatus()
        {
            IEnumerable<UserStatus> statuses = null;
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

        [HttpPost(nameof(CreateUserStatus))]
        public IActionResult CreateUserStatus(UserStatus status)
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

        [HttpPut(nameof(UpdateUserStatus))]
        public IActionResult UpdateUserStatus(UserStatus status)
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
}
