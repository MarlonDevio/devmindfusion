namespace devmindfusion.Models
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> AllBlogs { get; }
        IEnumerable<Blog> BlogsOfTheWeek { get; }
        Blog? GetBlogById(int blogId);
    }
}
