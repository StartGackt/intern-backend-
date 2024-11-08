using MyWebApi.Entities.Common;
using MyWebApi.Entities.ResponseModels;

namespace MyWebApi.Entities.ResponseModels
{
    public class UserResponse
    {
        public Status Status { get; set; }
        public UserData Data { get; set; }
    }

    public class UserData
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public RoleInfo Role { get; set; }
        public string Username { get; set; }
        public List<PermissionInfo> Permissions { get; set; }
    }

    public class RoleInfo
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
    }

    public class PermissionInfo
    {
        public string PermissionId { get; set; }
        public string PermissionName { get; set; }
    }
}
