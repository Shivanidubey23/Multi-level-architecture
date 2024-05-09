using Ecommerce.DAL.ViewModel;

namespace Ecommerce.BLL.Services.Category_Services
{
    /// <summary>
    /// Represents a service for managing categories in an e-commerce application.
    /// </summary>
    public interface ICategoryService
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

        /// <summary>
        /// Checks if a category with the specified name already exists.
        /// </summary>
        /// <param name="categoryName">The name of the category to check.</param>
        /// <returns><c>true</c> if the category already exists; otherwise, <c>false</c>.</returns>
        bool IsCategoryExists(string categoryName);

        /// <summary>
        /// Updates the name of a category.
        /// </summary>
        /// <param name="id">The unique identifier of the category to update.</param>
        /// <param name="categoryName">The new name of the category.</param>
        /// <returns>Status message from the update operation.</returns>
        string UpdateCategory(Guid id, string categoryName);

        /// <summary>
        /// Deletes a category by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the category to delete.</param>
        void DeleteCategory(Guid id);
        /// <summary>
        /// Retrive category selected by vendor 
        /// </summary>
        /// <param name="selectedCategoryIds"></param>
        List<CategoryViewModel> GetCategoriesWithSelection(List<Guid> selectedCategoryIds);
    }
}
