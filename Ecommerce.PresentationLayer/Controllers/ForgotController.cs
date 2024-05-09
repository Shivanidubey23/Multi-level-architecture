/*******************************************************************************

Name:         Forgot Controller
Author:       Shivani Dubey, Chrome Infotech
Date:         01/01/2023
Description:  Controller handling forgot password functionality in the Ecommerce system.

 Copyright © 2023 ChromeInfotech Corporation.  All Rights Reserved

Revisions:
01/01/2023  1.0.0   SD  Created

*******************************************************************************/

using Microsoft.AspNetCore.Mvc;
using Ecommerce.Data.Models;

namespace ECommerce.Controllers
{
    /// <summary>
    /// Controller responsible for handling forgot password functionality.
    /// </summary>
    public class ForgotController : Controller
    {
        /// <summary>
        /// GET: /Forgot
        /// Displays the forgot password view.
        /// </summary>
        /// <returns>The forgot password view.</returns>
        public ActionResult Forgot()
        {
            return View();
        }

        /// <summary>
        /// POST: /Forgot
        /// Handles the submission of forgot password form.
        /// </summary>
        /// <param name="model">The User model containing user input.</param>
        /// <returns>If the model is valid, displays the forgot password view; otherwise, returns the same view with errors.</returns>
        [HttpPost]
        public ActionResult Forgot(User model)
        {
            if (ModelState.IsValid)
            {
                
                // Return a view indicating success or redirect to another action
                return View();
            }

            return View(model);
        }
    }
}
