using Ecommerce.DAL.Helper;
using Ecommerce.DAL.Repository.CategoryRepository;
using Ecommerce.DAL.ViewModel;
using Constant = ECommerce.Constant;
namespace Ecommerce.BLL.Services.Category_Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ECommerceDbHelper _dbHelper;


        public CategoryService(ICategoryRepository categoryRepository, ECommerceDbHelper dbHelper)
        {
            _categoryRepository = categoryRepository;
            _dbHelper = dbHelper;
        }


        public List<CategoryViewModel> GetAllCategories()
        {
            try
            {
                return _categoryRepository.GetAllCategories();
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
                _categoryRepository.AddCategory(categoryName);
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
                return _categoryRepository.IsCategoryExists(categoryName);
            }
            catch
            {
                throw;
            }
        }


        public string UpdateCategory(Guid id, string categoryName)
        {
            try
            {


                var parameters = new Dictionary<string, object>
                {
                    { Constant.Text.CategoryIdParameter, id.ToString()},
                    { Constant.Text.CategoryNameParameter, categoryName }
                };

                var resultTable = _dbHelper.ExecuteStoredProcedure(Constant.StoredProcedure.spUpdateCategory, parameters);

                var statusMessage = resultTable.Rows.Count > 0 ? resultTable.Rows[0][0].ToString() : null;


                return statusMessage;
            }
            catch
            {
                throw;
            }
        }


        public void DeleteCategory(Guid id)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { Constant.Text.CategoryIdParameter, id.ToString() }
                };

                _dbHelper.ExecuteStoredProcedure(Constant.StoredProcedure.spDeleteCategory, parameters);
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


                return _categoryRepository.GetCategoriesWithSelection(selectedCategoryIds);
            }
            catch
            {
                throw;
            }
        }

    }
}
