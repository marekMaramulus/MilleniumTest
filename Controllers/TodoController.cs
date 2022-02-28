using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MilleniumTest.Models;
using MilleniumTest.Services;

namespace MilleniumTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : MilleniumController
    {
        private readonly ILogger<TodoController> _logger;
        private readonly ITodoService _todoService;

        public TodoController(ILogger<TodoController> logger, ITodoService todoService)
        {
            _logger = logger;
            _todoService = todoService;
        }

        [HttpGet(Name = "GetAllItems")]
        [ProducesResponseType(typeof(IEnumerable<TodoItem>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var result = _todoService.GetAll();
            return Ok(result);
        }

        [HttpGet("{itemId}", Name = "Get")]
        [ProducesResponseType(typeof(TodoItem), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int itemId)
        {
            var item = _todoService.Get(itemId);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost(Name = "Add")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Add([FromBody] TodoItem item)
        {
            var itemId = _todoService.Add(item);
            if (itemId < 0)
            {
                return BadRequest();
            }

            return Ok(itemId);
        }

        [HttpPut(Name = "Update")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromBody] TodoItem item)
        {
            var resultCode = _todoService.Update(item);
            if (resultCode < 0)
            {
                return MapResult(resultCode);
            }

            return NoContent();
        }
    }
}