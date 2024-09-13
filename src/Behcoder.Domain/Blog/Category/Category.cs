using System;
using System.Collections;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Behcoder.Domain.Blog.Category;

public class Category : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public string? MetaDescription { get; set; }
    public Guid? ParentId { get; set; }
    public virtual Category? Parent { get; set; }
    public virtual ICollection<Category> Childs { get; set; }
}