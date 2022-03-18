using FluentValidation;
namespace JobForStudents
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Kategori Adı boş geçilemez.");


        }
    }
}