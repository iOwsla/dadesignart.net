namespace dadesignart.net.Domain;

public class Image : BaseEntity<Guid>
{
  public string Url { get; set; }

  public string AltText { get; set; }

  public bool IsMain { get; set; }

  public Guid PortfolioId { get; set; }

  public Portfolio Portfolio { get; set; }
}
