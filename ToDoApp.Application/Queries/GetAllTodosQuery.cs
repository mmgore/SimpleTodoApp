using MediatR;
using System;
using System.Collections.Generic;

namespace TodoApp.Application.Queries
{
    public class GetAllTodosQuery : IRequest<GetAllTodosViewModel>
    {
    }
    public class GetAllTodosDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class GetAllTodosViewModel
    {
        public IEnumerable<GetAllTodosDto> AllTodos { get; set; }
    }
}
