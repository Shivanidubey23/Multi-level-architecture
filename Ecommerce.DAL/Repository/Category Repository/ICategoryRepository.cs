using Ecommerce.DAL.ViewModel;

namespace Ecommerce.DAL.Repository.CategoryRepository
{
    /// <summary>
    /// Represents a repository for managing categories in an e-commerce application.
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Retrieves all categories from the repository.
        /// </summary>
        /// <returns>A list of CategoryViewModel objects representing all categories.</returns>
        List<CategoryViewModel> GetAllCategories();

        /// <summary>
        /// Adds a new category to the repository.
        /// </summary>
        /// <param name="categoryName">The name of the category to be added.</param>
        void AddCategory(string categoryName);

        /*/// <summary>
        /// Retrieves a category by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the category to retrieve.</param>
        /// <returns>The CategoryViewModel object corresponding to the specified identifier.</returns>*/
        /*CategoryViewModel GetCategoryById(Guid id);*/
        bool IsCategoryExists(string categoryName);

        /// <summary>
        /// Returns category name by id 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        string GetCategoryNameById(Guid? categoryId);
        /// <summary>
        /// Get category with selection
        /// </summary>
        /// <param name="selectedCategoryIds"></param>
        /// <returns></returns>
        List<CategoryViewModel> GetCategoriesWithSelection(List<Guid> selectedCategoryIds);


    }
}
