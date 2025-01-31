using System;
using System.Collections.Generic;

namespace mohua_web_.Entities;

public partial class TblLogin
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Confirmpassword { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public DateTime Logindatetime { get; set; }

    public string Sessionid { get; set; } = null!;

    public string Studsessid { get; set; } = null!;

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Usertype { get; set; }

    public int? Userrole { get; set; }

    public string? Status { get; set; }
}
