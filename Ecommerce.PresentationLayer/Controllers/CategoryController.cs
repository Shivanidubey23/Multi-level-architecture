/******************************************************************************
*
* Name:        Category Controller
* Author:      Shivani Dubey, Chrome Infotech
* Date:        01/01/2024
* Description: Ecommerce
*
* Copyright © 2023 ChromeInfotech Corporation. All Rights Reserved
*
* Revisions:
* 01/01/2024  1.0.0   SD   Created
*
******************************************************************************/

using Ecommerce.BLL.Services.Category_Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    /// <summary>
    /// Controller responsible for managing categories in the e-commerce application.
    /// </summary>
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryController"/> class.
        /// </summary>
        /// <param name="categoryService">The category service.</param>
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Handles the HTTP GET request for displaying categories.
        /// </summary>
        /// <returns>The view displaying the categories.</returns>
        [HttpGet]
        public ActionResult Category()
        {
            try
            {
                var categories = _categoryService.GetAllCategories();
                return View(categories);
            }
            catch
            {

                return View(Constant.Text.Category);
            }
        }

        /// <summary>
        /// Handles the HTTP POST request for adding a new category.
        /// </summary>
        /// <param name="categoryName">The name of the category to be added.</param>
        /// <returns>The action result indicating the success or failure of the operation.</returns>
        [HttpPost]
        public ActionResult AddCategory(string categoryName)
        {
            try
            {
                // Check if the category already exists
                if (_categoryService.IsCategoryExists(categoryName))
                {
                    return Json(new { success = false, message = Constant.Messages.CategoryExist });
                }
                _categoryService.AddCategory(categoryName);

                return RedirectToAction(nameof(Category));
            }
            catch
            {

                return View();
            }
        }

        /// <summary>
        /// Handles the HTTP POST request for updating a category.
        /// </summary>
        /// <param name="id">The unique identifier of the category to be updated.</param>
        /// <param name="categoryName">The new name of the category.</param>
        /// <returns>The action result indicating the success or failure of the operation.</returns>
        [HttpPost]
        public IActionResult UpdateCategory(Guid id, string categoryName)
        {
            try
            {
                _categoryService.UpdateCategory(id, categoryName);

                TempData[Constant.Text.SuccessMessage] = Constant.Messages.CategoryUpdated;

                return Json(new { success = true });
            }
            catch
            {

                return Json(new { success = false });
            }
        }

        /// <summary>
        /// Handles the HTTP DELETE request for deleting a category.
        /// </summary>
        /// <param name="id">The unique identifier of the category to be deleted.</param>
        /// <returns>The action result indicating the success or failure of the operation.</returns>
        [HttpDelete]
        public IActionResult DeleteCategory(Guid id)
        {
            try
            {
                _categoryService.DeleteCategory(id);

                TempData[Constant.Text.SuccessMessage] = Constant.Messages.CategoryDeleted;

                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }
    }
}
