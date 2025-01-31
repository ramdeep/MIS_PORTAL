using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblSbmBacklog
{
    public int? Swmid { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? Statename { get; set; }

    public string? Districtname { get; set; }

    public int? Censuscode { get; set; }

    public int? Ulbcode { get; set; }

    public string? Ulbname { get; set; }

    public int? Totalwards { get; set; }

    public int? Wardswith100percentd2dcollection { get; set; }

    public int? Wardswith100percentsourcesegregation { get; set; }

    public double? Generationmtd { get; set; }

    public double? Processedmtd { get; set; }

    public string? Wasteprocessingprecentage { get; set; }
}
