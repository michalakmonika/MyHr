using FluentValidation;
using MyHr.Application.Dtos;
using MyHr.Domain.Interfaces;

namespace MyHr.Application.Validators
{
    public class EmployeeDtoValidator : AbstractValidator<EmployeeDto>
    {
        public EmployeeDtoValidator(IEmployeeRepository reposiory)
        {
            RuleFor(e => e.FirstName)
                .NotEmpty().WithMessage("Pole nie może być puste!")
                .MinimumLength(2).WithMessage("Pole musi zawierać minimum 2 znaki!")
                .MaximumLength(20).WithMessage("Pole może zawierać maksimum 20 znaków!");

            RuleFor(e => e.Pesel)
                .NotEmpty()
                .Custom((value, context) =>
                {
                    var existingEmployee = reposiory.GetByPesel(value);
                    if(existingEmployee != null)
                    {
                        context.AddFailure("Osoba o takim numerze PESEL istnieje w bazie danych.");
                    }
                });
        }
    }
}
