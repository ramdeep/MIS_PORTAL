using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblNulmApiSepbeneficiary
{
    public int? StateCode { get; set; }

    public string? StateName { get; set; }

    public int? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public int? UlbCode { get; set; }

    public string? UlbName { get; set; }

    public string? BeneficiaryCode { get; set; }

    public string? BeneficieryName { get; set; }

    public string? Mudraloantype { get; set; }

    public string? LoanSanctionedDate { get; set; }

    public int? LoanSanctionedAmnt { get; set; }

    public string? CclSanctionDate { get; set; }

    public int? CashCreditLimit { get; set; }
}
