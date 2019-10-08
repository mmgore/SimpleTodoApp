using MediatR;
using System;

namespace TodoApp.Application.Queries
{
    public class GetTodoQuery : IRequest<GetTodoDto>
    {
        public Guid Id { get; set; }
    }

    public class GetTodoDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
