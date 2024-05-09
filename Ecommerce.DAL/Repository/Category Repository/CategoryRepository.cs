using Ecommerce.DAL.Repository.CategoryRepository;
using Ecommerce.DAL.ViewModel;
using Ecommerce.Data.Models;

namespace Ecommerce.DAL.Repository.Category_Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EcommerceContext _context;


        public CategoryRepository(EcommerceContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public List<CategoryViewModel> GetAllCategories()
        {
            try
            {

                return _context.Categories
                    .Where(c => c.IsDeleted != true)  // Exclude categories where IsDeleted is true or null
                    .Select(c => new CategoryViewModel
                    {
                        Id = c.Id,
                        Name = c.Name,

                    })
                    .ToList();
            }
            catch
            {

                throw;
            }
        }
        public void AddCategory(string categoryName)
        {
            try
            {

                var newCategory = new Category
                {
                    Name = categoryName,

                };

                _context.Categories.Add(newCategory);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }


        public bool IsCategoryExists(string categoryName)
        {
            try
            {
                return _context.Categories.Any(c => c.Name == categoryName);
            }
            catch
            {
                throw;
            }
        }


        public string GetCategoryNameById(Guid? categoryId)
        {
            try
            {
                if (categoryId == null)
                    return null;
                var category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);

                return category?.Name;
            }
            catch
            {
                throw;
            }
        }
        public List<CategoryViewModel> GetCategoriesWithSelection(List<Guid> selectedCategoryIds)
        {
            try
            {
                return _context.Categories
                    .Select(c => new CategoryViewModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                        IsSelected = (selectedCategoryIds != null && selectedCategoryIds.Contains(c.Id))
                    }).ToList();
            }
            catch
            {
                throw;
            }
        }

    }
}
