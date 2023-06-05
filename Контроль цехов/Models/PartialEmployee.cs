using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УППО_Пропуски.Models
{
    public partial class Employee
    {
        public string DivisionName { get { return SubdivisionNavigation == null ? "-" :  SubdivisionNavigation.Name; } }
        public string WorkshopName { get { return WorkshopNavigation == null ? "-" : WorkshopNavigation.Name; } }
        public string StringCanVisitOtherWorkshops { get { return CanVisitOtherWorkshops == 0 ? "Нет" : "Да"; } }
        public string BirthdateShortString { get { return Birthdate.ToShortDateString(); } }
        public string IsVerificatedString { get { return IsVerificated == 1 ? "Да" : "Нет"; } }
    }
}
