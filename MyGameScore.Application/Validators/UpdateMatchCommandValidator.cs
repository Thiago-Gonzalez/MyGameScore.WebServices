using FluentValidation;
using MyGameScore.Application.Commands.UpdateMatch;

namespace MyGameScore.Application.Validators
{
    public class UpdateMatchCommandValidator : AbstractValidator<UpdateMatchCommand>
    {
        public UpdateMatchCommandValidator()
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