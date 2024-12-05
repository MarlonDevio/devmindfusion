namespace devmindfusion.Models;

public class Blog
{
    public int BlogId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? ShortDescription { get; set; }
    public string Content { get; set; } = string.Empty;
    public Category Category { get; set; } = default!;
    public int CategoryId { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageThumbnailUrl { get; set; }
    public bool IsBlogOfTheWeek { get; set; }
}
