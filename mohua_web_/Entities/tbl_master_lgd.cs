using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;
public partial class tbl_master_lgd
{
    public int state_code { get; set; }

    public string? state_name { get; set; }


    public float? district_code { get; set; }
    public string? district_name { get; set; }
    public float? ulb_code { get; set; }
    public string? ulb_name { get; set; }

}

