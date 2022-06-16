using AppServices.DTOs;
using FluentValidation;

namespace AppServices.Vlidators
{
    public class CreateDetailDTOValidator : AbstractValidator<CreateDetailDTO>
    {
        public CreateDetailDTOValidator()
        {
            RuleFor(e => e.VendorCode)
                .NotEmpty()
                .MaximumLength(20);
            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(100);
            RuleFor(e => e.EmployeeId)
                .GreaterThan(0);
            RuleFor(e => e.Count)
                .GreaterThanOrEqualTo(0);
        }
    }
}
