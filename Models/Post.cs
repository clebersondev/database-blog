using Dapper.Contrib.Extensions;
namespace Blog.Models;

[Table("[Post]")]
public class Post
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public int CategoryId { get; set; }

}