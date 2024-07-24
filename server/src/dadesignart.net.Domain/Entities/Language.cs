namespace dadesignart.net.Domain;

public class Language : BaseEntity<Guid>
{
  public string Name { get; set; }
  public string Code { get; set; }
}
