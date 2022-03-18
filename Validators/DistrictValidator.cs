using FluentValidation;
namespace JobForStudents
{
    public class DistrictValidator : AbstractValidator<District>
    {
        public DistrictValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("ilçe Adı boş geçilemez.");
            RuleFor(x => x.CityId).NotNull().WithMessage("CityId boş geçilemez.");


        }
    }
}