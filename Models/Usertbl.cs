using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Usertbl
{
    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Username { get; set; }
}
