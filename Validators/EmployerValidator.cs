using FluentValidation;
namespace JobForStudents
{
    public class EmployerValidator : AbstractValidator<Employer>
    {
        public EmployerValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Ad boş geçilemez.");
            RuleFor(x => x.Surname).NotNull().WithMessage("Soyad boş geçilemez.");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Telefon Numarası boş geçilemez.");
            RuleFor(x => x.BirthDate).NotNull().WithMessage("Doğum Tarihi boş geçilemez.");
            RuleFor(x => x.CompanyId).NotNull().WithMessage("Şirket boş geçilemez.");
            RuleFor(x => x.AccountId).NotNull().WithMessage("Hesap boş geçilemez.");
        }
    }
}