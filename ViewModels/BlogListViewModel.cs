using devmindfusion.Models;
namespace devmindfusion.ViewModels
{
    public class BlogListViewModel
    {
        public IEnumerable<Blog> Blogs { get; }
        public string? CurrentCategory { get; }

        public BlogListViewModel(IEnumerable<Blog> blogs, string? currentCategory)
        {
            Blogs = blogs;
            CurrentCategory = currentCategory;
        }
    }
}
