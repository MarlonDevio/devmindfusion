using devmindfusion.Models;
using devmindfusion.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace devmindfusion.Controllers;

public class BlogController : Controller
{
    private readonly IBlogRepository _blogRepository;
    private readonly ICategoryRepository _categoryRepository;

    public BlogController(IBlogRepository blogRepository, ICategoryRepository categoryRepository)
    {
        _blogRepository = blogRepository;
        _categoryRepository = categoryRepository;
    }
    // GET
    public IActionResult Index()
    {
        BlogListViewModel blogListViewModel = new BlogListViewModel(
_blogRepository.AllBlogs, "MainBlog"
            );
        return View(blogListViewModel);
    }
}
