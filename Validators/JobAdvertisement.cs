using FluentValidation;
namespace JobForStudents
{
    public class JobAdvertisementValidator : AbstractValidator<JobAdvertisement>
    {
        public JobAdvertisementValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Ad boş geçilemez.");
            RuleFor(x => x.Title).NotNull().WithMessage("Ünvan boş geçilemez.");
            RuleFor(x => x.Description).NotNull().WithMessage("Açıklma boş geçilemez.");
            RuleFor(x => x.Salary).NotNull().WithMessage("Maaş boş geçilemez.");
            RuleFor(x => x.CategoryId).NotNull().WithMessage("Kategori boş geçilemez.");
            RuleFor(x => x.WorkingTime).NotNull().WithMessage("Çalışma Zamanı boş geçilemez.");
            RuleFor(x => x.EmployerId).NotNull().WithMessage("İşveren boş geçilemez.");
        }
    }
}