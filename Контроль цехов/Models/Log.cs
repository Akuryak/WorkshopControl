using System;
using System.Collections.Generic;

namespace УППО_Пропуски.Models;

public partial class Log
{
    public DateTime Datetime { get; set; }

    public string Action { get; set; } = null!;

    public int Employee { get; set; }

    public virtual Employee EmployeeNavigation { get; set; } = null!;

    public Log()
    {
    }

    public Log(DateTime datetime, string action, int employee, Employee employeeNavigation)
    {
        Datetime = datetime;
        Action = action;
        Employee = employee;
        EmployeeNavigation = employeeNavigation;
    }
}
