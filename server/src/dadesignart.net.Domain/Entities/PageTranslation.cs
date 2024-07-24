namespace dadesignart.net.Domain;


public class PageTranslation : BaseEntity<Guid>, ISeo
{
  public string Name { get; set; }

  public string Title { get; set; }

  public string Content { get; set; }
  public string Slug { get; set; }
  public string MetaTitle { get; set; }
  public string MetaDescription { get; set; }
  public string MetaKeywords { get; set; }

  public Guid PageId { get; set; }
  public Page Page { get; set; }
  public Guid LanguageId { get; set; }
  public Language Language { get; set; }
}
