using FluentValidation;
using MyGameScore.Application.Commands.CreateMatch;

namespace MyGameScore.Application.Validators
{
    public class CreateMatchCommandValidator : AbstractValidator<CreateMatchCommand>
    {
        public CreateMatchCommandValidator()
        {
            RuleFor(m => m.Date)
                .NotEmpty()
                .NotNull()
                .WithMessage("Data é obrigatório!");

            RuleFor(m => m.Score)
                .NotEmpty()
                .NotNull()
                .WithMessage("Pontuação é obrigatório!");
        }
    }
}
