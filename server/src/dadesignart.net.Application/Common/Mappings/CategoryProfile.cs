using AutoMapper;
using dadesignart.net.Domain;

namespace dadesignart.net.Application;

public class CategoryProfile : Profile
{
  public CategoryProfile()
  {
    CreateMap<CategoryAddCommand, Category>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
            .ForMember(dest => dest.Translations, opt => opt.MapFrom(src => new List<CategoryTranslation>
            {
                new CategoryTranslation
                {
                    Id = Guid.NewGuid(),
                    Name = src.Name,
                    LanguageType = src.LanguageType,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = src.CreatedBy
                }
            }));

    CreateMap<Category, CategoryGetAllDto>();
    CreateMap<CategoryTranslation, CategoryTranslationDto>();
  }
}
