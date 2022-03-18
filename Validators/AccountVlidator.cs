using FluentValidation;
namespace JobForStudents{
public class AccountDTOValidator : AbstractValidator<Account>
{
    public AccountDTOValidator()
    {
        RuleFor(x => x.Email).EmailAddress(FluentValidation.Validators.EmailValidationMode.Net4xRegex).WithMessage("Email formati hatalıdır");
        RuleFor(x => x.Password).NotNull().WithMessage("Password kurallara düzgün bir şekilde oluşturulmalıdır.");

    }
}
}
