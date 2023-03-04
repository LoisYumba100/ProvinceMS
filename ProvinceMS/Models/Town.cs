using System;
using System.Collections.Generic;

namespace ProvinceMS.Models;

public partial class Town
{
    public int TownId { get; set; }

    public string TownName { get; set; } = null!;

    public int DistrictId { get; set; }

    public virtual District District { get; set; } = null!;
}
