using FluentValidation;
using TodoApp.Application.Commads;

namespace TodoApp.Application.Validations
{
    public class UpdateTodoCommandValidator : AbstractValidator<UpdateTodoCommand>
    {
        public UpdateTodoCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.Rating).NotEmpty();
            RuleFor(x => x.ModifiedDate).NotEmpty();
        }
    }
}
