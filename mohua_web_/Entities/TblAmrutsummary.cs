using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblAmrutsummary
{
    public int? Sno { get; set; }

    public string? Statename { get; set; }

    public float? Centralassistanceoutlayincr { get; set; }

    public float? Centralassistanceapprovedincr { get; set; }

    public int? Approvedprojects { get; set; }

    public float? Approvedprojectcostincr { get; set; }

    public int? Dprapprovedprojectcount { get; set; }

    public float? Dprapprovedprojectcostincr { get; set; }

    public int? Nitissuedprojectcount { get; set; }

    public float? Nitissuedprojectcostincr { get; set; }

    public int? Contractawardedprojectcount { get; set; }

    public float? Contractawardedprojectcostincr { get; set; }

    public int? Projectcount { get; set; }

    public float? Projectcostincr { get; set; }
}
