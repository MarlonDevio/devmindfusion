
namespace devmindfusion.Models;

public class CategoryRepository : ICategoryRepository
{
    private readonly DevMindFusionDbContext _devMindFusionDbContext;

    public CategoryRepository(DevMindFusionDbContext devMindFusionDbContext)
    {
        _devMindFusionDbContext = devMindFusionDbContext;
    }

    public IEnumerable<Category> AllCategories => _devMindFusionDbContext.Categories.OrderBy(category => category.Title);
}

