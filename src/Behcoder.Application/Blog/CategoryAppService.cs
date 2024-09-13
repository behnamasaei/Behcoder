using System;
using Behcoder.Domain.Blog.Category;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Behcoder.Blog;

public class CategoryAppService:CrudAppService<Category,CategoryDto,Guid,PagedAndSortedResultRequestDto
    ,CreateUpdateCategoryDto, CreateUpdateCategoryDto>,ICategoryAppService
{
    public CategoryAppService(IRepository<Category, Guid> repository) : base(repository)
    {
    }
}