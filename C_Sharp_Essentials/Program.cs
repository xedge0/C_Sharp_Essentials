using C_Sharp_Essential.Library;
using C_Sharp_Essential.Library.Extensions;

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

var fEmployee = (from emp in employees
                where emp.ID >= 2
                orderby emp.ID descending
                select emp).Skip(1).Take(3); //new { FirstName = emp.FirstName, LastName = emp.LastName };


foreach(var emp in fEmployee)
    {
    Console.WriteLine(emp.FirstName);
    }
