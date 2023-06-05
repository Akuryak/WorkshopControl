using System;
using System.Collections.Generic;

namespace УППО_Пропуски.Models;

public partial class Request
{
    public int Id { get; set; }

    public int EmployeeMakingRequest { get; set; }

    public int TargetEmployee { get; set; }

    public string Discription { get; set; } = null!;

    public sbyte Accepted { get; set; }
}
