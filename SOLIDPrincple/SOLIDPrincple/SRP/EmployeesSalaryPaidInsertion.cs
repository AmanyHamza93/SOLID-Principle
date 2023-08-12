using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDPrincple.DIP;

namespace SOLIDPrincple.SRP
{
    internal class EmployeesSalaryPaidInsertion : IEmployeesSalaryPaidInsertion
    {
        List<Employee> employees = new List<Employee>();
        public void Insert(Employee employee)
        {
            employees.Add(employee);
            SendMail(employee);
        }
        private void SendMail(Employee employee)
        {
            SendingMessageWhenSalarySent sendingMessageWhenSalarySent = new SendingMessageWhenSalarySent();
            sendingMessageWhenSalarySent.SendSalaryMessage(employee);
        }
    }
}
