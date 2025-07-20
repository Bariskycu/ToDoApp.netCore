using Microsoft.AspNetCore.Mvc;
using ToDoAPP.Data;
using ToDoAPP.Models;
using System.Linq;

namespace ToDoAPP.Controllers
{
    public class ToDoController:Controller
    {
        private readonly AppDbContext _context;

        public ToDoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var todos = _context.Todos.ToList();
            return View(todos);
        }

        [HttpPost]
        public IActionResult Add(string title)
        {
            var todo = new Todo { Title = title, IsDone = false };
            _context.Todos.Add(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Done(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo != null)
            {
                todo.IsDone = true;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
