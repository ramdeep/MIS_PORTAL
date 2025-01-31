using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblScm
{
    public int? Objectid { get; set; }

    public string? PId { get; set; }

    public float? PrjCost { get; set; }

    public string? ProjectName { get; set; }

    public float? ValueTotal { get; set; }

    public float? ConvergenceWithOtherMissions { get; set; }

    public string? ActualDateOfProjectStart { get; set; }

    public string? ProjectEndDate { get; set; }

    public string? StateName { get; set; }

    public string? CityName { get; set; }

    public string? Milestone { get; set; }

    public string? Category { get; set; }

    public float? Scm { get; set; }

    public float? TotalWo { get; set; }

    public float? Ppp { get; set; }

    public float? Debt { get; set; }

    public float? Bonds { get; set; }

    public float? Loans { get; set; }

    public float? OwnResources { get; set; }

    public float? OtherSources { get; set; }

    public float? Total { get; set; }

    public float? Utilization { get; set; }

    public string? ActualDateOfProjectCompleti { get; set; }

    public string? InternalCategory { get; set; }

    public string? PhysicalProgress { get; set; }

    public string? FinancialProgress { get; set; }

    public string? Isdeleted { get; set; }

    public float? GeometryX { get; set; }

    public float? GeometryY { get; set; }
}
