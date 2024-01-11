using System;
using System.Collections.Generic;

namespace _02_SampleWebApplication.Models;

public partial class Beer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
