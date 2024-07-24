namespace dadesignart.net.Domain;

public interface IEntity<TKey>
{
  public TKey Id { get; set; }
}
