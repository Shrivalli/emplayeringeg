using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Customer
{
    public int Cid { get; set; }

    public string? Cname { get; set; }

    public int? Salary { get; set; }

    public DateOnly? Doj { get; set; }

    public string? Phno { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
