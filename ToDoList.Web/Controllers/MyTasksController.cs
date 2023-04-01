using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoList.Web.Data;
using ToDoList.Web.Models;

namespace ToDoList.Web.Controllers
{
    public class MyTasksController : Controller
    {
        private readonly TDLContext _db;

        public MyTasksController(TDLContext db)
        {
            _db = db;
        }

        // GET: /MyTasks/Index
        public ActionResult Index()
        {
            IEnumerable<MyTask> mytasks = _db.MyTasks.ToList(); 
            return View(mytasks);
        }


        // GET: MyTasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id is null)
            {
                return NotFound();
            }
            var mytask = _db.MyTasks.FirstOrDefault(m => m.Id == id);
            if (mytask is null)
            {
                return NotFound();
            }

            return View(mytask);
        }



        // GET: MyTasks/Create
        public IActionResult Create()
        {
            ViewBag.MyTasks = new SelectList(_db.MyTasks.Where(x => x.ParentId == 0), "Id", "Name");
            return View();
        }

        // POST: MyTasks/Create
        [HttpPost]
        public IActionResult Create(MyTask mytask)
        {
            if (ModelState.IsValid)
            {
                _db.Add(mytask);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(mytask);
        }



        // GET: MyTasks/Edit/5
        public ActionResult Edit(int id)
        {
            var mytask = _db.MyTasks.Find(id);
            if (mytask == null)
            {
                return NotFound();
            }
            return View(mytask);
        }

        // POST: MyTasks/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, MyTask mytask)
        {
            if (id != mytask.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(mytask);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mytask);
        }




    }

}
