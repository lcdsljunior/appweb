using AppWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "CTO" });
            list.Add(new Department { Id = 2, Name = "CRC" });
            list.Add(new Department { Id = 3, Name = "ADMINISTRAÇÂO" });

            return View(list);
        }
    }
}
