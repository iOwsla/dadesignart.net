namespace dadesignart.net.Domain;

public interface ICreatedByEntity
{
  public string CreatedBy { get; set; }

  public DateTimeOffset CreatedAt { get; set; }
}
