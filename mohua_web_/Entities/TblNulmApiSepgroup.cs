using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblNulmApiSepgroup
{
    public int? StateCode { get; set; }

    public string? StateName { get; set; }

    public int? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public int? UlbCode { get; set; }

    public string? UlbName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? LoanSanctionedDate { get; set; }

    public float? LoanSanctionedAmnt { get; set; }

    public string? CclSanctionDate { get; set; }

    public float? CashCreditLimit { get; set; }
}
