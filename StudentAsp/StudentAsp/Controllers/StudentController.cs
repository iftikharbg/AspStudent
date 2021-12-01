using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAsp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                ViewData["message"] = "Id is null";
                return View("NewsList");
            }

            return Json(new { Name = "Eli", Surname = "Isaxanli", Age = 21 });
           

        }
    }
}
