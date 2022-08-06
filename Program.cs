using LinkedIn.Essentials;

Employee e = new Employee("Ahmed", "Dewedar")
    {
    Id = 875,
    StartDate = new DateOnly(2021, 1, 15)
    };
Console.WriteLine($"Welcome {e.FirstName} {e.LastName} as an Employer with ID {e.Id} can start work at {e.StartDate}.");

//PremiereCustomer pCust = new PremiereCustomer(2);
PremiereCustomer pCust = new PremiereCustomer() { CustomerLevel = 2};
pCust.FirstName = "Edge";
Console.WriteLine($"{pCust.FirstName} has level {pCust.CustomerLevel}.");

Manager m = new Manager("Ahmed", "Dewedar");
m.SetReports(3);
Console.WriteLine($"Manager {m.FirstName} {m.LastName} has {m.NumberOfDirectReports} Reports.");
