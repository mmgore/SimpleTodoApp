using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TodoApp.Domain.Entites;
using TodoApp.Domain.Interfaces;

namespace TodoApp.Application.Queries
{
    public class GetSingleTodoQueryHandler : IRequestHandler<GetTodoQuery, GetTodoDto>
    {
        private readonly IRepository<Todo> _repository;
        private readonly IMapper _mapper;
        public GetSingleTodoQueryHandler(IRepository<Todo> repository
            , IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<GetTodoDto> Handle(GetTodoQuery request, CancellationToken cancellationToken)
        {
            var todo =  await _repository.GetAsync(request.Id);
            return _mapper.Map<GetTodoDto>(todo);
        }
    }
}
