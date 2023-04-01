using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Web.Controllers
{
    public class MyTasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
