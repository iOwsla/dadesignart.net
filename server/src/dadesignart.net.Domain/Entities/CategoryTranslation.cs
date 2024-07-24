namespace dadesignart.net.Domain;

public class CategoryTranslation : BaseEntity<Guid>
{
  public string Name { get; set; }
  public Guid CategoryId { get; set; }
  public Category Category { get; set; }
  public Guid LanguageId { get; set; }
  public Language Language { get; set; }
}
