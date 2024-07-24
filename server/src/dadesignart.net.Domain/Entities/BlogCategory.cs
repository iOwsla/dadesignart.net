namespace dadesignart.net.Domain;

public class BlogCategory
{
  public Guid BlogId { get; set; }
  public Blog Blog { get; set; }

  public Guid CategoryId { get; set; }
  public Category Category { get; set; }
}
