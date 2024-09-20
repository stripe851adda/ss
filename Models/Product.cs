using System;
using System.Collections.Generic;

namespace Day23ex2.Models;

public partial class Product
{
    public int Pid { get; set; }

    public string? Pname { get; set; }

    public DateOnly? PmfDate { get; set; }

    public double? Pprice { get; set; }

    public string? Pcompany { get; set; }

    public int? Pqty { get; set; }
}
