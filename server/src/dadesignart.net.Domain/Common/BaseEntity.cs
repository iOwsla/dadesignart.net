
namespace dadesignart.net.Domain;

public abstract class BaseEntity<TKey> : IEntity<TKey>, ICreatedByEntity, IModifiedByEntity
{
  public TKey Id { get; set; }
  public string CreatedBy { get; set; }
  public DateTimeOffset CreatedAt { get; set; }
  public string ModifiedBy { get; set; }
  public DateTimeOffset ModifiedAt { get; set; }
}
