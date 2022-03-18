using FluentValidation;
namespace JobForStudents
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Şehir Adı boş geçilemez.");


        }
    }
}