using dadesignart.net.Domain;

namespace dadesignart.net.Application;

public class CategoryTranslationDto
{
  public string Name { get; set; }
  public Guid CategoryId { get; set; }
  public LanguageType LanguageType { get; set; }
}
