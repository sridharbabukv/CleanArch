using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
