using dadesignart.net.Domain;

namespace dadesignart.net.Application;

public class CategoryGetAllDto
{
  public Guid Id { get; set; }
  public List<CategoryTranslationDto> Translations { get; set; }
  public string CreatedBy { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
  public string ModifiedBy { get; set; }
}
