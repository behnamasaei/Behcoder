using System;

namespace Behcoder.Domain.Blog.Category;

public class CreateUpdateCategoryDto
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public string? MetaDescription { get; set; }
    public Guid? ParentId { get; set; }
}