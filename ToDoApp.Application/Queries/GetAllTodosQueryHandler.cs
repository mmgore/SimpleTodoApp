using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TodoApp.Domain.Entites;
using TodoApp.Domain.Interfaces;

namespace TodoApp.Application.Queries
{
    public class GetAllTodosQueryHandler : IRequestHandler<GetAllTodosQuery, GetAllTodosViewModel>
    {
        private readonly IRepository<Todo> _repository;
        private readonly IMapper _mapper;
        public GetAllTodosQueryHandler(IRepository<Todo> repository
            , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAllTodosViewModel> Handle(GetAllTodosQuery request, CancellationToken cancellationToken)
        {
            return new GetAllTodosViewModel
            {
                AllTodos = _mapper.Map<IEnumerable<GetAllTodosDto>>(await _repository.GetAllAsync())
            };
        }
    }
}
