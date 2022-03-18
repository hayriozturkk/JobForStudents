using FluentValidation;
namespace JobForStudents
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Şirket Adı boş geçilemez.");
            RuleFor(x => x.Address).NotNull().WithMessage("Şirket Adresi boş geçilemez.");
            RuleFor(x => x.Category).NotNull().WithMessage("Kategori boş geçilemez.");


        }
    }
}