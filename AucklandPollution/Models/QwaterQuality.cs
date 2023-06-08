using System;
using System.Collections.Generic;

namespace AucklandPollution.Models;

public partial class QwaterQuality
{
    public int SampleId { get; set; }

    public int RegionId { get; set; }

    public DateTime CollectionDate { get; set; }

    public string Indicator { get; set; } = null!;

    public double Value { get; set; }

    public string Unit { get; set; } = null!;

    public virtual Region Region { get; set; } = null!;
}
