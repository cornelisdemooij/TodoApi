using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoItemController : ControllerBase {
        private static readonly TodoItem[] todoItems = new[] {
            new TodoItem { description = "Take out the trash", creation = DateTime.Now.Subtract(new TimeSpan(3,1,5,16)), deadline = DateTime.Now.AddDays(2), done = true },
            new TodoItem { description = "Do the dishes", creation = DateTime.Now.Subtract(new TimeSpan(2,6,3,35)), deadline = DateTime.Now.AddDays(2), done = false },
            new TodoItem { description = "Fold the clean laundry", creation = DateTime.Now.Subtract(new TimeSpan(1,4,32,28)), deadline = DateTime.Now.AddDays(2), done = true },
            new TodoItem { description = "Go grocery shopping", creation = DateTime.Now.Subtract(new TimeSpan(4,2,8,1)), deadline = DateTime.Now.AddDays(3), done = false },
            new TodoItem { description = "Vacuum the house", creation = DateTime.Now.Subtract(new TimeSpan(0,2,38,6)), deadline = DateTime.Now.AddDays(1), done = false }
        };

        private readonly ILogger<TodoItemController> _logger;

        public TodoItemController(ILogger<TodoItemController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TodoItem> Get() {
            return todoItems;
        }
    }
}
