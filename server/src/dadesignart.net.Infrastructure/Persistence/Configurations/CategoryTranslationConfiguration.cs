using dadesignart.net.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dadesignart.net.Infrastructure;

public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
{
  public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
  {
    throw new NotImplementedException();
  }
}
