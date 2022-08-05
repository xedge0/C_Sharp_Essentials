using LinkedIn.Essentials;

Employee e1 = new Employee("Ahmed", "Dewedar");
Console.WriteLine($"Welcome {e1.FirstName} {e1.LastName} as an Employer.");

Employee e2 = new Employee()
    {
    FirstName = "Ahmed",
    LastName = "Dewedar",
    Id = 45
    };

Console.WriteLine($"{e2.FirstName} {e2.LastName} has Id {e2.Id}");


Employee m = new Manager("Ahmed", "Dewedar");
Console.WriteLine($"Welcome {m.FirstName} {m.LastName} as a Manager.");
