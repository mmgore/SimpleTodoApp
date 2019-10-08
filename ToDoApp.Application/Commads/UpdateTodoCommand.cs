using MediatR;
using System;

namespace TodoApp.Application.Commads
{
    public class UpdateTodoCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string City { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
