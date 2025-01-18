namespace MyWebApi.Entities.RequestModels
{

    public class EditUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string RoleId { get; set; }
        public string Username { get; set; }
        public List<PermissionRequest> Permissions { get; set; }
    }
}
