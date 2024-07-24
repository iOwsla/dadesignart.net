using AutoMapper;
using dadesignart.net.Domain;
using MediatR;

namespace dadesignart.net.Application;

public class CategoryAddCommandHandler : IRequestHandler<CategoryAddCommand, ResponseDto<Guid>>
{

  private readonly IApplicationDbContext _context;
  private readonly IMapper _mapper;

  private readonly ICurrentUserService _currentUserService;

  public CategoryAddCommandHandler(IMapper mapper, IApplicationDbContext context, ICurrentUserService currentUserService)
  {
    _context = context;
    _mapper = mapper;
    _currentUserService = currentUserService;
  }

  public async Task<ResponseDto<Guid>> Handle(CategoryAddCommand request, CancellationToken cancellationToken)
  {
    request.CreatedBy = _currentUserService.UserId.ToString();

    var category = _mapper.Map<Category>(request);

    _context.Categories.Add(category);

    await _context.SaveChangesAsync(cancellationToken);

    return new ResponseDto<Guid>
    {
      Data = category.Id,
      Message = "Category added successfully",
      Succeeded = true
    };

  }
}
