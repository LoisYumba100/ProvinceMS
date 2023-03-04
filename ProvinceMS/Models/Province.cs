using System;
using System.Collections.Generic;

namespace ProvinceMS.Models;

public partial class Province
{
    public int ProvinceId { get; set; }

    public string ProvinceName { get; set; } = null!;

    public virtual ICollection<District> Districts { get; } = new List<District>();
}
