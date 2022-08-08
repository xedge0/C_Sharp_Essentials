using C_Sharp_Essentials;


var c1 = new Customer { Id = 5, FirstName = "Stone", LastName = "Edge", CreateDate = new DateOnly(2014,01,22) };
var c2 = new Customer { Id = 2, FirstName = "Alex", LastName = "Stone", CreateDate = new DateOnly(2010, 04, 13) };

var mapper = new CustomerToPersonmapper();
var p = c1.Map<Person>(mapper);  //mapper.Map(c);
Console.WriteLine(p.FirstName);

var sorter = new sorter<Customer>();
var customers = new Customer[] { c1, c2 };
sorter.sort(customers);

foreach (var customer in customers)
    {
    Console.WriteLine($"Customer : {customer.Id} \t : {customer.FirstName} {customer.LastName} \t Joined : {customer.CreateDate}");
    }