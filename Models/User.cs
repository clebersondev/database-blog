using Dapper.Contrib.Extensions;
namespace Blog.Models;

[Table("[User]")]
public class User
{
    public User()
    => Roles = new List<Role>();

    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    public string Bio { get; set; } = String.Empty;
    public string Image { get; set; } = String.Empty;
    public string Slug { get; set; } = String.Empty;

    [Write(false)]
    public List<Role> Roles { get; set; }
}