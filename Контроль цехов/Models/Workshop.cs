using System;
using System.Collections.Generic;

namespace УППО_Пропуски.Models;

public partial class Workshop
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
