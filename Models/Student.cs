using System;
using System.Collections.Generic;

namespace firstapi.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string Sname { get; set; } = null!;

    public double? Marks { get; set; }

    public DateOnly? Doj { get; set; }

    public string? Email { get; set; }

    public string? Subject { get; set; }
}
