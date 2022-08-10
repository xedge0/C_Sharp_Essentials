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


foreach(var e in filteredEmployees)
    {
    Console.WriteLine(e.FirstName);
    }
