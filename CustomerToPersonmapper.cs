using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Essentials;

public class CustomerToPersonmapper : IMapper<Customer, Person>
    {
    public Person Map(Customer source)
        {
        return new Person
            {
            Id = source.Id,
            FirstName = source.FirstName,
            LastName = source.LastName,
            };
        }
    }
