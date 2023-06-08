using System;
using System.Collections.Generic;

namespace AucklandPollution.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string RegionName { get; set; } = null!;

    public int RegionPop { get; set; }

    public virtual ICollection<AirQuality> AirQualities { get; set; } = new List<AirQuality>();

    public virtual ICollection<EstuaryQuality> EstuaryQualities { get; set; } = new List<EstuaryQuality>();

    public virtual ICollection<QwaterQuality> QwaterQualities { get; set; } = new List<QwaterQuality>();
}
