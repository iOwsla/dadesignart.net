namespace dadesignart.net.Domain;

public class CategoryTranslation : BaseEntity<Guid>
{
  public string Name { get; set; }
  public Guid CategoryId { get; set; }
  public Category Category { get; set; }
  public LanguageType LanguageType { get; set; }
}
