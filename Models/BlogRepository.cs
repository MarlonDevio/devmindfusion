using Microsoft.EntityFrameworkCore;
namespace devmindfusion.Models;

public class BlogRepository : IBlogRepository
{
    private readonly DevMindFusionDbContext _devMindFusionDbContext;

    public BlogRepository(DevMindFusionDbContext devMindFusionDbContext)
    {
        _devMindFusionDbContext = devMindFusionDbContext;
    }

    public IEnumerable<Blog> AllBlogs => _devMindFusionDbContext.Blogs.Include(c => c.Category);

    public IEnumerable<Blog> BlogsOfTheWeek => _devMindFusionDbContext.Blogs.Include(c => c.Category).Where(blog => blog.IsBlogOfTheWeek);

    public Blog? GetBlogById(int blogId)
    {
        return _devMindFusionDbContext.Blogs.FirstOrDefault(blog => blog.BlogId == blogId);
    }
}

