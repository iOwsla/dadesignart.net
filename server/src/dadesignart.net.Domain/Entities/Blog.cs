namespace dadesignart.net.Domain;

public class Blog : BaseEntity<Guid>
{
  public ICollection<BlogTranslation> Translations { get; set; }
  public ICollection<BlogCategory> BlogCategories { get; set; }
  public Guid UserId { get; set; }
  public User User { get; set; }
}
