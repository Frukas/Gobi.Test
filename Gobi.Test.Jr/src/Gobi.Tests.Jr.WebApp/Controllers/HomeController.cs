using Gobi.Test.Jr.Domain;
using Gobi.Test.Jr.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gobi.Tests.Jr.WebApp.Controllers
{
	public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public IActionResult Index()
        {
            var items = _todoItemService.GetAll();

            return View(items);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new TodoItem());
        }

        [HttpPost]
        public IActionResult Add(TodoItem todoItem)
        {
            _todoItemService.Add(todoItem);

            return RedirectToAction("Index");
        }

		[HttpGet]
		public IActionResult Edit([FromRoute] int id)
		{
            var items = _todoItemService.GetAll().SingleOrDefault( r => r.Id == id);


            return View(items);
		}

        [HttpPost]
        public IActionResult Update(TodoItem todoItem)
        {
            _todoItemService.Update(todoItem);

            return RedirectToAction("Index");
        }

		[HttpGet]
		public IActionResult Delete([FromRoute] int id)
        {
            _todoItemService.Delete(id);

            return RedirectToAction("Index");
        }

    }
}