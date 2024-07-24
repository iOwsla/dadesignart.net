namespace dadesignart.net.Domain;

public interface IModifiedByEntity
{
  public string ModifiedBy { get; set; }

  public DateTimeOffset ModifiedAt { get; set; }
}
