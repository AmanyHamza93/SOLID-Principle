namespace SOLIDPrincple.SRP
{
    internal class SendingMessageWhenSalarySent
    {
        public SendingMessageWhenSalarySent() { }
        public void SendSalaryMessage(Employee employee)
        {
            Console.WriteLine("Hi " + employee.Name);
            Console.WriteLine("your salary has been sent with value " + employee.Salary);
        }
    }
}
