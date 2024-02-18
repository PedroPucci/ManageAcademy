using FluentValidation;
using ManageAcademyWeb.Domain.Dto;

namespace ManageAcademyWeb.Domain.Validator
{
    public class PermissionDtoValidator : AbstractValidator<PermissionDto>
    {
        public PermissionDtoValidator()
        {
            RuleFor(x => x)
                .NotEmpty();

            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.Description)
                .NotEmpty();
        }
    }
}