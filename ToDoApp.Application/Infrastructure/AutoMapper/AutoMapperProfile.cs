using AutoMapper;
using TodoApp.Application.Queries;
using TodoApp.Domain.Entites;

namespace TodoApp.Application.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GetTodoDto, Todo>().ReverseMap();
            CreateMap<GetAllTodosDto, Todo>().ReverseMap();
        }
    }
}
