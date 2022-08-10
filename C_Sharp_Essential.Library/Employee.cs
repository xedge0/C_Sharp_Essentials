namespace C_Sharp_Essential.Library;

public record Employee
    {
    public Employee(string fn, string ln, int id)
        {
        FirstName = fn;
        LastName = ln;
        ID = id;
        }

    private string? fName;

    public int ID { get; init; }
    public string? FirstName { get => fName; init => fName = value; }
    public string? LastName { get; set; }

    public override string ToString() => $"{FirstName}_{LastName}";
    }
