using System;
using System.Collections.Generic;

namespace AucklandPollution.Models;

public partial class EstuaryQuality
{
    public int SampleId { get; set; }

    public int RegionId { get; set; }

    public DateTime CollectionDate { get; set; }

    public string Indicator { get; set; } = null!;

    public double Value { get; set; }

    public virtual Region Region { get; set; } = null!;
}
