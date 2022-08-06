using LinkedIn.Essentials;

Classes();
Structs();
Records();


static void Classes()
    {
    Console.WriteLine("=========== Classes = reference types ===========");
    //Create an employee
    Employee me = new Employee
        {
        FirstName = "Ahmed",
        LastName = "Dewedar",
        Age = new Age { BirthDate = new DateTime(1990, 2, 2), YearsOld = 32 },
        Id = 1
        };

    //create another reference to the employee
    IPerson other = me;
    other.FirstName = "Edge";
    other.Age = new Age { BirthDate = new DateTime(2020, 1, 1), YearsOld = 2 };

    //examine results of the original object
    // both objects reference to the same memory
    Console.WriteLine($"{me.FirstName} {me.LastName} is {me.Age.YearsOld} but {other.FirstName} {other.LastName} is {other.Age.YearsOld}");
    Console.WriteLine();

    ChangeName(other);
    //using ref method will globalize any change inside the method
    //ChangeName(ref other);
    Console.WriteLine($"{other.FirstName} {other.LastName} is still {other.Age.YearsOld}");

    Console.WriteLine();
    }

static void ChangeName(IPerson person)
//static void ChangeName(ref IPerson person)
    {
    person.LastName = "xEdge";
    Console.WriteLine($"Person in method is {person.FirstName} {person.LastName}");

    person = new Manager("?Ahmed", "?Dewedar")
        {
        Id = 2,
        Age =
        new Age { BirthDate = new DateTime(1990, 1, 1), YearsOld = 31 }
        };

    Console.WriteLine($"Person after reference change in method is {person.FirstName} {person.LastName}");
    }
static void Structs()
    {
    Console.WriteLine("=========== Structs = value types ===========");

    Age myAge = new Age { BirthDate = new DateTime(1990, 2, 2), YearsOld = 32 };
    Age anotherAge = myAge;

    anotherAge.YearsOld = 40;

    Console.WriteLine($"My age is {myAge.YearsOld}, but I changed it to {anotherAge.YearsOld}");

    AgeBackwords(ref anotherAge, 5);

    Console.WriteLine($"Now I am {anotherAge.YearsOld}");
    Console.WriteLine();
    }

static void Records()
    {
    Console.WriteLine("=========== Records = reference or value types ===========");

    PremiereCustomer pc = new PremiereCustomer
        {
        FirstName = "Customer",
        LastName = "One",
        Id = 7,
        Age = new Age { BirthDate = DateTime.Now, YearsOld = 1 },
        CustomerLevel = 1
        };

    PremiereCustomer pc2 = pc with { CustomerLevel = 2, LastName = "Two" };

    Console.WriteLine($"{pc.FirstName} {pc.LastName} has a level of {pc.CustomerLevel}");
    Console.WriteLine($"{pc2.FirstName} {pc2.LastName} has a level of {pc2.CustomerLevel}");
    ChangeName((IPerson)pc);
    Console.WriteLine($"{pc.FirstName} {pc.LastName} is still {pc.Age.YearsOld}");

    }

static void AgeBackwords(ref Age startingAge, int numberOfYearsToAge)
    {
    startingAge.YearsOld = startingAge.YearsOld - numberOfYearsToAge;
    Console.WriteLine($"Modified age in method: {startingAge.YearsOld}");
    }




