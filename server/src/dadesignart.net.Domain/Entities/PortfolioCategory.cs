namespace dadesignart.net.Domain;

public class PortfolioCategory
{
  public Guid PortfolioId { get; set; }
  public Portfolio Portfolio { get; set; }

  public Guid CategoryId { get; set; }
  public Category Category { get; set; }
}
