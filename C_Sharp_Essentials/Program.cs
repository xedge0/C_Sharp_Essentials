using C_Sharp_Essential.Library;
using C_Sharp_Essential.Library.Extensions;
using System.Xml.Linq;

var employees = new List<Employee>
    {
    new Employee("Edge","Stone",1),
    new Employee("Alex","Stone",2),
    new Employee("Omar","Khan",3),
    new Employee("Rewan","Adel",4),
    new Employee("Sam","Adam",5)
    };

var filteredEmployees = employees
        .Where((e) => e.ID >= 2)
        .Select((es) => new { FirstName = es.FirstName, LastName = es.LastName });
foreach(var emp in filteredEmployees)
    {
    Console.WriteLine(emp.FirstName);
    }

Console.WriteLine();

var fEmployee = (from emp in employees
                 where emp.ID >= 2
                 orderby emp.ID descending
                 select emp).Skip(1).Take(3);
foreach(var emp in fEmployee)
    {
    Console.WriteLine(emp.FirstName);
    }

Console.WriteLine();

var xEmpoyees = XElement.Load("..\\..\\..\\Employees.xml");
var xEmpLinq = from xEmp in xEmpoyees.Descendants("Employee")
               where (int)xEmp.Element("Id") >= 2
               select new
                   {
                   FirstName = xEmp.Element("FirstName")?.Value,
                   LastName = xEmp.Element("LastName")?.Value
                   };
foreach(var xEmp in xEmpLinq)
    {
    Console.WriteLine($"Employee : {xEmp.FirstName} \t Mission: {xEmp.LastName}");
    }
