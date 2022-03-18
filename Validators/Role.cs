using FluentValidation;
namespace JobForStudents
{
    public class RoleValidator : AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Rol Adı boş geçilemez.");

        }
    }
}