using FluentValidation;
using Microsoft.Extensions.Logging;
using TodoApp.Application.Commads;

namespace TodoApp.Application.Validations
{
    public class CreateTodoCommandValidator : AbstractValidator<CreateTodoCommand>
    {
        public CreateTodoCommandValidator(ILogger<CreateTodoCommandValidator> logger)
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(25).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(15).NotEmpty();
            RuleFor(x => x.Rating).NotEmpty().Must(IsRatingInRange).WithMessage("Please specify a rating betweem 0 and 5");
            
            logger.LogTrace($"Instance Created {GetType().Name}");
        }
        private bool IsRatingInRange(int number)
            => (number >= 0 && number <= 5) ? true : false;
    }
}
