using AppServices.DTOs;
using FluentValidation;

namespace AppServices.Vlidators
{
    public class UpdateDetailDTOValidator : AbstractValidator<UpdateDetailDTO>
    {
        public UpdateDetailDTOValidator()
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
            RuleFor(e => e.Id)
                .GreaterThan(0);
        }
    }
}
