using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TodoApp.Domain.Entites;
using TodoApp.Domain.Interfaces;

namespace TodoApp.Application.Commads
{
    public class DeleteTodoCommandHandler : IRequestHandler<DeleteTodoCommand, Unit>
    {
        private readonly IRepository<Todo> _repository;
        public DeleteTodoCommandHandler(IRepository<Todo> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<Unit> Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetAsync(request.Id);
            await _repository.DeleteAsync(entity);
            return Unit.Value;
        }
    }
}
