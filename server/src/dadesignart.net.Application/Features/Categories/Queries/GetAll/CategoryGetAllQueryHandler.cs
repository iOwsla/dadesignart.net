using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace dadesignart.net.Application;

public class CategoryGetAllQueryHandler : IRequestHandler<CategoryGetAllQuery, List<CategoryGetAllDto>>
{
  private readonly ICurrentUserService _currentUserService;
  private readonly IApplicationDbContext _applicationDbContext;
  private readonly IMemoryCache _memoryCache;
  private readonly IMapper _mapper;

  public CategoryGetAllQueryHandler(IApplicationDbContext applicationDbContext, ICurrentUserService currentUserService, IMemoryCache memoryCache, IMapper mapper)
  {
    _applicationDbContext = applicationDbContext;
    _currentUserService = currentUserService;
    _memoryCache = memoryCache;
    _mapper = mapper;
  }

  public async Task<List<CategoryGetAllDto>> Handle(CategoryGetAllQuery request, CancellationToken cancellationToken)
  {
    List<CategoryGetAllDto> categories;

    if (_memoryCache.TryGetValue(MemoryCacheHelper.GetCategoryGetAllKey(_currentUserService.UserId), out categories))
      return categories;

    var dbCategories = await _applicationDbContext.Categories
        .AsNoTracking()
        .Include(x => x.Translations)
        .ToListAsync(cancellationToken);

    categories = _mapper.Map<List<CategoryGetAllDto>>(dbCategories);

    _memoryCache.Set(MemoryCacheHelper.GetCategoryGetAllKey(_currentUserService.UserId), categories, MemoryCacheHelper.GetMemoryCacheEntryOptions());

    return categories;
  }
}
