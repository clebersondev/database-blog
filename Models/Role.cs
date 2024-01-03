using Dapper.Contrib.Extensions;
namespace Blog.Models;

[Table("[Role]")]
public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Slug { get; set; } = String.Empty;
}