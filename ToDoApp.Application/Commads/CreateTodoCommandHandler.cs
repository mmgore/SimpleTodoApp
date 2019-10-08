using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TodoApp.Domain.Entites;
using TodoApp.Domain.Interfaces;

namespace TodoApp.Application.Commads
{
    public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Unit>
    {
        private readonly IRepository<Todo> _repository;
        public CreateTodoCommandHandler(IRepository<Todo> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<Unit> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var entity = new Todo
            {
                Id = request.Id,
                Name = request.Name,
                Rating = request.Rating,
                City = request.City,
                CreatedDate = DateTime.Now
            };
            await _repository.InsertAsync(entity);

            return Unit.Value;
        }
    }
}
