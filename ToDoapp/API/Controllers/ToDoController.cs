using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRepository _repository;

        public ToDoController(IToDoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<ToDo>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}", Name = "GetById")]

        public ActionResult<ToDo> GetById(int id) => _repository.GetById(id);

        [HttpPost]
        public IActionResult Create(ToDo todo)
        {
            _repository.Create(todo);
            return CreatedAtAction(nameof(GetById), new { id = todo.Id }, todo);
        }

    }
}