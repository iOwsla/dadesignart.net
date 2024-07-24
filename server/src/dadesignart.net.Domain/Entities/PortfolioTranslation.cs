namespace dadesignart.net.Domain;

public class PortfolioTranslation : BaseEntity<Guid>, ISeo
{
  public string Title { get; set; }

  public string Description { get; set; }

  public string Slug { get; set; }

  public string MetaTitle { get; set; }

  public string MetaDescription { get; set; }

  public string MetaKeywords { get; set; }

  public Guid PortfolioId { get; set; }

  public Portfolio Portfolio { get; set; }

  public Guid LanguageId { get; set; }

  public Language Language { get; set; }
}
