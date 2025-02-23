using Microsoft.AspNetCore.Mvc;
using MyHr.Application.Dtos;
using MyHr.Application.Services;
using MyHr.Domain.Entities;

namespace MyHr.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.GetAll();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeDto employeeDto)
        {
            bool state = ModelState.IsValid;
            if (!ModelState.IsValid)
            {
                return View(employeeDto);
            }
            _employeeService.Create(employeeDto);
            return RedirectToAction(nameof(Create));
        }


    }
}
