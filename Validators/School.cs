using FluentValidation;
namespace JobForStudents
{
    public class SchoolValidator : AbstractValidator<School>
    {
        public SchoolValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("ROkul Adı boş geçilemez.");
            RuleFor(x => x.Address).NotNull().WithMessage("Address boş geçilemez.");

        }
    }
}