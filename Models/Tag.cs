using Dapper.Contrib.Extensions;
namespace Blog.Models;

[Table("[Tag]")]
public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Slug { get; set; } = String.Empty;
}