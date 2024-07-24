namespace dadesignart.net.Domain;

public interface ISeo
{
  public string Slug { get; set; }
  public string MetaTitle { get; set; }
  public string MetaDescription { get; set; }
  public string MetaKeywords { get; set; }
}
