namespace dadesignart.net.Domain;

public class Portfolio : BaseEntity<Guid>
{
  public ICollection<PortfolioTranslation> Translations { get; set; }

  public ICollection<PortfolioCategory> PortfolioCategories { get; set; }

  public Guid UserId { get; set; }

  public User User { get; set; }

  public Image MainImage { get; set; }

  public ICollection<Image> SubImages { get; set; }
}
