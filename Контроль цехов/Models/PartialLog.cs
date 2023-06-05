using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УППО_Пропуски.Models
{
    public partial class Log
    {
        public string EmployeeFullName { get { return $"{EmployeeNavigation.Surname} {EmployeeNavigation.Name} {EmployeeNavigation.Patronomic}"; } }
    }
}
