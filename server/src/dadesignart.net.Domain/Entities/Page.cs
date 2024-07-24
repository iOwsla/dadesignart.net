namespace dadesignart.net.Domain;

public class Page : BaseEntity<Guid>
{
  public ICollection<PageTranslation> Translations { get; set; }
}
