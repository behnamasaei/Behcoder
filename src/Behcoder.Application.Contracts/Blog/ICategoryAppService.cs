using System;
using Behcoder.Domain.Blog.Category;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Behcoder.Blog;

public interface ICategoryAppService : ICrudAppService<
    CategoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto, CreateUpdateCategoryDto>
{
}