/******************************************************************************
*
* Name:         Sign in Controller 
* Author:       Shivani Dubey, Chrome Infotech
* Date:         01/03/2024
* Description:  Ecommerce
*
* Copyright © 2023 ChromeInfotech Corporation.  All Rights Reserved
*
* Revisions:
* 01/03/2024  1.0.0   SD  Created
*
******************************************************************************/

using Ecommerce.BLL.Services.UserServices;
using Ecommerce.DAL.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    /// <summary>
    /// Controller for handling user sign-in functionality in the Ecommerce application.
    /// </summary>
    public class SigninController : Controller
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SigninController"/> class.
        /// </summary>
        /// <param name="userService">The user service.</param>
        public SigninController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Displays the sign-in page.
        /// </summary>
        /// <returns>The view for the sign-in page.</returns>
        public ActionResult Signin()
        {
            return View();
        }

        /// <summary>
        /// Handles the form submission for user sign-in.
        /// </summary>
        /// <param name="username">The entered username.</param>
        /// <param name="password">The entered password.</param>
        /// <returns>Redirects to the dashboard on successful sign-in, otherwise returns to the sign-in page with error messages.</returns>
        [HttpPost]
        public ActionResult Signin(string username, string password)
        {
            var userViewModel = new UserViewModel
            {
                Username = username,
                Password = password
            };

            try
            {
                var signInStatus = _userService.SignInUser(userViewModel);

                switch (signInStatus)
                {
                    case Constant.Text.Success:
                        return RedirectToAction(Constant.Action.Dashboard, Constant.Controller.HomePage);

                    case Constant.Text.IncorrectPass:
                        ModelState.AddModelError(string.Empty, Constant.Messages.IncorrectPassword);
                        return View();

                    case Constant.Text.Usernotfound:
                        ModelState.AddModelError(string.Empty, Constant.Messages.UserDoesntExist);
                        return View();

                    default:
                        ModelState.AddModelError(string.Empty, Constant.Messages.SignInErrorMessage);
                        return View();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while signing in.");
                return View();
            }
        }
    }
}
