using ePrimjer.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using ePrimjer.Infrastracture.UnitOfWork;

namespace ePrimjer.Web.Controllers
{
    public class HomeController : Controller
    {
    
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var student = _unitOfWork._StudentRepository.GetByIndex("IB190010");
            return View(student.ToString());
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