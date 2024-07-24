using Microsoft.AspNetCore.Identity;

namespace dadesignart.net.Domain;

public class User : IdentityUser<Guid>, IEntity<Guid>, ICreatedByEntity, IModifiedByEntity
{
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public string? ProfileImage { get; set; }
  public string CreatedBy { get; set; }
  public DateTimeOffset CreatedAt { get; set; }
  public string ModifiedBy { get; set; }
  public DateTimeOffset ModifiedAt { get; set; }
}
