using ePrimjer.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using ePrimjer.Infrastracture.UnitOfWork;
using ePrimjer.Service.StudentServices;

namespace ePrimjer.Web.Controllers
{
    public class HomeController : Controller
    {
    
        private readonly IStudentService _student;

        public HomeController(IStudentService student)
        {
            _student = student;
        }

        public IActionResult Index()
        {
            var student = _student.GetStudentByName("IB190010");
            ViewData["Student"] = student;
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}