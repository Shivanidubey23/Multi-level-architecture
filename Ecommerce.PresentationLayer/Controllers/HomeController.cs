/*******************************************************************************

Name:         Home Page Controller
Author:       Shivani Dubey, Chrome Infotech
Date:         02/01/2024
Description:  Ecommerce

 Copyright © 2023 ChromeInfotech Corporation.  All Rights Reserved

Revisions:
02/01/2024  1.0.0   SD  Created

*******************************************************************************/
/// <summary>
/// Controller managing actions related to the home page of the application.
/// </summary>
/// <remarks>
/// This controller handles rendering the home page view.
/// </remarks>
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    /// <summary>
    /// Manages actions related to the home page of the application.
    /// </summary>
    public class HomePageController : Controller
    {
        /// <summary>
        /// Renders the home page view.
        /// </summary>
        /// <returns>The rendered home page view.</returns>
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
