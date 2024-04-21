using COMP003B.Assignment4_.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4_.Models;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Process registration (e.g., save to database)
                // Redirect to ThankYou page with model data
                return RedirectToAction("ThankYou", model);
            }
            return View(model);
        }

        public IActionResult ThankYou(RegistrationViewModel model)
        {
            return View(model);
        }
    }

