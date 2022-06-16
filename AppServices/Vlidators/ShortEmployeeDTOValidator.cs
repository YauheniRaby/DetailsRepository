using AppServices.DTOs;
using FluentValidation;

namespace AppServices.Vlidators
{
    public class ShortEmployeeDTOValidator : AbstractValidator<ShortEmployeeDTO>
    {
        public ShortEmployeeDTOValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}
