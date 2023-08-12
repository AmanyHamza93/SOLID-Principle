using SOLIDPrincple.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincple.DIP
{
    internal class SalaryPaidFactory
    {
        public static IEmployeesSalaryPaidInsertion create()
        {
            return new EmployeesSalaryPaidInsertion();
        }
    }
}
