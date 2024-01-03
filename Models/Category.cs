using Dapper.Contrib.Extensions;
namespace Blog.Models;

[Table("[Category]")]
public class Category
{
    public Category()
    => Posts = new List<Post>();

    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Slug { get; set; } = String.Empty;
    public List<Post> Posts { get; set; }

}