using AutoMapper;
using Behcoder.Domain.Blog.Category;

namespace Behcoder;

public class BehcoderApplicationAutoMapperProfile : Profile
{
    public BehcoderApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CreateUpdateCategoryDto>().ReverseMap();
    }
}