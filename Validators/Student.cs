using FluentValidation;
namespace JobForStudents
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Ad boş geçilemez.");
            RuleFor(x => x.Surname).NotNull().WithMessage("Soyad boş geçilemez.");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Telefon Numarası boş geçilemez.");
            RuleFor(x => x.BirthDate).NotNull().WithMessage("Doğum Tarihi boş geçilemez.");
            RuleFor(x => x.Education).NotNull().WithMessage("Mezuniyet boş geçilemez.");
            RuleFor(x => x.EducationTour).NotNull().WithMessage("Eğitim Türü boş geçilemez.");
            RuleFor(x => x.Address).NotNull().WithMessage("Address boş geçilemez.");
            RuleFor(x => x.School).NotNull().WithMessage("Okul boş geçilemez.");
            RuleFor(x => x.AccountId).NotNull().WithMessage("Hesap boş geçilemez.");
        }
    }
}