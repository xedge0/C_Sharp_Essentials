﻿namespace C_Sharp_Essentials;
public static class CollectionSamples
    {
    public static void Queue()
        {
        var q = new System.Collections.Queue();
        q.Enqueue("firstItem");
        q.Enqueue("secondItem");

        string? item = null;

        Console.WriteLine("Using a Queue");
        while((item = (string?)q.Dequeue()) != null)
            {
            Console.WriteLine(item);
            if(q.Count <= 0)
                break;
            }
        }

    public static void Stack()
        {
        var stk = new System.Collections.Generic.Stack<string>();
        stk.Push("firstItem");
        stk.Push("secondItem");

        string? stkItem = null;
        Console.WriteLine();
        Console.WriteLine("Using a stack");

        while((stkItem = stk.Pop()) != null)
            {
            Console.WriteLine(stkItem);
            if(stk.Count <= 0)
                break;
            }
        }

    private static List<Customer> customers;

    static CollectionSamples()
        {
        //initialize new customers and add to list
        customers = new List<Customer>();

        for(int i = 1; i < 11; i++)
            {
            customers.Add(
                new Customer
                    {
                    Id = i,
                    FirstName = i.ToString(),
                    LastName = "Customer",
                    CreateDate = new DateOnly(2021, 10, i)
                    });
            }
        }

    public static void Indexing()
        {
        //get an item at a specific index
        var customerThree = customers[2];
        Console.WriteLine($"Found customer {customerThree.Id} at index 2");

        //check if a collection contains an item
        string doesContain = customers.Contains(customerThree) ? "does" : "doesn't";
        Console.WriteLine($"Customers {doesContain} contain {customerThree?.FirstName} customer.");
        //FOLLOW UP: What if you created a new customer object with the same property values?
        //FOLLOW UP: Same as before, but what if customer was a record type or value type instead of a class?

        //use a predicate to find an item in the collection
        var CustomerFinder = customers.Find(CustomerIsMatch);

        if(CustomerFinder != null)
            {
            Console.WriteLine($"Found customer {CustomerFinder.Id}");
            }
        else
            {
            Console.WriteLine($"No customer found with this ID.");
            }

        }

    private static bool CustomerIsMatch(Customer c)
        {
        return c.Id == 17;
        //FOLLOW UP: What happens if your expression matches more than one item?
        }

    public static void Iterating()
        {
        //reverse the order of the list
        customers.Reverse();

        IEnumerator<Customer> custEnum = customers.GetEnumerator();
        while(custEnum.MoveNext())
            {
            Customer current = custEnum.Current;
            Console.WriteLine($"{current.FirstName} {current.LastName}");
            }

        //sort the customers
        customers.Sort();  // or in our case, Reverse would do the same

        //or using foreach
        foreach(var customer in customers)
            {
            Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
        }
    }
