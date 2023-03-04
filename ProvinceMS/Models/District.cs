using System;
using System.Collections.Generic;

namespace ProvinceMS.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public string DistrictName { get; set; } = null!;

    public int ProvinceId { get; set; }

    public virtual Province Province { get; set; } = null!;

    public virtual ICollection<Town> Towns { get; } = new List<Town>();
}
