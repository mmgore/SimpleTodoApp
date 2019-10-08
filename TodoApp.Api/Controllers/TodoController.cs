using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TodoApp.Application.Commads;
using TodoApp.Application.Queries;

namespace TodoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TodoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GetTodoDto>> Get(Guid id)
            => Ok(await _mediator.Send(new GetTodoQuery { Id = id }));
        
        [HttpGet]
        public async Task<ActionResult<GetAllTodosViewModel>> GetAll()
            => Ok(await _mediator.Send(new GetAllTodosQuery()));
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateTodoCommand command)
            =>  Ok(await _mediator.Send(command));
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody]UpdateTodoCommand command)
            => Ok(await _mediator.Send(command));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
            => Ok(await _mediator.Send(new DeleteTodoCommand { Id = id}));
    }
}