using Microsoft.AspNetCore.Mvc;
using ToDoList.Web.Data;

namespace ToDoList.Web.Controllers
{
    public class MyTasksController : Controller
    {
        private readonly TDLContext _db;

        public MyTasksController(TDLContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }

}
