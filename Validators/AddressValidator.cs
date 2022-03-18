using FluentValidation;
namespace JobForStudents
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.OpenAddress).NotNull().WithMessage("Açık adres boş geçilemez.");
            RuleFor(x => x.City).NotNull().WithMessage("Şehir boş geçilemez.");
            RuleFor(x => x.District).NotNull().WithMessage("İlçe boş geçilemez.");

        }
    }
}
