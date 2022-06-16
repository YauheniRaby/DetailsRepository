using AppServices.DTOs;
using FluentValidation;

namespace AppServices.Vlidators
{
    public class FullEmployeeDTOValidator : AbstractValidator<FullEmployeeDTO>
    {
        public FullEmployeeDTOValidator()
        {
            RuleFor(e => e.Id)
                .GreaterThan(0);
            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}
