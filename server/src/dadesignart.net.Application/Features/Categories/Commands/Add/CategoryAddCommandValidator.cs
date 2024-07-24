using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace dadesignart.net.Application;

public class CategoryAddCommandValidator : AbstractValidator<CategoryAddCommand>
{
  private readonly IApplicationDbContext _context;

  public CategoryAddCommandValidator(IApplicationDbContext context)
  {
    _context = context;

    RuleFor(x => x.Name)
        .NotEmpty().WithMessage("Name is required.")
        .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

    RuleFor(x => x.LanguageType)
        .IsInEnum().WithMessage("Invalid language type.");

    RuleFor(x => x)
        .MustAsync(IsUnique)
        .WithMessage("A category with this name already exists for the specified language.");
  }

  private async Task<bool> IsUnique(CategoryAddCommand model, CancellationToken cancellationToken)
  {
    return !await _context.Categories
        .AnyAsync(x => x.Translations
            .Any(y => y.Name == model.Name && y.LanguageType == model.LanguageType),
            cancellationToken);
  }
}