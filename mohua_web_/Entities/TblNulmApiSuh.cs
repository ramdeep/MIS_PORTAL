using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblNulmApiSuh
{
    public int? StateCode { get; set; }

    public string? StateName { get; set; }

    public int? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public int? UlbCode { get; set; }

    public string? UlbName { get; set; }

    public string? ShelterName { get; set; }

    public float? Capacity { get; set; }

    public string? Sheltertype { get; set; }

    public string? Sheltersubtype { get; set; }

    public string? Address { get; set; }
}
