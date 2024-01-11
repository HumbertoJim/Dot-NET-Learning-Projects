using System;
using System.Collections.Generic;

namespace _02_SampleWebApplication.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
