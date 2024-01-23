using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Employee
{
    public int Eid { get; set; }

    public string? Ename { get; set; }

    public double? Salary { get; set; }

    public DateOnly? Doj { get; set; }

    public string? City { get; set; }

    public bool? Etype { get; set; }

    public int? Deptid { get; set; }

    public virtual Department? Dept { get; set; }
}
