using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblApiSbm
{
    public int? Lgdcode { get; set; }

    public int? Statecode { get; set; }

    public string? Statename { get; set; }

    public int? Districtcode { get; set; }

    public string? Districtname { get; set; }

    public int? UlbCode { get; set; }

    public string? Ulbname { get; set; }

    public int? Totalwards { get; set; }

    public int? Noofwards100perd2d { get; set; }

    public int? Noofwards100perss { get; set; }

    public float? Generation { get; set; }

    public float? Processed { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }
}
