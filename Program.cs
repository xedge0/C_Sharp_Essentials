using C_Sharp_Essentials;


var c = new Customer { Id = 1, FirstName = "Stone", LastName = "Edge", CreateDate = new DateOnly(2000,01,22) };

var mapper = new CustomerToPersonmapper();
var p = c.Map<Person>(mapper);  //mapper.Map(c);
Console.WriteLine(p.FirstName);
