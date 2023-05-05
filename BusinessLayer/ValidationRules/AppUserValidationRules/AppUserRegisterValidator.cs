using DtoLayer.Dtos.AppUserDtos;
using FluentValidation;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Boş keçilə bilməz.")
                .MaximumLength(100).WithMessage("50 simoldan artıq ola bilməz.")
                .MinimumLength(2).WithMessage("2 simoldan az ola bilməz.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Boş keçilə bilməz.");

            RuleFor(x => x.UserName)
               .NotEmpty().WithMessage("Boş keçilə bilməz.");

            RuleFor(x => x.Email)
               .NotEmpty().WithMessage("Boş keçilə bilməz.")
               .EmailAddress().WithMessage("Zəhmət olmasa keçərli email adresi qeyd edin.");

            RuleFor(x => x.Password)
               .NotEmpty().WithMessage("Boş keçilə bilməz.");

            RuleFor(x => x.ConfirmPassword)
               .NotEmpty().WithMessage("Boş keçilə bilməz.")
               .Equal(x => x.Password).WithMessage("Şifrələr bir biri ilə eyni deyil");
        }
    }
}
