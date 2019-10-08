using MediatR;
using System;

namespace TodoApp.Application.Commads
{
    public class DeleteTodoCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
