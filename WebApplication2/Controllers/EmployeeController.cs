using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context=new ApplicationDbContext();

        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View("View",employees);
        }
    }
}
