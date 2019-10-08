using FluentValidation;
using TodoApp.Application.Commads;

namespace TodoApp.Application.Validations
{
    public class DeleteTodoCommandValidator : AbstractValidator<DeleteTodoCommand>
    {
        public DeleteTodoCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
