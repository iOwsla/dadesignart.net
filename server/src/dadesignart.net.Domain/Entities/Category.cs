namespace dadesignart.net.Domain;

public class Category : BaseEntity<Guid>
{
  public ICollection<CategoryTranslation> Translations { get; set; }
  public ICollection<BlogCategory> BlogCategories { get; set; }
  public ICollection<PortfolioCategory> PortfolioCategories { get; set; }
}
