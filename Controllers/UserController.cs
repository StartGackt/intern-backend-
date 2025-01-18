using Microsoft.AspNetCore.Mvc;
using MyWebApi.Entities.Common;
using MyWebApi.Entities.RequestModels;
using MyWebApi.Entities.ResponseModels;


namespace MyWebApi.Controllers
{
   [ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
        [HttpGet("{id}")]
        public ActionResult<ApiResponse<UserResponse>> GetUserById(string id)
        {
            return Ok(new ApiResponse<UserResponse>());
        }
        [HttpPost("DataTable")]
        public ActionResult<ApiResponse<DataSourceResponse<UserResponse>>> GetUsers([FromBody] UserTableRequest request)
        {
            return Ok(new ApiResponse<DataSourceResponse<UserResponse>>());
        }
        [HttpPost]
    public Task<ActionResult<ApiResponse<UserResponse>>> CreateUser([FromBody] CreateUserRequest request)
    {
        return Task.FromResult<ActionResult<ApiResponse<UserResponse>>>(Ok(new ApiResponse<UserResponse>()));
    }

    [HttpPut("{id}")]
    public Task<ActionResult<ApiResponse<UserResponse>>> UpdateUser(string id, [FromBody] EditUserRequest request)
    {
        return Task.FromResult<ActionResult<ApiResponse<UserResponse>>>(Ok(new ApiResponse<UserResponse>()));
    }
    [HttpDelete("{id}")]
    public Task<ActionResult<ApiResponse<DeleteUserResponse>>> DeleteUser(string id)
    {
        return Task.FromResult<ActionResult<ApiResponse<DeleteUserResponse>>>(Ok(new ApiResponse<DeleteUserResponse>()));
    }
    [HttpGet("Permissions")]
    public Task<ActionResult<ApiResponse<List<Permission>>>> GetAllPermissions()
    {
        return Task.FromResult<ActionResult<ApiResponse<List<Permission>>>>(Ok(new ApiResponse<List<Permission>>()));
    }
    [HttpGet("Roles")]
    public Task<ActionResult<ApiResponse<List<Role>>>> GetAllRoles()
    {
        return Task.FromResult<ActionResult<ApiResponse<List<Role>>>>(Ok(new ApiResponse<List<Role>>()));
    }
    }
}
