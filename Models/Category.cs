namespace devmindfusion.Models;
public class Category
{
    public int CategoryId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<Blog>? Blogs { get; set; }
}
