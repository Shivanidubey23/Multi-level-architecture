/******************************************************************************
*
* Name:       Singup Controller
* Author:     Shivani Dubey, Chrome Infotech
* Date:       01/01/2024
* Description: Ecommerce
*
* Copyright © 2023 ChromeInfotech Corporation.  All Rights Reserved
*
* Revisions:
* 01/01/2024  1.0.0   SD  Created
******************************************************************************/

using Ecommerce.BLL.Services.UserServices;
using Ecommerce.DAL.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    /// <summary>
    /// Controller for handling user signup functionality in the Ecommerce application.
    /// </summary>
    public class SignupController : Controller
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignupController"/> class.
        /// </summary>
        /// <param name="userService">The user service.</param>
        public SignupController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Displays the signup page.
        /// </summary>
        /// <returns>The view for the signup page.</returns>
        public ActionResult Signup()
        {
            var userViewModel = new UserViewModel();
            return View(userViewModel);
        }

        /// <summary>
        /// Handles the form submission for user signup.
        /// </summary>
        /// <param name="userModel">The user model containing signup information.</param>
        /// <returns>
        /// Redirects to the dashboard on successful signup, 
        /// otherwise returns to the signup page with error messages.
        /// </returns>
        [HttpPost]
        public ActionResult Signup(UserViewModel userModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string signUpStatus = string.Empty;
                    signUpStatus = _userService.Registration(userModel, out signUpStatus);

                    if (signUpStatus == Constant.Text.SignUpSucess)
                    {
                        return RedirectToAction(Constant.Action.Dashboard, Constant.Controller.HomePage);
                    }
                    else if (signUpStatus == Constant.Text.UsernameExist)
                    {
                        ModelState.AddModelError(nameof(UserViewModel.Username), Constant.Messages.UserExist);
                    }
                    else if (signUpStatus == Constant.Text.EmailExist)
                    {
                        ModelState.AddModelError(nameof(UserViewModel.EmailId), Constant.Messages.EmailAlreadyExist);
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, Constant.Messages.SignupErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Error occurred while signing up: {ex.Message}");
                }
            }

            return View(userModel);
        }
    }
}
