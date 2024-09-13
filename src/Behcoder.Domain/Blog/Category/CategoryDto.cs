using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Behcoder.Domain.Blog.Category;

public class CategoryDto : EntityDto<Guid>
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public string? MetaDescription { get; set; }
    public Guid? ParentId { get; set; }
    public virtual CategoryDto? Parent { get; set; }
    public virtual ICollection<CategoryDto> Childs { get; set; }

}