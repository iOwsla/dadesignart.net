namespace dadesignart.net.Domain;

public class BlogTranslation : BaseEntity<Guid>, ISeo
{
  public string Title { get; set; }
  public string Description { get; set; }
  public string Content { get; set; }
  public string Slug { get; set; }
  public string MetaTitle { get; set; }
  public string MetaDescription { get; set; }
  public string MetaKeywords { get; set; }
  public Guid BlogId { get; set; }
  public Blog Blog { get; set; }
  public Guid LanguageId { get; set; }
  public Language Language { get; set; }
}
