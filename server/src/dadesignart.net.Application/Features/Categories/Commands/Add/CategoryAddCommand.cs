using dadesignart.net.Domain;
using MediatR;

namespace dadesignart.net.Application;

public class CategoryAddCommand : IRequest<ResponseDto<Guid>>
{
  public string Name { get; set; }
  public LanguageType LanguageType { get; set; }
  public Guid CategoryId { get; set; }
  public string CreatedBy { get; set; }
}
