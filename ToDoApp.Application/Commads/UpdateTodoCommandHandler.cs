using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TodoApp.Application.Exceptions;
using TodoApp.Domain.Entites;
using TodoApp.Domain.Interfaces;

namespace TodoApp.Application.Commads
{
    public class UpdateTodoCommandHandler : IRequestHandler<UpdateTodoCommand, Unit>
    {
        private readonly IRepository<Todo> _repository;
        public UpdateTodoCommandHandler(IRepository<Todo> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<Unit> Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Todo), request.Id);
            }
            entity.Name = request.Name;
            entity.Rating = request.Rating;
            entity.City = request.City;
            entity.ModifiedDate = DateTime.Now;

            await _repository.UpdateAsync(entity);

            return Unit.Value;
        }
    }
}
