using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblPmay
{
    public int? Statecode { get; set; }

    public string? Statename { get; set; }

    public int? Citycode { get; set; }

    public string? Cityname { get; set; }

    public float? Projectcost { get; set; }

    public float? Centralassistanceinvolved { get; set; }

    public float? Centralassistancereleased { get; set; }

    public float? Ucreceived { get; set; }

    public int? Noofhouse { get; set; }

    public int? Housesunderprogress { get; set; }

    public int? Housescompleted { get; set; }

    public int? Housesallotted { get; set; }

    public int? Housesoccupied { get; set; }

    public int? Housesunoccupied { get; set; }

    public int? Housesyettogrounded { get; set; }

    public int? Lgdcode { get; set; }

    public int? Districtlgcode { get; set; }

    public string? Component { get; set; }

    public string? Approveddate { get; set; }

    public string? Districtname { get; set; }

    public string? Nameshittingmp { get; set; }

    public string? Parlconstname { get; set; }
}
