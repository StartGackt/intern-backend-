namespace MyWebApi.Entities.Common
{

public class User
{
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public Role Role { get; set; }
    public string Username { get; set; }
    public List<Permission> Permissions { get; set; }
    public string CreatedDate { get; set; }
    }
}
