using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoItemController : ControllerBase
    {
        private readonly TodoContext _todoContext;

        public TodoItemController(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }

        [HttpGet("{id}")]
        public TodoItem GetById(int id)
        {
            return _todoContext.TodoItems.Find(id);
        }
    }
}
