namespace C_Sharp_Essential_Library;

internal record Employee
    {

    //public Employee(string fn)
    //    {
    //        FirstName = fn;
    //    }
    public Employee(string fn) => FirstName = fn;   

    private string? fName;

    public int ID { get; init; }
    public string? FirstName { get => fName; init => fName = value; }
    public string? LastName { get; set; }

    public override string ToString() => $"{FirstName}_{LastName}";
    }
