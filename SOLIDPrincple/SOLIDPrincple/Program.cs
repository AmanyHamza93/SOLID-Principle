using SOLIDPrincple;
using SOLIDPrincple.DIP;
using SOLIDPrincple.ISP;
using SOLIDPrincple.LSP;
using SOLIDPrincple.OCP;
using SOLIDPrincple.SRP;

/* 
 * SRP
 * Every class must be single responsibility and one reason to change in this class
 */
Employee employee = new Employee();
employee.Id = 1;
employee.Name = "Amany";
employee.Salary = 1000;
EmployeesSalaryPaidInsertion employeesInsertionAndUpdate = new EmployeesSalaryPaidInsertion();
employeesInsertionAndUpdate.Insert(employee);
/* 
 * OCP
 * Open for Extension Closed for Modification
 */
Circle circle = new Circle(4);
double circleResult = circle.Area();
Console.WriteLine(circleResult);
Rectangular rectangular = new Rectangular(6, 2);
double rectangularResult = rectangular.Area();
Console.WriteLine(rectangularResult);
/* 
 * LSP
 * Must be able to substitute any parent class with it's child class and make 
 * the same behaviour without addition or modification or unexpected behaviour
 */
FiredEmployee Employee = new SalaryEmployee();
Employee.Name = "Atef";
Fire(Employee);
Employee = new IntershipEmployee();
Employee.Name = "Hamza";
Fire(Employee);
Employee = new FreeLancerEmployee();
Employee.Name = "Doaa";
Fire(Employee);
 void Fire (FiredEmployee employee)
{
    Console.WriteLine("Employee Fired Name is : " + employee.Name);
}
/* 
 * ISP
 * Client must not use fat interfaces contain operations doesn't use
 * Instead seperate fat interface to small interfaces each perform seperate operation
 */
IWorkOnTask person1 = new Programer();
person1.WorkOnTask();
person1 = new TeamLeader();
person1.WorkOnTask();
IAssignTask person2 = new TeamLeader();
person2.AssignTask();
person2 = new ProjectManager();
person2.AssignTask();
/* 
 * DIP
 * High level classes doesn't depend on low level classes and both depend on abstraction
 * BACK TO FIRST EXAMPLE
 */
Employee dipEmployee = new Employee();
dipEmployee.Id = 1;
dipEmployee.Name = "Amany";
dipEmployee.Salary = 1000;
IEmployeesSalaryPaidInsertion factory = SalaryPaidFactory.create();
factory.Insert(employee);



